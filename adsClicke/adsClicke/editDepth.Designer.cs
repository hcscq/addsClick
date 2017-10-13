namespace adsClicke
{
    partial class editDepth
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
            this.nud_maxLastTime = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nud_minLastTime = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nud_maxActionSpan = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nud_minActionSpan = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nud_maxWndCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_prefix = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_depth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.nud_maxVisitTimes = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_maxLastTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_minLastTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_maxActionSpan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_minActionSpan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_maxWndCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_depth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_maxVisitTimes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nud_maxVisitTimes);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.nud_maxLastTime);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.nud_minLastTime);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nud_maxActionSpan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nud_minActionSpan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nud_maxWndCount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_prefix);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nud_depth);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "详情";
            // 
            // nud_maxLastTime
            // 
            this.nud_maxLastTime.Location = new System.Drawing.Point(458, 28);
            this.nud_maxLastTime.Name = "nud_maxLastTime";
            this.nud_maxLastTime.Size = new System.Drawing.Size(33, 21);
            this.nud_maxLastTime.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(442, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "~";
            // 
            // nud_minLastTime
            // 
            this.nud_minLastTime.Location = new System.Drawing.Point(405, 27);
            this.nud_minLastTime.Name = "nud_minLastTime";
            this.nud_minLastTime.Size = new System.Drawing.Size(31, 21);
            this.nud_minLastTime.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "持续时间:";
            // 
            // nud_maxActionSpan
            // 
            this.nud_maxActionSpan.Location = new System.Drawing.Point(331, 58);
            this.nud_maxActionSpan.Name = "nud_maxActionSpan";
            this.nud_maxActionSpan.Size = new System.Drawing.Size(33, 21);
            this.nud_maxActionSpan.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "~";
            // 
            // nud_minActionSpan
            // 
            this.nud_minActionSpan.Location = new System.Drawing.Point(280, 58);
            this.nud_minActionSpan.Name = "nud_minActionSpan";
            this.nud_minActionSpan.Size = new System.Drawing.Size(30, 21);
            this.nud_minActionSpan.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "最小动作间隔:";
            // 
            // nud_maxWndCount
            // 
            this.nud_maxWndCount.Location = new System.Drawing.Point(166, 58);
            this.nud_maxWndCount.Name = "nud_maxWndCount";
            this.nud_maxWndCount.Size = new System.Drawing.Size(30, 21);
            this.nud_maxWndCount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "最大窗口数:";
            // 
            // tb_prefix
            // 
            this.tb_prefix.Location = new System.Drawing.Point(43, 26);
            this.tb_prefix.Name = "tb_prefix";
            this.tb_prefix.Size = new System.Drawing.Size(284, 21);
            this.tb_prefix.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "前缀:";
            // 
            // nud_depth
            // 
            this.nud_depth.Location = new System.Drawing.Point(43, 58);
            this.nud_depth.Name = "nud_depth";
            this.nud_depth.Size = new System.Drawing.Size(30, 21);
            this.nud_depth.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "深度:";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(510, 111);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // nud_maxVisitTimes
            // 
            this.nud_maxVisitTimes.Location = new System.Drawing.Point(458, 58);
            this.nud_maxVisitTimes.Name = "nud_maxVisitTimes";
            this.nud_maxVisitTimes.Size = new System.Drawing.Size(33, 21);
            this.nud_maxVisitTimes.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(370, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "最大访问次数:";
            // 
            // editDepth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 135);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.groupBox1);
            this.Name = "editDepth";
            this.Text = "添加/修改 深度";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_maxLastTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_minLastTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_maxActionSpan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_minActionSpan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_maxWndCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_depth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_maxVisitTimes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_prefix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nud_depth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_maxWndCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_maxActionSpan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nud_minActionSpan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.NumericUpDown nud_maxLastTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nud_minLastTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nud_maxVisitTimes;
        private System.Windows.Forms.Label label8;
    }
}