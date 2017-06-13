namespace ComplexTool
{
    partial class MainWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCvtImaginary = new System.Windows.Forms.TextBox();
            this.txtCvtReal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCvtDegree = new System.Windows.Forms.TextBox();
            this.txtCvtModule = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCalImaginary2 = new System.Windows.Forms.TextBox();
            this.txtCalReal2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCalImaginary1 = new System.Windows.Forms.TextBox();
            this.txtCalReal1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtCalRes = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnToCvt = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.rbDivide = new System.Windows.Forms.RadioButton();
            this.rbMultiply = new System.Windows.Forms.RadioButton();
            this.rbMinus = new System.Windows.Forms.RadioButton();
            this.rbPlus = new System.Windows.Forms.RadioButton();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnToCal2 = new System.Windows.Forms.Button();
            this.btnToCal1 = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCvtImaginary);
            this.groupBox1.Controls.Add(this.txtCvtReal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 80);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Algebra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(456, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "j";
            // 
            // txtCvtImaginary
            // 
            this.txtCvtImaginary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCvtImaginary.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCvtImaginary.Location = new System.Drawing.Point(250, 20);
            this.txtCvtImaginary.Name = "txtCvtImaginary";
            this.txtCvtImaginary.Size = new System.Drawing.Size(200, 39);
            this.txtCvtImaginary.TabIndex = 5;
            this.txtCvtImaginary.Text = "0";
            this.txtCvtImaginary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCvtImaginary.TextChanged += new System.EventHandler(this.AlgebraChanged);
            // 
            // txtCvtReal
            // 
            this.txtCvtReal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCvtReal.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCvtReal.Location = new System.Drawing.Point(8, 20);
            this.txtCvtReal.Name = "txtCvtReal";
            this.txtCvtReal.Size = new System.Drawing.Size(200, 39);
            this.txtCvtReal.TabIndex = 4;
            this.txtCvtReal.Text = "0";
            this.txtCvtReal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCvtReal.TextChanged += new System.EventHandler(this.AlgebraChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "+";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCvtDegree);
            this.groupBox2.Controls.Add(this.txtCvtModule);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(6, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 80);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Polar Coordinate";
            // 
            // txtCvtDegree
            // 
            this.txtCvtDegree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCvtDegree.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCvtDegree.Location = new System.Drawing.Point(248, 20);
            this.txtCvtDegree.Name = "txtCvtDegree";
            this.txtCvtDegree.Size = new System.Drawing.Size(200, 39);
            this.txtCvtDegree.TabIndex = 7;
            this.txtCvtDegree.Text = "0";
            this.txtCvtDegree.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCvtDegree.TextChanged += new System.EventHandler(this.PolarChanged);
            // 
            // txtCvtModule
            // 
            this.txtCvtModule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCvtModule.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCvtModule.Location = new System.Drawing.Point(8, 20);
            this.txtCvtModule.Name = "txtCvtModule";
            this.txtCvtModule.Size = new System.Drawing.Size(200, 39);
            this.txtCvtModule.TabIndex = 7;
            this.txtCvtModule.Text = "0";
            this.txtCvtModule.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCvtModule.TextChanged += new System.EventHandler(this.PolarChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(445, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 32);
            this.label6.TabIndex = 7;
            this.label6.Text = "°";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(214, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "∠";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtCalImaginary2);
            this.groupBox3.Controls.Add(this.txtCalReal2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(5, 248);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(490, 71);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Complex2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(456, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "j";
            // 
            // txtCalImaginary2
            // 
            this.txtCalImaginary2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCalImaginary2.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalImaginary2.Location = new System.Drawing.Point(250, 20);
            this.txtCalImaginary2.Name = "txtCalImaginary2";
            this.txtCalImaginary2.Size = new System.Drawing.Size(200, 39);
            this.txtCalImaginary2.TabIndex = 5;
            this.txtCalImaginary2.Text = "0";
            this.txtCalImaginary2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCalImaginary2.TextChanged += new System.EventHandler(this.Calculate);
            // 
            // txtCalReal2
            // 
            this.txtCalReal2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCalReal2.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalReal2.Location = new System.Drawing.Point(8, 20);
            this.txtCalReal2.Name = "txtCalReal2";
            this.txtCalReal2.Size = new System.Drawing.Size(200, 39);
            this.txtCalReal2.TabIndex = 4;
            this.txtCalReal2.Text = "0";
            this.txtCalReal2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCalReal2.TextChanged += new System.EventHandler(this.Calculate);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(214, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 32);
            this.label5.TabIndex = 2;
            this.label5.Text = "+";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txtCalImaginary1);
            this.groupBox5.Controls.Add(this.txtCalReal1);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(5, 94);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(490, 71);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Complex1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(456, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "j";
            // 
            // txtCalImaginary1
            // 
            this.txtCalImaginary1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCalImaginary1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalImaginary1.Location = new System.Drawing.Point(250, 20);
            this.txtCalImaginary1.Name = "txtCalImaginary1";
            this.txtCalImaginary1.Size = new System.Drawing.Size(200, 39);
            this.txtCalImaginary1.TabIndex = 5;
            this.txtCalImaginary1.Text = "0";
            this.txtCalImaginary1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCalImaginary1.TextChanged += new System.EventHandler(this.Calculate);
            // 
            // txtCalReal1
            // 
            this.txtCalReal1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCalReal1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalReal1.Location = new System.Drawing.Point(8, 20);
            this.txtCalReal1.Name = "txtCalReal1";
            this.txtCalReal1.Size = new System.Drawing.Size(200, 39);
            this.txtCalReal1.TabIndex = 4;
            this.txtCalReal1.Text = "0";
            this.txtCalReal1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCalReal1.TextChanged += new System.EventHandler(this.Calculate);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(214, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 32);
            this.label8.TabIndex = 2;
            this.label8.Text = "+";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtCalRes);
            this.groupBox4.Location = new System.Drawing.Point(6, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(490, 68);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Result";
            // 
            // txtCalRes
            // 
            this.txtCalRes.BackColor = System.Drawing.Color.White;
            this.txtCalRes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCalRes.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalRes.Location = new System.Drawing.Point(7, 20);
            this.txtCalRes.Name = "txtCalRes";
            this.txtCalRes.ReadOnly = true;
            this.txtCalRes.Size = new System.Drawing.Size(477, 39);
            this.txtCalRes.TabIndex = 0;
            this.txtCalRes.Text = "0";
            this.txtCalRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnToCvt);
            this.groupBox6.Controls.Add(this.groupBox3);
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Controls.Add(this.groupBox4);
            this.groupBox6.Controls.Add(this.groupBox5);
            this.groupBox6.Location = new System.Drawing.Point(12, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(591, 325);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Calculator";
            // 
            // btnToCvt
            // 
            this.btnToCvt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToCvt.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToCvt.Location = new System.Drawing.Point(502, 20);
            this.btnToCvt.Name = "btnToCvt";
            this.btnToCvt.Size = new System.Drawing.Size(83, 299);
            this.btnToCvt.TabIndex = 18;
            this.btnToCvt.Text = "↓";
            this.btnToCvt.UseVisualStyleBackColor = true;
            this.btnToCvt.Click += new System.EventHandler(this.ToCvt);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.rbDivide);
            this.groupBox7.Controls.Add(this.rbMultiply);
            this.groupBox7.Controls.Add(this.rbMinus);
            this.groupBox7.Controls.Add(this.rbPlus);
            this.groupBox7.Location = new System.Drawing.Point(6, 171);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(490, 71);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Operator";
            // 
            // rbDivide
            // 
            this.rbDivide.AutoSize = true;
            this.rbDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbDivide.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDivide.Location = new System.Drawing.Point(427, 20);
            this.rbDivide.Name = "rbDivide";
            this.rbDivide.Size = new System.Drawing.Size(47, 36);
            this.rbDivide.TabIndex = 3;
            this.rbDivide.Text = "/";
            this.rbDivide.UseVisualStyleBackColor = true;
            this.rbDivide.CheckedChanged += new System.EventHandler(this.Calculate);
            // 
            // rbMultiply
            // 
            this.rbMultiply.AutoSize = true;
            this.rbMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbMultiply.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMultiply.Location = new System.Drawing.Point(295, 20);
            this.rbMultiply.Name = "rbMultiply";
            this.rbMultiply.Size = new System.Drawing.Size(47, 36);
            this.rbMultiply.TabIndex = 2;
            this.rbMultiply.Text = "*";
            this.rbMultiply.UseVisualStyleBackColor = true;
            this.rbMultiply.CheckedChanged += new System.EventHandler(this.Calculate);
            // 
            // rbMinus
            // 
            this.rbMinus.AutoSize = true;
            this.rbMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbMinus.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMinus.Location = new System.Drawing.Point(159, 20);
            this.rbMinus.Name = "rbMinus";
            this.rbMinus.Size = new System.Drawing.Size(47, 36);
            this.rbMinus.TabIndex = 1;
            this.rbMinus.Text = "-";
            this.rbMinus.UseVisualStyleBackColor = true;
            this.rbMinus.CheckedChanged += new System.EventHandler(this.Calculate);
            // 
            // rbPlus
            // 
            this.rbPlus.AutoSize = true;
            this.rbPlus.Checked = true;
            this.rbPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbPlus.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPlus.Location = new System.Drawing.Point(7, 20);
            this.rbPlus.Name = "rbPlus";
            this.rbPlus.Size = new System.Drawing.Size(47, 36);
            this.rbPlus.TabIndex = 0;
            this.rbPlus.TabStop = true;
            this.rbPlus.Text = "+";
            this.rbPlus.UseVisualStyleBackColor = true;
            this.rbPlus.CheckedChanged += new System.EventHandler(this.Calculate);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btnToCal2);
            this.groupBox8.Controls.Add(this.btnToCal1);
            this.groupBox8.Controls.Add(this.groupBox1);
            this.groupBox8.Controls.Add(this.groupBox2);
            this.groupBox8.Location = new System.Drawing.Point(12, 343);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(591, 193);
            this.groupBox8.TabIndex = 20;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Converter";
            // 
            // btnToCal2
            // 
            this.btnToCal2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToCal2.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToCal2.Location = new System.Drawing.Point(502, 106);
            this.btnToCal2.Name = "btnToCal2";
            this.btnToCal2.Size = new System.Drawing.Size(83, 80);
            this.btnToCal2.TabIndex = 20;
            this.btnToCal2.Text = "↑";
            this.btnToCal2.UseVisualStyleBackColor = true;
            this.btnToCal2.Click += new System.EventHandler(this.ToCal2);
            // 
            // btnToCal1
            // 
            this.btnToCal1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToCal1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToCal1.Location = new System.Drawing.Point(502, 20);
            this.btnToCal1.Name = "btnToCal1";
            this.btnToCal1.Size = new System.Drawing.Size(83, 80);
            this.btnToCal1.TabIndex = 19;
            this.btnToCal1.Text = "↑";
            this.btnToCal1.UseVisualStyleBackColor = true;
            this.btnToCal1.Click += new System.EventHandler(this.ToCal1);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txtDecimal);
            this.groupBox9.Controls.Add(this.label9);
            this.groupBox9.Location = new System.Drawing.Point(12, 542);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(591, 69);
            this.groupBox9.TabIndex = 21;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Option";
            // 
            // txtDecimal
            // 
            this.txtDecimal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDecimal.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecimal.Location = new System.Drawing.Point(256, 20);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(79, 39);
            this.txtDecimal.TabIndex = 7;
            this.txtDecimal.Text = "5";
            this.txtDecimal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDecimal.TextChanged += new System.EventHandler(this.DecimalPlacesChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(240, 32);
            this.label9.TabIndex = 0;
            this.label9.Text = "Decimal Places:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(615, 622);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "ComplexTool";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCvtImaginary;
        private System.Windows.Forms.TextBox txtCvtReal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCvtDegree;
        private System.Windows.Forms.TextBox txtCvtModule;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCalImaginary2;
        private System.Windows.Forms.TextBox txtCalReal2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCalImaginary1;
        private System.Windows.Forms.TextBox txtCalReal1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtCalRes;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton rbDivide;
        private System.Windows.Forms.RadioButton rbMultiply;
        private System.Windows.Forms.RadioButton rbMinus;
        private System.Windows.Forms.RadioButton rbPlus;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btnToCvt;
        private System.Windows.Forms.Button btnToCal1;
        private System.Windows.Forms.Button btnToCal2;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.Label label9;
    }
}

