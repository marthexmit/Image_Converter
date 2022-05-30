namespace furi_imageProcessing
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnMultA = new System.Windows.Forms.Button();
            this.txtDivA = new System.Windows.Forms.TextBox();
            this.bntDivA = new System.Windows.Forms.Button();
            this.txtMultA = new System.Windows.Forms.TextBox();
            this.btnBinaryA = new System.Windows.Forms.Button();
            this.btnGrayA = new System.Windows.Forms.Button();
            this.btnNotA = new System.Windows.Forms.Button();
            this.pbA = new System.Windows.Forms.PictureBox();
            this.btnA = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnDivB = new System.Windows.Forms.Button();
            this.btnGrayB = new System.Windows.Forms.Button();
            this.txtMultB = new System.Windows.Forms.TextBox();
            this.btnBinaryB = new System.Windows.Forms.Button();
            this.btnMultB = new System.Windows.Forms.Button();
            this.txtDivB = new System.Windows.Forms.TextBox();
            this.btnNotB = new System.Windows.Forms.Button();
            this.pbB = new System.Windows.Forms.PictureBox();
            this.btnB = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.pbResult = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnNOT = new System.Windows.Forms.Button();
            this.btnOR = new System.Windows.Forms.Button();
            this.btnXOR = new System.Windows.Forms.Button();
            this.btnAND = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtBld = new System.Windows.Forms.TextBox();
            this.btnBld = new System.Windows.Forms.Button();
            this.btnAvg = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbA)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbB)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox8);
            this.groupBox1.Controls.Add(this.pbA);
            this.groupBox1.Controls.Add(this.btnA);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(225, 412);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image A";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btnMultA);
            this.groupBox8.Controls.Add(this.txtDivA);
            this.groupBox8.Controls.Add(this.bntDivA);
            this.groupBox8.Controls.Add(this.txtMultA);
            this.groupBox8.Controls.Add(this.btnBinaryA);
            this.groupBox8.Controls.Add(this.btnGrayA);
            this.groupBox8.Controls.Add(this.btnNotA);
            this.groupBox8.Location = new System.Drawing.Point(15, 239);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(195, 168);
            this.groupBox8.TabIndex = 6;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Control_A";
            // 
            // btnMultA
            // 
            this.btnMultA.Location = new System.Drawing.Point(6, 105);
            this.btnMultA.Name = "btnMultA";
            this.btnMultA.Size = new System.Drawing.Size(85, 23);
            this.btnMultA.TabIndex = 10;
            this.btnMultA.Text = "Multiplication";
            this.btnMultA.UseVisualStyleBackColor = true;
            this.btnMultA.Click += new System.EventHandler(this.btnMultA_Click);
            // 
            // txtDivA
            // 
            this.txtDivA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDivA.Location = new System.Drawing.Point(97, 137);
            this.txtDivA.Name = "txtDivA";
            this.txtDivA.Size = new System.Drawing.Size(48, 20);
            this.txtDivA.TabIndex = 7;
            this.txtDivA.TextChanged += new System.EventHandler(this.txtDivA_TextChanged);
            // 
            // bntDivA
            // 
            this.bntDivA.Location = new System.Drawing.Point(6, 134);
            this.bntDivA.Name = "bntDivA";
            this.bntDivA.Size = new System.Drawing.Size(85, 23);
            this.bntDivA.TabIndex = 4;
            this.bntDivA.Text = "Division";
            this.bntDivA.UseVisualStyleBackColor = true;
            this.bntDivA.Click += new System.EventHandler(this.bntDivA_Click);
            // 
            // txtMultA
            // 
            this.txtMultA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMultA.Location = new System.Drawing.Point(97, 108);
            this.txtMultA.Name = "txtMultA";
            this.txtMultA.Size = new System.Drawing.Size(48, 20);
            this.txtMultA.TabIndex = 11;
            // 
            // btnBinaryA
            // 
            this.btnBinaryA.Location = new System.Drawing.Point(6, 47);
            this.btnBinaryA.Name = "btnBinaryA";
            this.btnBinaryA.Size = new System.Drawing.Size(85, 23);
            this.btnBinaryA.TabIndex = 9;
            this.btnBinaryA.Text = "Binary";
            this.btnBinaryA.UseVisualStyleBackColor = true;
            this.btnBinaryA.Click += new System.EventHandler(this.btnBinaryA_Click);
            // 
            // btnGrayA
            // 
            this.btnGrayA.Location = new System.Drawing.Point(6, 18);
            this.btnGrayA.Name = "btnGrayA";
            this.btnGrayA.Size = new System.Drawing.Size(85, 23);
            this.btnGrayA.TabIndex = 8;
            this.btnGrayA.Text = "Gray";
            this.btnGrayA.UseVisualStyleBackColor = true;
            this.btnGrayA.Click += new System.EventHandler(this.btnGrayA_Click);
            // 
            // btnNotA
            // 
            this.btnNotA.Location = new System.Drawing.Point(6, 76);
            this.btnNotA.Name = "btnNotA";
            this.btnNotA.Size = new System.Drawing.Size(85, 23);
            this.btnNotA.TabIndex = 10;
            this.btnNotA.Text = "Not";
            this.btnNotA.UseVisualStyleBackColor = true;
            this.btnNotA.Click += new System.EventHandler(this.btnNotA_Click);
            // 
            // pbA
            // 
            this.pbA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbA.Location = new System.Drawing.Point(15, 17);
            this.pbA.Margin = new System.Windows.Forms.Padding(2);
            this.pbA.Name = "pbA";
            this.pbA.Size = new System.Drawing.Size(195, 195);
            this.pbA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbA.TabIndex = 0;
            this.pbA.TabStop = false;
            this.pbA.Click += new System.EventHandler(this.pbA_Click);
            // 
            // btnA
            // 
            this.btnA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnA.Location = new System.Drawing.Point(127, 216);
            this.btnA.Margin = new System.Windows.Forms.Padding(2);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(83, 23);
            this.btnA.TabIndex = 3;
            this.btnA.Text = "Load Image A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox9);
            this.groupBox2.Controls.Add(this.pbB);
            this.groupBox2.Controls.Add(this.btnB);
            this.groupBox2.Location = new System.Drawing.Point(238, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(225, 412);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Image B";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btnDivB);
            this.groupBox9.Controls.Add(this.btnGrayB);
            this.groupBox9.Controls.Add(this.txtMultB);
            this.groupBox9.Controls.Add(this.btnBinaryB);
            this.groupBox9.Controls.Add(this.btnMultB);
            this.groupBox9.Controls.Add(this.txtDivB);
            this.groupBox9.Controls.Add(this.btnNotB);
            this.groupBox9.Location = new System.Drawing.Point(15, 239);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(195, 168);
            this.groupBox9.TabIndex = 14;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Control_B";
            // 
            // btnDivB
            // 
            this.btnDivB.Location = new System.Drawing.Point(6, 135);
            this.btnDivB.Name = "btnDivB";
            this.btnDivB.Size = new System.Drawing.Size(85, 23);
            this.btnDivB.TabIndex = 12;
            this.btnDivB.Text = "Division";
            this.btnDivB.UseVisualStyleBackColor = true;
            this.btnDivB.Click += new System.EventHandler(this.btnDivB_Click);
            // 
            // btnGrayB
            // 
            this.btnGrayB.Location = new System.Drawing.Point(6, 19);
            this.btnGrayB.Name = "btnGrayB";
            this.btnGrayB.Size = new System.Drawing.Size(85, 23);
            this.btnGrayB.TabIndex = 14;
            this.btnGrayB.Text = "Gray";
            this.btnGrayB.UseVisualStyleBackColor = true;
            this.btnGrayB.Click += new System.EventHandler(this.btnGrayB_Click);
            // 
            // txtMultB
            // 
            this.txtMultB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMultB.Location = new System.Drawing.Point(97, 109);
            this.txtMultB.Name = "txtMultB";
            this.txtMultB.Size = new System.Drawing.Size(48, 20);
            this.txtMultB.TabIndex = 18;
            this.txtMultB.TextChanged += new System.EventHandler(this.txtMultB_TextChanged);
            // 
            // btnBinaryB
            // 
            this.btnBinaryB.Location = new System.Drawing.Point(6, 48);
            this.btnBinaryB.Name = "btnBinaryB";
            this.btnBinaryB.Size = new System.Drawing.Size(85, 23);
            this.btnBinaryB.TabIndex = 15;
            this.btnBinaryB.Text = "Binary";
            this.btnBinaryB.UseVisualStyleBackColor = true;
            this.btnBinaryB.Click += new System.EventHandler(this.btnBinaryB_Click);
            // 
            // btnMultB
            // 
            this.btnMultB.Location = new System.Drawing.Point(6, 106);
            this.btnMultB.Name = "btnMultB";
            this.btnMultB.Size = new System.Drawing.Size(85, 23);
            this.btnMultB.TabIndex = 17;
            this.btnMultB.Text = "Multiplication";
            this.btnMultB.UseVisualStyleBackColor = true;
            this.btnMultB.Click += new System.EventHandler(this.btnMultB_Click);
            // 
            // txtDivB
            // 
            this.txtDivB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDivB.Location = new System.Drawing.Point(97, 138);
            this.txtDivB.Name = "txtDivB";
            this.txtDivB.Size = new System.Drawing.Size(48, 20);
            this.txtDivB.TabIndex = 13;
            this.txtDivB.TextChanged += new System.EventHandler(this.txtDivB_TextChanged);
            // 
            // btnNotB
            // 
            this.btnNotB.Location = new System.Drawing.Point(6, 77);
            this.btnNotB.Name = "btnNotB";
            this.btnNotB.Size = new System.Drawing.Size(85, 23);
            this.btnNotB.TabIndex = 16;
            this.btnNotB.Text = "Not";
            this.btnNotB.UseVisualStyleBackColor = true;
            this.btnNotB.Click += new System.EventHandler(this.btnNotB_Click);
            // 
            // pbB
            // 
            this.pbB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbB.Location = new System.Drawing.Point(15, 17);
            this.pbB.Margin = new System.Windows.Forms.Padding(2);
            this.pbB.Name = "pbB";
            this.pbB.Size = new System.Drawing.Size(195, 195);
            this.pbB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbB.TabIndex = 0;
            this.pbB.TabStop = false;
            this.pbB.Click += new System.EventHandler(this.pbB_Click);
            // 
            // btnB
            // 
            this.btnB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnB.Location = new System.Drawing.Point(127, 216);
            this.btnB.Margin = new System.Windows.Forms.Padding(2);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(83, 23);
            this.btnB.TabIndex = 4;
            this.btnB.Text = "Load Image B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnExport);
            this.groupBox3.Controls.Add(this.pbResult);
            this.groupBox3.Location = new System.Drawing.Point(9, 437);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(454, 250);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result";
            // 
            // btnExport
            // 
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.Location = new System.Drawing.Point(169, 216);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(94, 24);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Export Image";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // pbResult
            // 
            this.pbResult.Location = new System.Drawing.Point(15, 17);
            this.pbResult.Margin = new System.Windows.Forms.Padding(2);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(424, 195);
            this.pbResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResult.TabIndex = 0;
            this.pbResult.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnNOT);
            this.groupBox6.Controls.Add(this.btnOR);
            this.groupBox6.Controls.Add(this.btnXOR);
            this.groupBox6.Controls.Add(this.btnAND);
            this.groupBox6.Location = new System.Drawing.Point(7, 265);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(225, 141);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Logic Functions";
            // 
            // btnNOT
            // 
            this.btnNOT.Location = new System.Drawing.Point(129, 88);
            this.btnNOT.Name = "btnNOT";
            this.btnNOT.Size = new System.Drawing.Size(76, 23);
            this.btnNOT.TabIndex = 5;
            this.btnNOT.Text = "NOT";
            this.btnNOT.UseVisualStyleBackColor = true;
            this.btnNOT.Click += new System.EventHandler(this.btnNOT_Click);
            // 
            // btnOR
            // 
            this.btnOR.Location = new System.Drawing.Point(129, 30);
            this.btnOR.Name = "btnOR";
            this.btnOR.Size = new System.Drawing.Size(76, 23);
            this.btnOR.TabIndex = 4;
            this.btnOR.Text = "OR";
            this.btnOR.UseVisualStyleBackColor = true;
            this.btnOR.Click += new System.EventHandler(this.btnOR_Click);
            // 
            // btnXOR
            // 
            this.btnXOR.Location = new System.Drawing.Point(21, 88);
            this.btnXOR.Name = "btnXOR";
            this.btnXOR.Size = new System.Drawing.Size(76, 23);
            this.btnXOR.TabIndex = 2;
            this.btnXOR.Text = "XOR";
            this.btnXOR.UseVisualStyleBackColor = true;
            this.btnXOR.Click += new System.EventHandler(this.btnXOR_Click);
            // 
            // btnAND
            // 
            this.btnAND.Location = new System.Drawing.Point(21, 31);
            this.btnAND.Name = "btnAND";
            this.btnAND.Size = new System.Drawing.Size(76, 23);
            this.btnAND.TabIndex = 1;
            this.btnAND.Text = "AND";
            this.btnAND.UseVisualStyleBackColor = true;
            this.btnAND.Click += new System.EventHandler(this.btnAND_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtBld);
            this.groupBox5.Controls.Add(this.btnBld);
            this.groupBox5.Controls.Add(this.btnAvg);
            this.groupBox5.Controls.Add(this.btnSub);
            this.groupBox5.Controls.Add(this.btnAdd);
            this.groupBox5.Location = new System.Drawing.Point(7, 17);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(225, 220);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Arithmetic Functions";
            // 
            // txtBld
            // 
            this.txtBld.AutoCompleteCustomSource.AddRange(new string[] {
            "0",
            "0.1",
            "0.2",
            "0.3",
            "0.4",
            "0.5",
            "0.6",
            "0.7",
            "0.8",
            "0.9",
            "1"});
            this.txtBld.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtBld.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBld.Location = new System.Drawing.Point(81, 161);
            this.txtBld.Name = "txtBld";
            this.txtBld.Size = new System.Drawing.Size(55, 20);
            this.txtBld.TabIndex = 9;
            this.txtBld.Tag = "";
            this.txtBld.TextChanged += new System.EventHandler(this.txtBld_TextChanged);
            // 
            // btnBld
            // 
            this.btnBld.Location = new System.Drawing.Point(6, 158);
            this.btnBld.Name = "btnBld";
            this.btnBld.Size = new System.Drawing.Size(69, 23);
            this.btnBld.TabIndex = 6;
            this.btnBld.Text = "Blending";
            this.btnBld.UseVisualStyleBackColor = true;
            this.btnBld.Click += new System.EventHandler(this.btnBld_Click);
            // 
            // btnAvg
            // 
            this.btnAvg.Location = new System.Drawing.Point(6, 115);
            this.btnAvg.Name = "btnAvg";
            this.btnAvg.Size = new System.Drawing.Size(69, 23);
            this.btnAvg.TabIndex = 5;
            this.btnAvg.Text = "Average";
            this.btnAvg.UseVisualStyleBackColor = true;
            this.btnAvg.Click += new System.EventHandler(this.btnAvg_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(6, 73);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(69, 23);
            this.btnSub.TabIndex = 2;
            this.btnSub.Text = "Subtraction";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 35);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(69, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Addition";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Location = new System.Drawing.Point(489, 10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(238, 412);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Functions";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 698);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Image Processor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbA)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbB)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pbB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pbResult;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button bntDivA;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnNOT;
        private System.Windows.Forms.Button btnOR;
        private System.Windows.Forms.Button btnXOR;
        private System.Windows.Forms.Button btnAND;
        private System.Windows.Forms.TextBox txtDivA;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnGrayA;
        private System.Windows.Forms.TextBox txtMultA;
        private System.Windows.Forms.Button btnNotA;
        private System.Windows.Forms.Button btnMultA;
        private System.Windows.Forms.Button btnBinaryA;
        private System.Windows.Forms.TextBox txtMultB;
        private System.Windows.Forms.Button btnNotB;
        private System.Windows.Forms.Button btnMultB;
        private System.Windows.Forms.Button btnGrayB;
        private System.Windows.Forms.Button btnBinaryB;
        private System.Windows.Forms.Button btnDivB;
        private System.Windows.Forms.TextBox txtDivB;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtBld;
        private System.Windows.Forms.Button btnBld;
        private System.Windows.Forms.Button btnAvg;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

