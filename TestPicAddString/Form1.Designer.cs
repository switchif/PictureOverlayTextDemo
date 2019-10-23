namespace TestPicAddString
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
            this.btnAddString = new System.Windows.Forms.Button();
            this.btnShowOld = new System.Windows.Forms.Button();
            this.rtbxStringBuf = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxY = new System.Windows.Forms.TextBox();
            this.tbxX = new System.Windows.Forms.TextBox();
            this.pbxShowPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxShowPic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddString
            // 
            this.btnAddString.Location = new System.Drawing.Point(164, 61);
            this.btnAddString.Name = "btnAddString";
            this.btnAddString.Size = new System.Drawing.Size(75, 23);
            this.btnAddString.TabIndex = 1;
            this.btnAddString.Text = "AddString";
            this.btnAddString.UseVisualStyleBackColor = true;
            this.btnAddString.Click += new System.EventHandler(this.btnAddString_Click);
            // 
            // btnShowOld
            // 
            this.btnShowOld.Location = new System.Drawing.Point(69, 61);
            this.btnShowOld.Name = "btnShowOld";
            this.btnShowOld.Size = new System.Drawing.Size(75, 23);
            this.btnShowOld.TabIndex = 2;
            this.btnShowOld.Text = "ShowOld";
            this.btnShowOld.UseVisualStyleBackColor = true;
            this.btnShowOld.Click += new System.EventHandler(this.btnShowOld_Click);
            // 
            // rtbxStringBuf
            // 
            this.rtbxStringBuf.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtbxStringBuf.Location = new System.Drawing.Point(52, 229);
            this.rtbxStringBuf.Name = "rtbxStringBuf";
            this.rtbxStringBuf.Size = new System.Drawing.Size(228, 263);
            this.rtbxStringBuf.TabIndex = 3;
            this.rtbxStringBuf.Text = "时  间：2019-08-05 10:19:59\n站  点：三河市S213\n车  牌：豫A51258\n轴  数：6\n总  重：241526\n限  重：36000\n" +
    "超限率：0.0%\n";
            this.rtbxStringBuf.TextChanged += new System.EventHandler(this.rtbxStringBuf_TextChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.tbxSize);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.tbxY);
            this.splitContainer1.Panel1.Controls.Add(this.tbxX);
            this.splitContainer1.Panel1.Controls.Add(this.btnShowOld);
            this.splitContainer1.Panel1.Controls.Add(this.rtbxStringBuf);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddString);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pbxShowPic);
            this.splitContainer1.Size = new System.Drawing.Size(883, 589);
            this.splitContainer1.SplitterDistance = 294;
            this.splitContainer1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "SizePerWidth:";
            // 
            // tbxSize
            // 
            this.tbxSize.Location = new System.Drawing.Point(108, 164);
            this.tbxSize.Name = "tbxSize";
            this.tbxSize.Size = new System.Drawing.Size(100, 21);
            this.tbxSize.TabIndex = 8;
            this.tbxSize.Text = "0.5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "X:";
            // 
            // tbxY
            // 
            this.tbxY.Location = new System.Drawing.Point(108, 130);
            this.tbxY.Name = "tbxY";
            this.tbxY.Size = new System.Drawing.Size(100, 21);
            this.tbxY.TabIndex = 5;
            this.tbxY.Text = "800";
            // 
            // tbxX
            // 
            this.tbxX.Location = new System.Drawing.Point(108, 103);
            this.tbxX.Name = "tbxX";
            this.tbxX.Size = new System.Drawing.Size(100, 21);
            this.tbxX.TabIndex = 4;
            this.tbxX.Text = "800";
            // 
            // pbxShowPic
            // 
            this.pbxShowPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxShowPic.Location = new System.Drawing.Point(0, 0);
            this.pbxShowPic.Name = "pbxShowPic";
            this.pbxShowPic.Size = new System.Drawing.Size(585, 589);
            this.pbxShowPic.TabIndex = 1;
            this.pbxShowPic.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 589);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxShowPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddString;
        private System.Windows.Forms.Button btnShowOld;
        private System.Windows.Forms.RichTextBox rtbxStringBuf;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pbxShowPic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxY;
        private System.Windows.Forms.TextBox tbxX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxSize;
    }
}

