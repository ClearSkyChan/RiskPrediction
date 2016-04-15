namespace RiskPrediction
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataImport = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.inputfileNameLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.outputCountLbl = new System.Windows.Forms.Label();
            this.inputCountLbl = new System.Windows.Forms.Label();
            this.outputLengthLbl = new System.Windows.Forms.Label();
            this.inputLengthLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inputFileImport = new System.Windows.Forms.Button();
            this.outputFileImport = new System.Windows.Forms.Button();
            this.outputfileNameLbl = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cacuInputCountLbl = new System.Windows.Forms.Label();
            this.cacuInputLengthLbl = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cacuInputImportBtn = new System.Windows.Forms.Button();
            this.cacufileNameLbl = new System.Windows.Forms.Label();
            this.cacuBtn = new System.Windows.Forms.Button();
            this.learnBtn = new System.Windows.Forms.Button();
            this.maxErrorTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.iterationCountTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.exportNetBtn = new System.Windows.Forms.Button();
            this.importNetBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.NeuroCountTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataImport
            // 
            this.dataImport.Location = new System.Drawing.Point(471, 435);
            this.dataImport.Name = "dataImport";
            this.dataImport.Size = new System.Drawing.Size(75, 23);
            this.dataImport.TabIndex = 0;
            this.dataImport.Text = "导入";
            this.dataImport.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Excel文档|*.csv";
            // 
            // inputfileNameLbl
            // 
            this.inputfileNameLbl.AutoSize = true;
            this.inputfileNameLbl.Location = new System.Drawing.Point(15, 27);
            this.inputfileNameLbl.Name = "inputfileNameLbl";
            this.inputfileNameLbl.Size = new System.Drawing.Size(95, 12);
            this.inputfileNameLbl.TabIndex = 1;
            this.inputfileNameLbl.Text = "选择输入文件...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.outputCountLbl);
            this.groupBox1.Controls.Add(this.inputCountLbl);
            this.groupBox1.Controls.Add(this.outputLengthLbl);
            this.groupBox1.Controls.Add(this.inputLengthLbl);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.inputFileImport);
            this.groupBox1.Controls.Add(this.outputFileImport);
            this.groupBox1.Controls.Add(this.outputfileNameLbl);
            this.groupBox1.Controls.Add(this.inputfileNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 158);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "学习样本";
            // 
            // outputCountLbl
            // 
            this.outputCountLbl.AutoSize = true;
            this.outputCountLbl.Location = new System.Drawing.Point(190, 123);
            this.outputCountLbl.Name = "outputCountLbl";
            this.outputCountLbl.Size = new System.Drawing.Size(11, 12);
            this.outputCountLbl.TabIndex = 17;
            this.outputCountLbl.Text = "0";
            // 
            // inputCountLbl
            // 
            this.inputCountLbl.AutoSize = true;
            this.inputCountLbl.Location = new System.Drawing.Point(190, 100);
            this.inputCountLbl.Name = "inputCountLbl";
            this.inputCountLbl.Size = new System.Drawing.Size(11, 12);
            this.inputCountLbl.TabIndex = 16;
            this.inputCountLbl.Text = "0";
            // 
            // outputLengthLbl
            // 
            this.outputLengthLbl.AutoSize = true;
            this.outputLengthLbl.Location = new System.Drawing.Point(81, 123);
            this.outputLengthLbl.Name = "outputLengthLbl";
            this.outputLengthLbl.Size = new System.Drawing.Size(11, 12);
            this.outputLengthLbl.TabIndex = 15;
            this.outputLengthLbl.Text = "0";
            // 
            // inputLengthLbl
            // 
            this.inputLengthLbl.AutoSize = true;
            this.inputLengthLbl.Location = new System.Drawing.Point(81, 100);
            this.inputLengthLbl.Name = "inputLengthLbl";
            this.inputLengthLbl.Size = new System.Drawing.Size(11, 12);
            this.inputLengthLbl.TabIndex = 14;
            this.inputLengthLbl.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(117, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "输入样本数";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "输出样本数";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "输出长度";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "输入长度";
            // 
            // inputFileImport
            // 
            this.inputFileImport.Location = new System.Drawing.Point(119, 20);
            this.inputFileImport.Name = "inputFileImport";
            this.inputFileImport.Size = new System.Drawing.Size(75, 23);
            this.inputFileImport.TabIndex = 9;
            this.inputFileImport.Text = "导入";
            this.inputFileImport.UseVisualStyleBackColor = true;
            this.inputFileImport.Click += new System.EventHandler(this.inputFileImport_Click);
            // 
            // outputFileImport
            // 
            this.outputFileImport.Location = new System.Drawing.Point(119, 60);
            this.outputFileImport.Name = "outputFileImport";
            this.outputFileImport.Size = new System.Drawing.Size(75, 23);
            this.outputFileImport.TabIndex = 3;
            this.outputFileImport.Text = "导入";
            this.outputFileImport.UseVisualStyleBackColor = true;
            this.outputFileImport.Click += new System.EventHandler(this.outputFileImport_Click);
            // 
            // outputfileNameLbl
            // 
            this.outputfileNameLbl.AutoSize = true;
            this.outputfileNameLbl.Location = new System.Drawing.Point(15, 65);
            this.outputfileNameLbl.Name = "outputfileNameLbl";
            this.outputfileNameLbl.Size = new System.Drawing.Size(95, 12);
            this.outputfileNameLbl.TabIndex = 2;
            this.outputfileNameLbl.Text = "选择输出文件...";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cacuInputCountLbl);
            this.groupBox3.Controls.Add(this.cacuInputLengthLbl);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.cacuInputImportBtn);
            this.groupBox3.Controls.Add(this.cacufileNameLbl);
            this.groupBox3.Controls.Add(this.cacuBtn);
            this.groupBox3.Location = new System.Drawing.Point(245, 176);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(220, 135);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "计算";
            // 
            // cacuInputCountLbl
            // 
            this.cacuInputCountLbl.AutoSize = true;
            this.cacuInputCountLbl.Location = new System.Drawing.Point(191, 62);
            this.cacuInputCountLbl.Name = "cacuInputCountLbl";
            this.cacuInputCountLbl.Size = new System.Drawing.Size(11, 12);
            this.cacuInputCountLbl.TabIndex = 20;
            this.cacuInputCountLbl.Text = "0";
            // 
            // cacuInputLengthLbl
            // 
            this.cacuInputLengthLbl.AutoSize = true;
            this.cacuInputLengthLbl.Location = new System.Drawing.Point(82, 62);
            this.cacuInputLengthLbl.Name = "cacuInputLengthLbl";
            this.cacuInputLengthLbl.Size = new System.Drawing.Size(11, 12);
            this.cacuInputLengthLbl.TabIndex = 19;
            this.cacuInputLengthLbl.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(120, 61);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 18;
            this.label15.Text = "输入样本数";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 17;
            this.label16.Text = "输入长度";
            // 
            // cacuInputImportBtn
            // 
            this.cacuInputImportBtn.Location = new System.Drawing.Point(122, 20);
            this.cacuInputImportBtn.Name = "cacuInputImportBtn";
            this.cacuInputImportBtn.Size = new System.Drawing.Size(75, 23);
            this.cacuInputImportBtn.TabIndex = 5;
            this.cacuInputImportBtn.Text = "导入";
            this.cacuInputImportBtn.UseVisualStyleBackColor = true;
            this.cacuInputImportBtn.Click += new System.EventHandler(this.cacuInputImportBtn_Click);
            // 
            // cacufileNameLbl
            // 
            this.cacufileNameLbl.AutoSize = true;
            this.cacufileNameLbl.Location = new System.Drawing.Point(21, 26);
            this.cacufileNameLbl.Name = "cacufileNameLbl";
            this.cacufileNameLbl.Size = new System.Drawing.Size(95, 12);
            this.cacufileNameLbl.TabIndex = 5;
            this.cacufileNameLbl.Text = "选择输入文件...";
            // 
            // cacuBtn
            // 
            this.cacuBtn.Location = new System.Drawing.Point(57, 87);
            this.cacuBtn.Name = "cacuBtn";
            this.cacuBtn.Size = new System.Drawing.Size(75, 23);
            this.cacuBtn.TabIndex = 0;
            this.cacuBtn.Text = "计算";
            this.cacuBtn.UseVisualStyleBackColor = true;
            this.cacuBtn.Click += new System.EventHandler(this.cacuBtn_Click);
            // 
            // learnBtn
            // 
            this.learnBtn.Location = new System.Drawing.Point(69, 123);
            this.learnBtn.Name = "learnBtn";
            this.learnBtn.Size = new System.Drawing.Size(75, 23);
            this.learnBtn.TabIndex = 4;
            this.learnBtn.Text = "开始学习";
            this.learnBtn.UseVisualStyleBackColor = true;
            this.learnBtn.Click += new System.EventHandler(this.learnBtn_Click);
            // 
            // maxErrorTb
            // 
            this.maxErrorTb.Location = new System.Drawing.Point(122, 20);
            this.maxErrorTb.Name = "maxErrorTb";
            this.maxErrorTb.Size = new System.Drawing.Size(75, 21);
            this.maxErrorTb.TabIndex = 5;
            this.maxErrorTb.Text = "0.01";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "可接受总误差";
            // 
            // iterationCountTb
            // 
            this.iterationCountTb.Location = new System.Drawing.Point(122, 56);
            this.iterationCountTb.Name = "iterationCountTb";
            this.iterationCountTb.Size = new System.Drawing.Size(75, 21);
            this.iterationCountTb.TabIndex = 7;
            this.iterationCountTb.Text = "50000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "最大迭代次数";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.exportNetBtn);
            this.groupBox2.Controls.Add(this.importNetBtn);
            this.groupBox2.Location = new System.Drawing.Point(12, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 135);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "神经网络";
            // 
            // exportNetBtn
            // 
            this.exportNetBtn.Location = new System.Drawing.Point(53, 84);
            this.exportNetBtn.Name = "exportNetBtn";
            this.exportNetBtn.Size = new System.Drawing.Size(75, 23);
            this.exportNetBtn.TabIndex = 6;
            this.exportNetBtn.Text = "导出";
            this.exportNetBtn.UseVisualStyleBackColor = true;
            this.exportNetBtn.Click += new System.EventHandler(this.exportNetBtn_Click);
            // 
            // importNetBtn
            // 
            this.importNetBtn.Location = new System.Drawing.Point(53, 38);
            this.importNetBtn.Name = "importNetBtn";
            this.importNetBtn.Size = new System.Drawing.Size(75, 23);
            this.importNetBtn.TabIndex = 5;
            this.importNetBtn.Text = "导入";
            this.importNetBtn.UseVisualStyleBackColor = true;
            this.importNetBtn.Click += new System.EventHandler(this.importNetBtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.NeuroCountTb);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.maxErrorTb);
            this.groupBox4.Controls.Add(this.iterationCountTb);
            this.groupBox4.Controls.Add(this.learnBtn);
            this.groupBox4.Location = new System.Drawing.Point(245, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(220, 158);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "学习参数";
            // 
            // NeuroCountTb
            // 
            this.NeuroCountTb.Location = new System.Drawing.Point(122, 91);
            this.NeuroCountTb.Name = "NeuroCountTb";
            this.NeuroCountTb.Size = new System.Drawing.Size(75, 21);
            this.NeuroCountTb.TabIndex = 10;
            this.NeuroCountTb.Text = "8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 12);
            this.label9.TabIndex = 9;
            this.label9.Text = "中间层神经元数";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Excel文档|*.csv";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 335);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataImport);
            this.Name = "MainForm";
            this.Text = "BP神经网络Demo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dataImport;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label inputfileNameLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label outputfileNameLbl;
        private System.Windows.Forms.Button outputFileImport;
        private System.Windows.Forms.Button learnBtn;
        private System.Windows.Forms.Button cacuBtn;
        private System.Windows.Forms.Button cacuInputImportBtn;
        private System.Windows.Forms.Label cacufileNameLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox maxErrorTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox iterationCountTb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button exportNetBtn;
        private System.Windows.Forms.Button importNetBtn;
        private System.Windows.Forms.Button inputFileImport;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label outputCountLbl;
        private System.Windows.Forms.Label inputCountLbl;
        private System.Windows.Forms.Label outputLengthLbl;
        private System.Windows.Forms.Label inputLengthLbl;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label cacuInputCountLbl;
        private System.Windows.Forms.Label cacuInputLengthLbl;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NeuroCountTb;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

