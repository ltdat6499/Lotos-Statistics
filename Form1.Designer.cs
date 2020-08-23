namespace XSKT
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlChart = new System.Windows.Forms.Panel();
            this.cbxPrize = new System.Windows.Forms.ComboBox();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.txtNewFileName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtResult0 = new System.Windows.Forms.TextBox();
            this.txtResult1 = new System.Windows.Forms.TextBox();
            this.txtResult2 = new System.Windows.Forms.TextBox();
            this.txtResult32 = new System.Windows.Forms.TextBox();
            this.txtResult31 = new System.Windows.Forms.TextBox();
            this.txtResult47 = new System.Windows.Forms.TextBox();
            this.txtResult46 = new System.Windows.Forms.TextBox();
            this.txtResult45 = new System.Windows.Forms.TextBox();
            this.txtResult44 = new System.Windows.Forms.TextBox();
            this.txtResult43 = new System.Windows.Forms.TextBox();
            this.txtResult42 = new System.Windows.Forms.TextBox();
            this.txtResult41 = new System.Windows.Forms.TextBox();
            this.txtResult5 = new System.Windows.Forms.TextBox();
            this.txtResult63 = new System.Windows.Forms.TextBox();
            this.txtResult62 = new System.Windows.Forms.TextBox();
            this.txtResult61 = new System.Windows.Forms.TextBox();
            this.txtResult7 = new System.Windows.Forms.TextBox();
            this.txtResult8 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.gbxInput = new System.Windows.Forms.GroupBox();
            this.btnNewData = new System.Windows.Forms.Button();
            this.txt0 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt32 = new System.Windows.Forms.TextBox();
            this.txt31 = new System.Windows.Forms.TextBox();
            this.txt47 = new System.Windows.Forms.TextBox();
            this.txt46 = new System.Windows.Forms.TextBox();
            this.txt45 = new System.Windows.Forms.TextBox();
            this.txt44 = new System.Windows.Forms.TextBox();
            this.txt43 = new System.Windows.Forms.TextBox();
            this.txt42 = new System.Windows.Forms.TextBox();
            this.txt41 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt63 = new System.Windows.Forms.TextBox();
            this.txt62 = new System.Windows.Forms.TextBox();
            this.txt61 = new System.Windows.Forms.TextBox();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.txt8 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbListFile = new System.Windows.Forms.ComboBox();
            this.btnNewFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lsv = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.pnlChart.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbxInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pnlChart);
            this.panel1.Controls.Add(this.txtNewFileName);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.gbxInput);
            this.panel1.Controls.Add(this.cbListFile);
            this.panel1.Controls.Add(this.btnNewFile);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 775);
            this.panel1.TabIndex = 0;
            // 
            // pnlChart
            // 
            this.pnlChart.Controls.Add(this.lsv);
            this.pnlChart.Controls.Add(this.cbxPrize);
            this.pnlChart.Controls.Add(this.pieChart1);
            this.pnlChart.Controls.Add(this.cartesianChart1);
            this.pnlChart.Location = new System.Drawing.Point(13, 550);
            this.pnlChart.Name = "pnlChart";
            this.pnlChart.Size = new System.Drawing.Size(992, 435);
            this.pnlChart.TabIndex = 41;
            // 
            // cbxPrize
            // 
            this.cbxPrize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPrize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPrize.FormattingEnabled = true;
            this.cbxPrize.Items.AddRange(new object[] {
            "Giải 8",
            "Giải 7",
            "Giải 6",
            "Giải 5",
            "Giải 4",
            "Giải 3",
            "Giải 2",
            "Giải 1",
            "Giải ĐB"});
            this.cbxPrize.Location = new System.Drawing.Point(12, 6);
            this.cbxPrize.MaxDropDownItems = 30;
            this.cbxPrize.Name = "cbxPrize";
            this.cbxPrize.Size = new System.Drawing.Size(300, 28);
            this.cbxPrize.TabIndex = 38;
            this.cbxPrize.SelectedIndexChanged += new System.EventHandler(this.cbxPrize_SelectedIndexChanged);
            // 
            // pieChart1
            // 
            this.pieChart1.Location = new System.Drawing.Point(508, 55);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(477, 278);
            this.pieChart1.TabIndex = 1;
            this.pieChart1.Text = "pieChart1";
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartesianChart1.Location = new System.Drawing.Point(12, 55);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(472, 278);
            this.cartesianChart1.TabIndex = 0;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // txtNewFileName
            // 
            this.txtNewFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewFileName.Location = new System.Drawing.Point(662, 15);
            this.txtNewFileName.Name = "txtNewFileName";
            this.txtNewFileName.Size = new System.Drawing.Size(202, 26);
            this.txtNewFileName.TabIndex = 40;
            this.txtNewFileName.Text = "Nhập tên bảng mới vô đây";
            this.txtNewFileName.Click += new System.EventHandler(this.txtNewFileName_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtResult0);
            this.groupBox2.Controls.Add(this.txtResult1);
            this.groupBox2.Controls.Add(this.txtResult2);
            this.groupBox2.Controls.Add(this.txtResult32);
            this.groupBox2.Controls.Add(this.txtResult31);
            this.groupBox2.Controls.Add(this.txtResult47);
            this.groupBox2.Controls.Add(this.txtResult46);
            this.groupBox2.Controls.Add(this.txtResult45);
            this.groupBox2.Controls.Add(this.txtResult44);
            this.groupBox2.Controls.Add(this.txtResult43);
            this.groupBox2.Controls.Add(this.txtResult42);
            this.groupBox2.Controls.Add(this.txtResult41);
            this.groupBox2.Controls.Add(this.txtResult5);
            this.groupBox2.Controls.Add(this.txtResult63);
            this.groupBox2.Controls.Add(this.txtResult62);
            this.groupBox2.Controls.Add(this.txtResult61);
            this.groupBox2.Controls.Add(this.txtResult7);
            this.groupBox2.Controls.Add(this.txtResult8);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(521, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 481);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "KẾT QUẢ DỰ ĐOÁN";
            // 
            // txtResult0
            // 
            this.txtResult0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult0.Location = new System.Drawing.Point(84, 390);
            this.txtResult0.MaxLength = 2;
            this.txtResult0.Name = "txtResult0";
            this.txtResult0.ReadOnly = true;
            this.txtResult0.Size = new System.Drawing.Size(51, 26);
            this.txtResult0.TabIndex = 58;
            // 
            // txtResult1
            // 
            this.txtResult1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult1.Location = new System.Drawing.Point(84, 345);
            this.txtResult1.MaxLength = 2;
            this.txtResult1.Name = "txtResult1";
            this.txtResult1.ReadOnly = true;
            this.txtResult1.Size = new System.Drawing.Size(51, 26);
            this.txtResult1.TabIndex = 57;
            // 
            // txtResult2
            // 
            this.txtResult2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult2.Location = new System.Drawing.Point(84, 300);
            this.txtResult2.MaxLength = 2;
            this.txtResult2.Name = "txtResult2";
            this.txtResult2.ReadOnly = true;
            this.txtResult2.Size = new System.Drawing.Size(51, 26);
            this.txtResult2.TabIndex = 56;
            // 
            // txtResult32
            // 
            this.txtResult32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult32.Location = new System.Drawing.Point(141, 255);
            this.txtResult32.MaxLength = 2;
            this.txtResult32.Name = "txtResult32";
            this.txtResult32.ReadOnly = true;
            this.txtResult32.Size = new System.Drawing.Size(51, 26);
            this.txtResult32.TabIndex = 55;
            // 
            // txtResult31
            // 
            this.txtResult31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult31.Location = new System.Drawing.Point(84, 255);
            this.txtResult31.MaxLength = 2;
            this.txtResult31.Name = "txtResult31";
            this.txtResult31.ReadOnly = true;
            this.txtResult31.Size = new System.Drawing.Size(51, 26);
            this.txtResult31.TabIndex = 54;
            // 
            // txtResult47
            // 
            this.txtResult47.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult47.Location = new System.Drawing.Point(426, 207);
            this.txtResult47.MaxLength = 2;
            this.txtResult47.Name = "txtResult47";
            this.txtResult47.ReadOnly = true;
            this.txtResult47.Size = new System.Drawing.Size(51, 26);
            this.txtResult47.TabIndex = 53;
            // 
            // txtResult46
            // 
            this.txtResult46.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult46.Location = new System.Drawing.Point(369, 207);
            this.txtResult46.MaxLength = 2;
            this.txtResult46.Name = "txtResult46";
            this.txtResult46.ReadOnly = true;
            this.txtResult46.Size = new System.Drawing.Size(51, 26);
            this.txtResult46.TabIndex = 52;
            // 
            // txtResult45
            // 
            this.txtResult45.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult45.Location = new System.Drawing.Point(312, 207);
            this.txtResult45.MaxLength = 2;
            this.txtResult45.Name = "txtResult45";
            this.txtResult45.ReadOnly = true;
            this.txtResult45.Size = new System.Drawing.Size(51, 26);
            this.txtResult45.TabIndex = 51;
            // 
            // txtResult44
            // 
            this.txtResult44.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult44.Location = new System.Drawing.Point(255, 207);
            this.txtResult44.MaxLength = 2;
            this.txtResult44.Name = "txtResult44";
            this.txtResult44.ReadOnly = true;
            this.txtResult44.Size = new System.Drawing.Size(51, 26);
            this.txtResult44.TabIndex = 50;
            // 
            // txtResult43
            // 
            this.txtResult43.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult43.Location = new System.Drawing.Point(198, 207);
            this.txtResult43.MaxLength = 2;
            this.txtResult43.Name = "txtResult43";
            this.txtResult43.ReadOnly = true;
            this.txtResult43.Size = new System.Drawing.Size(51, 26);
            this.txtResult43.TabIndex = 49;
            // 
            // txtResult42
            // 
            this.txtResult42.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult42.Location = new System.Drawing.Point(141, 207);
            this.txtResult42.MaxLength = 2;
            this.txtResult42.Name = "txtResult42";
            this.txtResult42.ReadOnly = true;
            this.txtResult42.Size = new System.Drawing.Size(51, 26);
            this.txtResult42.TabIndex = 48;
            // 
            // txtResult41
            // 
            this.txtResult41.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult41.Location = new System.Drawing.Point(84, 207);
            this.txtResult41.MaxLength = 2;
            this.txtResult41.Name = "txtResult41";
            this.txtResult41.ReadOnly = true;
            this.txtResult41.Size = new System.Drawing.Size(51, 26);
            this.txtResult41.TabIndex = 47;
            // 
            // txtResult5
            // 
            this.txtResult5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult5.Location = new System.Drawing.Point(84, 165);
            this.txtResult5.MaxLength = 2;
            this.txtResult5.Name = "txtResult5";
            this.txtResult5.ReadOnly = true;
            this.txtResult5.Size = new System.Drawing.Size(51, 26);
            this.txtResult5.TabIndex = 46;
            // 
            // txtResult63
            // 
            this.txtResult63.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult63.Location = new System.Drawing.Point(198, 120);
            this.txtResult63.MaxLength = 2;
            this.txtResult63.Name = "txtResult63";
            this.txtResult63.ReadOnly = true;
            this.txtResult63.Size = new System.Drawing.Size(51, 26);
            this.txtResult63.TabIndex = 45;
            // 
            // txtResult62
            // 
            this.txtResult62.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult62.Location = new System.Drawing.Point(141, 120);
            this.txtResult62.MaxLength = 2;
            this.txtResult62.Name = "txtResult62";
            this.txtResult62.ReadOnly = true;
            this.txtResult62.Size = new System.Drawing.Size(51, 26);
            this.txtResult62.TabIndex = 44;
            // 
            // txtResult61
            // 
            this.txtResult61.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult61.Location = new System.Drawing.Point(84, 120);
            this.txtResult61.MaxLength = 2;
            this.txtResult61.Name = "txtResult61";
            this.txtResult61.ReadOnly = true;
            this.txtResult61.Size = new System.Drawing.Size(51, 26);
            this.txtResult61.TabIndex = 43;
            // 
            // txtResult7
            // 
            this.txtResult7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult7.Location = new System.Drawing.Point(84, 75);
            this.txtResult7.MaxLength = 2;
            this.txtResult7.Name = "txtResult7";
            this.txtResult7.ReadOnly = true;
            this.txtResult7.Size = new System.Drawing.Size(51, 26);
            this.txtResult7.TabIndex = 42;
            // 
            // txtResult8
            // 
            this.txtResult8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult8.Location = new System.Drawing.Point(84, 30);
            this.txtResult8.MaxLength = 2;
            this.txtResult8.Name = "txtResult8";
            this.txtResult8.ReadOnly = true;
            this.txtResult8.Size = new System.Drawing.Size(51, 26);
            this.txtResult8.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 393);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.TabIndex = 40;
            this.label11.Text = "Giải ĐB: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 348);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 20);
            this.label12.TabIndex = 39;
            this.label12.Text = "Giải 1: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 303);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 20);
            this.label13.TabIndex = 38;
            this.label13.Text = "Giải 2: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 258);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 20);
            this.label14.TabIndex = 37;
            this.label14.Text = "Giải 3: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(8, 213);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 20);
            this.label15.TabIndex = 36;
            this.label15.Text = "Giải 4: ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(8, 168);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 20);
            this.label16.TabIndex = 35;
            this.label16.Text = "Giải 5: ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(8, 123);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 20);
            this.label17.TabIndex = 34;
            this.label17.Text = "Giải 6: ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(8, 78);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 20);
            this.label18.TabIndex = 33;
            this.label18.Text = "Giải 7: ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(8, 33);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 20);
            this.label19.TabIndex = 32;
            this.label19.Text = "Giải 8: ";
            // 
            // gbxInput
            // 
            this.gbxInput.Controls.Add(this.btnNewData);
            this.gbxInput.Controls.Add(this.txt0);
            this.gbxInput.Controls.Add(this.txt1);
            this.gbxInput.Controls.Add(this.txt2);
            this.gbxInput.Controls.Add(this.txt32);
            this.gbxInput.Controls.Add(this.txt31);
            this.gbxInput.Controls.Add(this.txt47);
            this.gbxInput.Controls.Add(this.txt46);
            this.gbxInput.Controls.Add(this.txt45);
            this.gbxInput.Controls.Add(this.txt44);
            this.gbxInput.Controls.Add(this.txt43);
            this.gbxInput.Controls.Add(this.txt42);
            this.gbxInput.Controls.Add(this.txt41);
            this.gbxInput.Controls.Add(this.txt5);
            this.gbxInput.Controls.Add(this.txt63);
            this.gbxInput.Controls.Add(this.txt62);
            this.gbxInput.Controls.Add(this.txt61);
            this.gbxInput.Controls.Add(this.txt7);
            this.gbxInput.Controls.Add(this.txt8);
            this.gbxInput.Controls.Add(this.label10);
            this.gbxInput.Controls.Add(this.label9);
            this.gbxInput.Controls.Add(this.label8);
            this.gbxInput.Controls.Add(this.label7);
            this.gbxInput.Controls.Add(this.label6);
            this.gbxInput.Controls.Add(this.label5);
            this.gbxInput.Controls.Add(this.label4);
            this.gbxInput.Controls.Add(this.label3);
            this.gbxInput.Controls.Add(this.label2);
            this.gbxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxInput.Location = new System.Drawing.Point(13, 63);
            this.gbxInput.Name = "gbxInput";
            this.gbxInput.Size = new System.Drawing.Size(484, 481);
            this.gbxInput.TabIndex = 38;
            this.gbxInput.TabStop = false;
            this.gbxInput.Text = "NHẬP DỮ LIỆU";
            // 
            // btnNewData
            // 
            this.btnNewData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewData.Location = new System.Drawing.Point(12, 432);
            this.btnNewData.Name = "btnNewData";
            this.btnNewData.Size = new System.Drawing.Size(465, 37);
            this.btnNewData.TabIndex = 59;
            this.btnNewData.Text = "NHẬP THÊM DỮ LIỆU VÀO";
            this.btnNewData.UseVisualStyleBackColor = true;
            this.btnNewData.Click += new System.EventHandler(this.btnNewData_Click);
            // 
            // txt0
            // 
            this.txt0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt0.Location = new System.Drawing.Point(84, 390);
            this.txt0.MaxLength = 2;
            this.txt0.Name = "txt0";
            this.txt0.Size = new System.Drawing.Size(51, 26);
            this.txt0.TabIndex = 58;
            this.txt0.TextChanged += new System.EventHandler(this.txtCheck_TextChanged);
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(84, 345);
            this.txt1.MaxLength = 2;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(51, 26);
            this.txt1.TabIndex = 57;
            this.txt1.TextChanged += new System.EventHandler(this.txtCheck_TextChanged);
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2.Location = new System.Drawing.Point(84, 300);
            this.txt2.MaxLength = 2;
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(51, 26);
            this.txt2.TabIndex = 56;
            this.txt2.TextChanged += new System.EventHandler(this.txtCheck_TextChanged);
            // 
            // txt32
            // 
            this.txt32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt32.Location = new System.Drawing.Point(141, 255);
            this.txt32.MaxLength = 2;
            this.txt32.Name = "txt32";
            this.txt32.Size = new System.Drawing.Size(51, 26);
            this.txt32.TabIndex = 55;
            this.txt32.TextChanged += new System.EventHandler(this.txtCheck_TextChanged);
            // 
            // txt31
            // 
            this.txt31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt31.Location = new System.Drawing.Point(84, 255);
            this.txt31.MaxLength = 2;
            this.txt31.Name = "txt31";
            this.txt31.Size = new System.Drawing.Size(51, 26);
            this.txt31.TabIndex = 54;
            this.txt31.TextChanged += new System.EventHandler(this.txtCheck_TextChanged);
            // 
            // txt47
            // 
            this.txt47.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt47.Location = new System.Drawing.Point(426, 207);
            this.txt47.MaxLength = 2;
            this.txt47.Name = "txt47";
            this.txt47.Size = new System.Drawing.Size(51, 26);
            this.txt47.TabIndex = 53;
            this.txt47.TextChanged += new System.EventHandler(this.txtCheck_TextChanged);
            // 
            // txt46
            // 
            this.txt46.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt46.Location = new System.Drawing.Point(369, 207);
            this.txt46.MaxLength = 2;
            this.txt46.Name = "txt46";
            this.txt46.Size = new System.Drawing.Size(51, 26);
            this.txt46.TabIndex = 52;
            this.txt46.TextChanged += new System.EventHandler(this.txtCheck_TextChanged);
            // 
            // txt45
            // 
            this.txt45.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt45.Location = new System.Drawing.Point(312, 207);
            this.txt45.MaxLength = 2;
            this.txt45.Name = "txt45";
            this.txt45.Size = new System.Drawing.Size(51, 26);
            this.txt45.TabIndex = 51;
            this.txt45.TextChanged += new System.EventHandler(this.txtCheck_TextChanged);
            // 
            // txt44
            // 
            this.txt44.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt44.Location = new System.Drawing.Point(255, 207);
            this.txt44.MaxLength = 2;
            this.txt44.Name = "txt44";
            this.txt44.Size = new System.Drawing.Size(51, 26);
            this.txt44.TabIndex = 50;
            this.txt44.TextChanged += new System.EventHandler(this.txtCheck_TextChanged);
            // 
            // txt43
            // 
            this.txt43.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt43.Location = new System.Drawing.Point(198, 207);
            this.txt43.MaxLength = 2;
            this.txt43.Name = "txt43";
            this.txt43.Size = new System.Drawing.Size(51, 26);
            this.txt43.TabIndex = 49;
            this.txt43.TextChanged += new System.EventHandler(this.txtCheck_TextChanged);
            // 
            // txt42
            // 
            this.txt42.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt42.Location = new System.Drawing.Point(141, 207);
            this.txt42.MaxLength = 2;
            this.txt42.Name = "txt42";
            this.txt42.Size = new System.Drawing.Size(51, 26);
            this.txt42.TabIndex = 48;
            this.txt42.TextChanged += new System.EventHandler(this.txtCheck_TextChanged);
            // 
            // txt41
            // 
            this.txt41.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt41.Location = new System.Drawing.Point(84, 207);
            this.txt41.MaxLength = 2;
            this.txt41.Name = "txt41";
            this.txt41.Size = new System.Drawing.Size(51, 26);
            this.txt41.TabIndex = 47;
            this.txt41.TextChanged += new System.EventHandler(this.txtCheck_TextChanged);
            // 
            // txt5
            // 
            this.txt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt5.Location = new System.Drawing.Point(84, 165);
            this.txt5.MaxLength = 2;
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(51, 26);
            this.txt5.TabIndex = 46;
            this.txt5.TextChanged += new System.EventHandler(this.txtCheck_TextChanged);
            // 
            // txt63
            // 
            this.txt63.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt63.Location = new System.Drawing.Point(198, 120);
            this.txt63.MaxLength = 2;
            this.txt63.Name = "txt63";
            this.txt63.Size = new System.Drawing.Size(51, 26);
            this.txt63.TabIndex = 45;
            this.txt63.TextChanged += new System.EventHandler(this.txtCheck_TextChanged);
            // 
            // txt62
            // 
            this.txt62.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt62.Location = new System.Drawing.Point(141, 120);
            this.txt62.MaxLength = 2;
            this.txt62.Name = "txt62";
            this.txt62.Size = new System.Drawing.Size(51, 26);
            this.txt62.TabIndex = 44;
            this.txt62.TextChanged += new System.EventHandler(this.txtCheck_TextChanged);
            // 
            // txt61
            // 
            this.txt61.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt61.Location = new System.Drawing.Point(84, 120);
            this.txt61.MaxLength = 2;
            this.txt61.Name = "txt61";
            this.txt61.Size = new System.Drawing.Size(51, 26);
            this.txt61.TabIndex = 43;
            this.txt61.TextChanged += new System.EventHandler(this.txtCheck_TextChanged);
            // 
            // txt7
            // 
            this.txt7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt7.Location = new System.Drawing.Point(84, 75);
            this.txt7.MaxLength = 2;
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(51, 26);
            this.txt7.TabIndex = 42;
            this.txt7.TextChanged += new System.EventHandler(this.txtCheck_TextChanged);
            // 
            // txt8
            // 
            this.txt8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt8.Location = new System.Drawing.Point(84, 30);
            this.txt8.MaxLength = 2;
            this.txt8.Name = "txt8";
            this.txt8.Size = new System.Drawing.Size(51, 26);
            this.txt8.TabIndex = 41;
            this.txt8.TextChanged += new System.EventHandler(this.txtCheck_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 393);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.TabIndex = 40;
            this.label10.Text = "Giải ĐB: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 348);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 39;
            this.label9.Text = "Giải 1: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "Giải 2: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Giải 3: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Giải 4: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Giải 5: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Giải 6: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Giải 7: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Giải 8: ";
            // 
            // cbListFile
            // 
            this.cbListFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbListFile.FormattingEnabled = true;
            this.cbListFile.Location = new System.Drawing.Point(154, 15);
            this.cbListFile.MaxDropDownItems = 30;
            this.cbListFile.Name = "cbListFile";
            this.cbListFile.Size = new System.Drawing.Size(300, 28);
            this.cbListFile.Sorted = true;
            this.cbListFile.TabIndex = 37;
            this.cbListFile.SelectedIndexChanged += new System.EventHandler(this.cbListFile_SelectedIndexChanged);
            // 
            // btnNewFile
            // 
            this.btnNewFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewFile.Location = new System.Drawing.Point(870, 10);
            this.btnNewFile.Name = "btnNewFile";
            this.btnNewFile.Size = new System.Drawing.Size(128, 37);
            this.btnNewFile.TabIndex = 36;
            this.btnNewFile.Text = "Tạo mới đài xổ";
            this.btnNewFile.UseVisualStyleBackColor = true;
            this.btnNewFile.Click += new System.EventHandler(this.btnNewFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "CHỌN ĐÀI XỔ:";
            // 
            // lsv
            // 
            this.lsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsv.FormattingEnabled = true;
            this.lsv.ItemHeight = 20;
            this.lsv.Location = new System.Drawing.Point(508, 6);
            this.lsv.Name = "lsv";
            this.lsv.Size = new System.Drawing.Size(99, 64);
            this.lsv.TabIndex = 39;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 775);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlChart.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbxInput.ResumeLayout(false);
            this.gbxInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtResult0;
        private System.Windows.Forms.TextBox txtResult1;
        private System.Windows.Forms.TextBox txtResult2;
        private System.Windows.Forms.TextBox txtResult32;
        private System.Windows.Forms.TextBox txtResult31;
        private System.Windows.Forms.TextBox txtResult47;
        private System.Windows.Forms.TextBox txtResult46;
        private System.Windows.Forms.TextBox txtResult45;
        private System.Windows.Forms.TextBox txtResult44;
        private System.Windows.Forms.TextBox txtResult43;
        private System.Windows.Forms.TextBox txtResult42;
        private System.Windows.Forms.TextBox txtResult41;
        private System.Windows.Forms.TextBox txtResult5;
        private System.Windows.Forms.TextBox txtResult63;
        private System.Windows.Forms.TextBox txtResult62;
        private System.Windows.Forms.TextBox txtResult61;
        private System.Windows.Forms.TextBox txtResult7;
        private System.Windows.Forms.TextBox txtResult8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox gbxInput;
        private System.Windows.Forms.Button btnNewData;
        private System.Windows.Forms.TextBox txt0;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt32;
        private System.Windows.Forms.TextBox txt31;
        private System.Windows.Forms.TextBox txt47;
        private System.Windows.Forms.TextBox txt46;
        private System.Windows.Forms.TextBox txt45;
        private System.Windows.Forms.TextBox txt44;
        private System.Windows.Forms.TextBox txt43;
        private System.Windows.Forms.TextBox txt42;
        private System.Windows.Forms.TextBox txt41;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txt63;
        private System.Windows.Forms.TextBox txt62;
        private System.Windows.Forms.TextBox txt61;
        private System.Windows.Forms.TextBox txt7;
        private System.Windows.Forms.TextBox txt8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbListFile;
        private System.Windows.Forms.Button btnNewFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewFileName;
        private System.Windows.Forms.Panel pnlChart;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private LiveCharts.WinForms.PieChart pieChart1;
        private System.Windows.Forms.ComboBox cbxPrize;
        private System.Windows.Forms.ListBox lsv;
    }
}

