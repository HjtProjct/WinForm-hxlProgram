namespace WinForm_hxlProgram
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSayHello = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.textUserInput = new System.Windows.Forms.TextBox();
            this.lblInfo3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.btndecrese = new System.Windows.Forms.Button();
            this.pgb = new System.Windows.Forms.ProgressBar();
            this.btnTimer = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSayHello
            // 
            this.btnSayHello.Location = new System.Drawing.Point(24, 27);
            this.btnSayHello.Name = "btnSayHello";
            this.btnSayHello.Size = new System.Drawing.Size(176, 28);
            this.btnSayHello.TabIndex = 0;
            this.btnSayHello.Text = "SayHello";
            this.btnSayHello.UseVisualStyleBackColor = true;
            this.btnSayHello.Click += new System.EventHandler(this.btnSayHello_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("思源黑体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblInfo.Location = new System.Drawing.Point(47, 62);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(140, 41);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "ABCDEFG";
            // 
            // textUserInput
            // 
            this.textUserInput.Location = new System.Drawing.Point(226, 27);
            this.textUserInput.Name = "textUserInput";
            this.textUserInput.Size = new System.Drawing.Size(206, 28);
            this.textUserInput.TabIndex = 2;
            this.textUserInput.TextChanged += new System.EventHandler(this.textUserInput_TextChanged);
            // 
            // lblInfo3
            // 
            this.lblInfo3.AutoSize = true;
            this.lblInfo3.Font = new System.Drawing.Font("思源黑体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblInfo3.Location = new System.Drawing.Point(261, 62);
            this.lblInfo3.Name = "lblInfo3";
            this.lblInfo3.Size = new System.Drawing.Size(57, 41);
            this.lblInfo3.TabIndex = 1;
            this.lblInfo3.Text = "sss";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(196, 83);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 37);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btndecrese
            // 
            this.btndecrese.Location = new System.Drawing.Point(252, 83);
            this.btndecrese.Name = "btndecrese";
            this.btndecrese.Size = new System.Drawing.Size(40, 37);
            this.btndecrese.TabIndex = 4;
            this.btndecrese.Text = "-";
            this.btndecrese.UseVisualStyleBackColor = true;
            this.btndecrese.Click += new System.EventHandler(this.btndecrese_Click);
            // 
            // pgb
            // 
            this.pgb.Location = new System.Drawing.Point(196, 27);
            this.pgb.Maximum = 120;
            this.pgb.Name = "pgb";
            this.pgb.Size = new System.Drawing.Size(306, 37);
            this.pgb.TabIndex = 3;
            this.pgb.Value = 50;
            // 
            // btnTimer
            // 
            this.btnTimer.Location = new System.Drawing.Point(333, 83);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(144, 44);
            this.btnTimer.TabIndex = 5;
            this.btnTimer.Text = "btnTimer";
            this.btnTimer.UseVisualStyleBackColor = true;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(3, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnTimer);
            this.splitContainer1.Panel2.Controls.Add(this.pgb);
            this.splitContainer1.Panel2.Controls.Add(this.btndecrese);
            this.splitContainer1.Panel2.Controls.Add(this.btnAdd);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(798, 448);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textUserInput);
            this.Controls.Add(this.lblInfo3);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnSayHello);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSayHello;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox textUserInput;
        private System.Windows.Forms.Label lblInfo3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btndecrese;
        private System.Windows.Forms.ProgressBar pgb;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

