using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace XSKT
{
    public partial class Form1 : Form
    {
        bool firstRunFlag = true, firstRunFlag2 = true, firstRunFlag3 = true;

        string filesPath = Environment.CurrentDirectory + "\\XSKTFiles\\";
        int rowCount, colCount = 1;

        List<string> fileName = new List<string>();
        List<int> newData = new List<int>();
        List<List<int>> data = new List<List<int>>();
        List<List<MyNode>> dataPredict = new List<List<MyNode>>();
        

        

        public class MyNode
        {
            public int number;
            public int count;
            public float percent;

            public MyNode(int number, int count)
            {
                this.count = count;
                this.number = number;
            }
        }
        public class SortNode : IComparer
        {
            public int Compare(object x, object y)
            {
                // Ép kiểu 2 object truyền vào về MyNode.
                MyNode p1 = x as MyNode;
                MyNode p2 = y as MyNode;

                /*
                 * Vì có thể 2 object truyền vào không phải Person khi đó ta không thể so sánh được.
                 * Trường hợp này tốt nhất ta nên ném ra lỗi để lập trình viên sửa chữa.
                 * Chi tiết về exception sẽ được trình bày ở những bài học sau.
                 */
                if (p1 == null || p2 == null)
                {
                    throw new InvalidOperationException();
                }
                else
                {
                    /*
                     * Khi dữ liệu đã ok thì ta thực hiện so sánh và trả về các giá trị 1 0 -1 tương ứng
                     * lớn hơn, bằng, bé hơn.
                     */
                    if (p1.percent < p2.percent)
                    {
                        return 1;
                    }
                    else if (p1.percent == p2.percent)
                    {
                        return 0;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
        }




        public Form1()
        {
            InitializeComponent();

            fileName = getAllFilesPath(); //sample.xlsx
            if (fileName == null)
            {
                MessageBox.Show("Không được đổi tên Floder chứa files .xlsx (Floder: XSKTFiles)", "Đề nghị", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
                return;
            }
            foreach (string item in fileName)
            {
                cbListFile.Items.Add(item.Split('.')[0]);
            }
            cbListFile.SelectedIndex = 0;
            cbxPrize.SelectedIndex = 0;
        }

        private bool readFile()
        {
            data = new List<List<int>>();

            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(filesPath + cbListFile.SelectedItem.ToString() + ".xlsx");
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            rowCount = xlRange.Rows.Count;
            colCount = xlRange.Columns.Count;

            for (int i = 1; i <= rowCount; i++)
            {
                data.Add(new List<int>());
                for (int j = 1; j <= colCount; j++)
                {
                    //write the value to the console
                    if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                    {
                        data[i - 1].Add(int.Parse(xlRange.Cells[i, j].Value2.ToString()));
                    }
                }
            }

            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //rule of thumb for releasing com objects:
            //  never use two dots, all COM objects must be referenced and released individually
            //  ex: [somthing].[something].[something] is bad

            //release com objects to fully kill excel process from running in the background
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            //close and release
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            //quit and release
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);

            if (rowCount <= 1)
            {
                return false;
            }
            return true;
        }
        private void updateFile()
        {
            string sheetName = "Sheet1";
            try
            {
                Excel.Application oXL = new Excel.Application();
                Excel._Workbook oWB = oXL.Workbooks.Open(filesPath + cbListFile.SelectedItem.ToString() + ".xlsx");
                Excel._Worksheet oSheet = String.IsNullOrEmpty(sheetName) ? (Excel._Worksheet)oWB.ActiveSheet : (Excel._Worksheet)oWB.Worksheets[sheetName];
                Excel.Range xlRange = oSheet.UsedRange;

                rowCount = xlRange.Rows.Count;//18
                colCount = xlRange.Columns.Count;//3

                for (int i = 1; i <= 18; i++)
                {
                    if (rowCount < 17)
                    {
                        oSheet.Cells[i, colCount] = newData[i - 1];
                    }
                    else
                    {
                        oSheet.Cells[i, colCount + 1] = newData[i - 1];
                    }
                    
                }

                oWB.Save();

                MessageBox.Show("Xong nha");

                //cleanup
                GC.Collect();
                GC.WaitForPendingFinalizers();

                //rule of thumb for releasing com objects:
                //  never use two dots, all COM objects must be referenced and released individually
                //  ex: [somthing].[something].[something] is bad

                //release com objects to fully kill excel process from running in the background
                Marshal.ReleaseComObject(oSheet);
                Marshal.ReleaseComObject(xlRange);
                //close and release
                oWB.Close();
                Marshal.ReleaseComObject(oWB);

                //quit and release
                oXL.Quit();
                Marshal.ReleaseComObject(oXL);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Haizz, File đừng mở file .xlsx đó ra hoặc xóa nó khi thêm mới nha, làm vậy lấy file đâu mà ghi dữ liệu. Tắt mở lại đi");
                
                var processes = from p in Process.GetProcessesByName("EXCEL")
                                select p;

                foreach (var process in processes)
                {
                    if (process.MainWindowTitle == "Microsoft Excel - " + cbListFile.SelectedItem.ToString() + ".xlsx")
                        process.Kill();
                }
            }
        }
        private void createFile()
        {
            Excel.Application xlApp = new Excel.Application();

            if (xlApp == null || isExistOne())
            {
                MessageBox.Show("Không thể khởi tạo hoặc trùng tên với đài nào đó rồi, tắt đi rồi mở lại");
                killProcess();
                return;
            }

            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            //Here saving the file in xlsx
            xlWorkBook.SaveAs(filesPath + txtNewFileName.Text + ".xlsx", Excel.XlFileFormat.xlOpenXMLWorkbook, misValue,
            misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);


            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);

            MessageBox.Show("Tạo xong rồi nha");

            cbListFile.Items.Add(txtNewFileName.Text);
            fileName.Add(txtNewFileName.Text + ".xlsx");
        }



        private void combineData()
        {
            List<int> list8 = new List<int>(data[0]);
            List<int> list7 = new List<int>(data[1]);
            List<int> list6 = new List<int>();
            List<int> list5 = new List<int>(data[5]);
            List<int> list4 = new List<int>();
            List<int> list3 = new List<int>();
            List<int> list2 = new List<int>(data[15]);
            List<int> list1 = new List<int>(data[16]);
            List<int> list0 = new List<int>(data[17]);

            for (int i = 2; i <= 4; i++)
            {
                foreach (int item in data[i])
                {
                    list6.Add(item);
                }
            }
            for (int i = 6; i <= 12; i++)
            {
                foreach (int item in data[i])
                {
                    list4.Add(item);
                }
            }
            for (int i = 13; i <= 14; i++)
            {
                foreach (int item in data[i])
                {
                    list3.Add(item);
                }
            }

            data = new List<List<int>>();
            data.Add(list8);
            data.Add(list7);
            data.Add(list6);
            data.Add(list5);
            data.Add(list4);
            data.Add(list3);
            data.Add(list2);
            data.Add(list1);
            data.Add(list0);

        }
        private bool isExistOne()
        {
            foreach (string item in fileName)
            {
                if (item == txtNewFileName.Text)
                {
                    return true;
                }
            }
            return false;
        }
        private List<string> getAllFilesPath()
        {
            List<string> result = new List<string>();
            string[] fileEntries = Directory.GetFiles(filesPath, "*.xlsx");
            foreach (var files in fileEntries)
            {
                FileInfo info = new FileInfo(files);
                var fileName = Path.GetFileName(info.FullName);
                result.Add(fileName);
            }
            if (result.Count == 0)
                return null;
            return result;
        }
        private void killProcess()
        {
            var processes = from p in Process.GetProcessesByName("EXCEL")
                            select p;

            foreach (var process in processes)
            {
                foreach (string item in fileName)
                {
                    if (process.MainWindowTitle.Contains(item))
                        process.Kill();
                }
            }
        }
        private void predict()
        {
            combineData();
            dataPredict = new List<List<MyNode>>();
            for (int i = 0; i < data.Count; i++)
            {
                dataPredict.Add(new List<MyNode>());
                foreach (int value in data[i])
                {
                    if (dataPredict[i].Count == 0)
                    {
                        dataPredict[i].Add(new MyNode(value, 1));
                    }
                    else 
                    {
                        bool flag = false;
                        foreach (MyNode item in dataPredict[i])
                        {
                            if (item.number == value)
                            {
                                item.count++;
                                flag = true;
                            }
                        }
                        if (!flag)
                        {
                            dataPredict[i].Add(new MyNode(value, 1));
                        }
                    }
                }
            }
            foreach (List<MyNode> list in dataPredict)
            {
                int totalNode = 0;
                foreach (MyNode item in list)
                {
                    totalNode += item.count;
                }
                foreach (MyNode item in list)
                {
                    item.percent = item.count * 100 / totalNode ;
                }
            }

            for (int i = 0; i < dataPredict.Count; i++)
            {
                ArrayList arrayList = new ArrayList(dataPredict[i]);
                arrayList.Sort(new SortNode());
                dataPredict[i] = arrayList.Cast<MyNode>().ToList();
            }

            txtResult8.Text = (dataPredict[0])[0].number.ToString();
            txtResult7.Text = (dataPredict[1])[0].number.ToString();
            txtResult61.Text = (dataPredict[2])[0].number.ToString();
            if (dataPredict[2].Count >= 2)
            {
                txtResult62.Text = (dataPredict[2])[1].number.ToString();
            }
            if (dataPredict[2].Count >= 3)
            {
                txtResult63.Text = (dataPredict[2])[2].number.ToString();
            }
            
            txtResult5.Text = (dataPredict[3])[0].number.ToString();

            txtResult41.Text = (dataPredict[4])[0].number.ToString();
            if (dataPredict[4].Count >= 2)
            {
                txtResult42.Text = (dataPredict[4])[1].number.ToString();
            }
            if (dataPredict[4].Count >= 3)
            {
                txtResult43.Text = (dataPredict[4])[2].number.ToString();
            }
            if (dataPredict[4].Count >= 4)
            {
                txtResult44.Text = (dataPredict[4])[3].number.ToString();
            }
            if (dataPredict[4].Count >= 5)
            {
                txtResult45.Text = (dataPredict[4])[4].number.ToString();
            }
            if (dataPredict[4].Count >= 6)
            {
                txtResult46.Text = (dataPredict[4])[5].number.ToString();
            }
            if (dataPredict[4].Count >= 7)
            {
                txtResult47.Text = (dataPredict[4])[6].number.ToString();
            }
            txtResult31.Text = (dataPredict[5])[0].number.ToString();

            txtResult32.Text = (dataPredict[6])[0].number.ToString();
            if (dataPredict[6].Count >= 2)
            {
                txtResult2.Text = (dataPredict[6])[1].number.ToString();
            }
            
            txtResult1.Text = (dataPredict[7])[0].number.ToString();
            txtResult0.Text = (dataPredict[8])[0].number.ToString();

        }
        private void clearInputTextBox()
        {
            foreach (TextBox item in gbxInput.Controls.OfType<TextBox>().OrderBy(ctrl => ctrl.TabIndex))
            {
                item.Clear();
            }
        }
        private void clearResultTextBox()
        {
            foreach (TextBox item in groupBox2.Controls.OfType<TextBox>().OrderBy(ctrl => ctrl.TabIndex))
            {
                item.Clear();
            }
        }
        private void showChart(int index)
        {
            SeriesCollection series = new SeriesCollection();
            foreach (var item in dataPredict[index])
            {
                string number = item.number.ToString();
                int count = int.Parse(item.count.ToString());
                series.Add(new PieSeries() { Title = number, Values = new ChartValues<int> { count }, DataLabels = true, LabelPoint = labelPoint });

            }
            pieChart1.Series = series;
            pieChart1.LegendLocation = LegendLocation.Bottom;




            ColumnSeries col = new ColumnSeries()
            {
                DataLabels = true,
                Values = new ChartValues<int>(),
                LabelPoint = point => point.Y.ToString()
            };
            Axis ax = new Axis()
            {
                Separator = new Separator()
                {
                    Step = 1,
                    IsEnabled = false
                }
            };
            ax.Labels = new List<string>();
            foreach (var item in dataPredict[index])
            {
                string number = item.number.ToString();
                int count = int.Parse(item.count.ToString());
                col.Values.Add(count);
                ax.Labels.Add(number.ToString());
            }
            cartesianChart1.Series.Clear();
            cartesianChart1.AxisX.Clear();
            cartesianChart1.AxisY.Clear();

            cartesianChart1.Series.Add(col);
            cartesianChart1.AxisX.Add(ax);
            cartesianChart1.AxisY.Add(new Axis()
            {
                LabelFormatter = value => value.ToString(),
                Separator = new Separator()
            });
        }
        Func<ChartPoint, string> labelPoint = chartpoint => string.Format("xuất hiện {0} lần", chartpoint.Y);
        
        
        private void setListPredict(int index)
        {
            lsv.Items.Clear();
            foreach (var item in dataPredict[index])
            {
                string number = item.number.ToString();
                string count = item.count.ToString();
                lsv.Items.Add(number + ": " + count + " lần");
            }
        }


        private void btnNewData_Click(object sender, EventArgs e)
        {
            newData = new List<int>();
            foreach (TextBox item in gbxInput.Controls.OfType<TextBox>().OrderBy(ctrl => ctrl.TabIndex))
            {
                if (string.IsNullOrEmpty(item.Text))
                {
                    MessageBox.Show("Nhập đủ số đã cha", "Đề nghị", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                newData = new List<int>();
                newData.Add(int.Parse(txt8.Text));
                newData.Add(int.Parse(txt7.Text));
                newData.Add(int.Parse(txt61.Text));
                newData.Add(int.Parse(txt62.Text));
                newData.Add(int.Parse(txt63.Text));
                newData.Add(int.Parse(txt5.Text));
                newData.Add(int.Parse(txt41.Text));
                newData.Add(int.Parse(txt42.Text));
                newData.Add(int.Parse(txt43.Text));
                newData.Add(int.Parse(txt44.Text));
                newData.Add(int.Parse(txt45.Text));
                newData.Add(int.Parse(txt46.Text));
                newData.Add(int.Parse(txt47.Text));
                newData.Add(int.Parse(txt31.Text));
                newData.Add(int.Parse(txt32.Text));
                newData.Add(int.Parse(txt2.Text));
                newData.Add(int.Parse(txt1.Text));
                newData.Add(int.Parse(txt0.Text));
            }
            clearResultTextBox();
            clearInputTextBox();
            updateFile();
            readFile();
            predict();
        }
        private void btnNewFile_Click(object sender, EventArgs e)
        {
            createFile();
        }
        private void cbListFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearResultTextBox();
            bool readingResult = readFile();
            if (readingResult)
            {
                predict();
                if (firstRunFlag3)
                {
                    firstRunFlag3 = false;
                    return;
                }
                else
                {
                    showChart(cbxPrize.SelectedIndex);
                    setListPredict(cbxPrize.SelectedIndex);
                }
                
            }
            else if (firstRunFlag)
            {
                firstRunFlag = false;
                return;
            }
            else
            {
                MessageBox.Show("File này mới chưa có dữ liệu nha");
            }
        }
        private void txtNewFileName_Click(object sender, EventArgs e)
        {
            txtNewFileName.SelectAll();
            txtNewFileName.Focus();
        }
        private void cbxPrize_SelectedIndexChanged(object sender, EventArgs e)
        {
            showChart(cbxPrize.SelectedIndex);
            setListPredict(cbxPrize.SelectedIndex);
        }
        private void txtCheck_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch((sender as TextBox).Text, "[^0-9]"))
            {
                MessageBox.Show("Nhập số vô thôi cha", "Đề nghị", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                (sender as TextBox).Text = (sender as TextBox).Text.Remove((sender as TextBox).Text.Length - 1);
            }
            if ((sender as TextBox).Text.Length == 2)
            {
                foreach (TextBox control in gbxInput.Controls.OfType<TextBox>().OrderBy(ctrl => ctrl.TabIndex))
                {
                    if (control.TabIndex == (sender as TextBox).TabIndex + 1)
                    {
                        control.Focus();
                        break;
                    }
                }
            }
                
        }
    }
}
