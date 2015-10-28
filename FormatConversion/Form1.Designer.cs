namespace FormatConversion
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.radioButtonBIP = new System.Windows.Forms.RadioButton();
            this.radioButtonBIL = new System.Windows.Forms.RadioButton();
            this.radioButtonBSQ = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.textBoxSaveAs = new System.Windows.Forms.TextBox();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.buttonChart = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(619, 186);
            this.splitContainer1.SplitterDistance = 232;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonExit);
            this.groupBox1.Controls.Add(this.buttonStart);
            this.groupBox1.Controls.Add(this.radioButtonBIP);
            this.groupBox1.Controls.Add(this.radioButtonBIL);
            this.groupBox1.Controls.Add(this.radioButtonBSQ);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.buttonChoose);
            this.groupBox1.Controls.Add(this.textBoxSaveAs);
            this.groupBox1.Controls.Add(this.textBoxFileName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据转换";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(155, 123);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 19;
            this.buttonExit.Text = "退出";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(10, 123);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 18;
            this.buttonStart.Text = "开始";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // radioButtonBIP
            // 
            this.radioButtonBIP.AutoSize = true;
            this.radioButtonBIP.Location = new System.Drawing.Point(120, 64);
            this.radioButtonBIP.Name = "radioButtonBIP";
            this.radioButtonBIP.Size = new System.Drawing.Size(41, 16);
            this.radioButtonBIP.TabIndex = 17;
            this.radioButtonBIP.TabStop = true;
            this.radioButtonBIP.Text = "BIP";
            this.radioButtonBIP.UseVisualStyleBackColor = true;
            // 
            // radioButtonBIL
            // 
            this.radioButtonBIL.AutoSize = true;
            this.radioButtonBIL.Location = new System.Drawing.Point(61, 64);
            this.radioButtonBIL.Name = "radioButtonBIL";
            this.radioButtonBIL.Size = new System.Drawing.Size(41, 16);
            this.radioButtonBIL.TabIndex = 16;
            this.radioButtonBIL.TabStop = true;
            this.radioButtonBIL.Text = "BIL";
            this.radioButtonBIL.UseVisualStyleBackColor = true;
            // 
            // radioButtonBSQ
            // 
            this.radioButtonBSQ.AutoSize = true;
            this.radioButtonBSQ.Location = new System.Drawing.Point(14, 64);
            this.radioButtonBSQ.Name = "radioButtonBSQ";
            this.radioButtonBSQ.Size = new System.Drawing.Size(41, 16);
            this.radioButtonBSQ.TabIndex = 15;
            this.radioButtonBSQ.TabStop = true;
            this.radioButtonBSQ.Text = "BSQ";
            this.radioButtonBSQ.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(10, 152);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(220, 23);
            this.progressBar1.TabIndex = 14;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(155, 86);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "保存路径";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonChoose
            // 
            this.buttonChoose.Location = new System.Drawing.Point(155, 23);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(75, 23);
            this.buttonChoose.TabIndex = 12;
            this.buttonChoose.Text = "选择文件";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // textBoxSaveAs
            // 
            this.textBoxSaveAs.Location = new System.Drawing.Point(10, 88);
            this.textBoxSaveAs.Name = "textBoxSaveAs";
            this.textBoxSaveAs.Size = new System.Drawing.Size(135, 21);
            this.textBoxSaveAs.TabIndex = 11;
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(10, 25);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(139, 21);
            this.textBoxFileName.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.splitContainer2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 186);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "直方图统计";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 17);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.buttonChart);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.chart1);
            this.splitContainer2.Size = new System.Drawing.Size(377, 166);
            this.splitContainer2.SplitterDistance = 86;
            this.splitContainer2.TabIndex = 0;
            // 
            // buttonChart
            // 
            this.buttonChart.Location = new System.Drawing.Point(3, 6);
            this.buttonChart.Name = "buttonChart";
            this.buttonChart.Size = new System.Drawing.Size(75, 23);
            this.buttonChart.TabIndex = 0;
            this.buttonChart.Text = "生成直方图";
            this.buttonChart.UseVisualStyleBackColor = true;
            this.buttonChart.Click += new System.EventHandler(this.buttonChart_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(287, 166);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 186);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "栅格格式转换器";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.RadioButton radioButtonBIP;
        private System.Windows.Forms.RadioButton radioButtonBIL;
        private System.Windows.Forms.RadioButton radioButtonBSQ;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.TextBox textBoxSaveAs;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button buttonChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;

    }
}

