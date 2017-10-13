namespace adsClicke
{
    partial class addAddr
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
            this.nud_priority = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nud_maxWndCount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nud_maxDepth = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_notice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_addr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.nud_visitTS = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_active = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_priority)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_maxWndCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_maxDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_visitTS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_active);
            this.groupBox1.Controls.Add(this.nud_visitTS);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.nud_priority);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nud_maxWndCount);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nud_maxDepth);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_notice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_addr);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "详情";
            // 
            // nud_priority
            // 
            this.nud_priority.Location = new System.Drawing.Point(54, 79);
            this.nud_priority.Name = "nud_priority";
            this.nud_priority.Size = new System.Drawing.Size(35, 21);
            this.nud_priority.TabIndex = 11;
            this.nud_priority.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "权值:";
            // 
            // nud_maxWndCount
            // 
            this.nud_maxWndCount.Location = new System.Drawing.Point(304, 79);
            this.nud_maxWndCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_maxWndCount.Name = "nud_maxWndCount";
            this.nud_maxWndCount.Size = new System.Drawing.Size(35, 21);
            this.nud_maxWndCount.TabIndex = 9;
            this.nud_maxWndCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "最大窗口数:";
            // 
            // nud_maxDepth
            // 
            this.nud_maxDepth.Location = new System.Drawing.Point(173, 79);
            this.nud_maxDepth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_maxDepth.Name = "nud_maxDepth";
            this.nud_maxDepth.Size = new System.Drawing.Size(35, 21);
            this.nud_maxDepth.TabIndex = 7;
            this.nud_maxDepth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "最大深度:";
            // 
            // tb_notice
            // 
            this.tb_notice.Location = new System.Drawing.Point(54, 106);
            this.tb_notice.Name = "tb_notice";
            this.tb_notice.Size = new System.Drawing.Size(476, 21);
            this.tb_notice.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "备注:";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(54, 45);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(231, 21);
            this.tb_name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "名称:";
            // 
            // tb_addr
            // 
            this.tb_addr.Location = new System.Drawing.Point(54, 18);
            this.tb_addr.Name = "tb_addr";
            this.tb_addr.Size = new System.Drawing.Size(476, 21);
            this.tb_addr.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "地址:";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(549, 106);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(60, 23);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // nud_visitTS
            // 
            this.nud_visitTS.Location = new System.Drawing.Point(427, 79);
            this.nud_visitTS.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_visitTS.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_visitTS.Name = "nud_visitTS";
            this.nud_visitTS.Size = new System.Drawing.Size(49, 21);
            this.nud_visitTS.TabIndex = 13;
            this.nud_visitTS.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(362, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "访问间隔:";
            // 
            // cb_active
            // 
            this.cb_active.AutoSize = true;
            this.cb_active.Location = new System.Drawing.Point(483, 82);
            this.cb_active.Name = "cb_active";
            this.cb_active.Size = new System.Drawing.Size(48, 16);
            this.cb_active.TabIndex = 14;
            this.cb_active.Text = "活动";
            this.cb_active.UseVisualStyleBackColor = true;
            // 
            // addAddr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 161);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.groupBox1);
            this.Name = "addAddr";
            this.Text = "添加/修改 地址";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_priority)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_maxWndCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_maxDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_visitTS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nud_priority;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nud_maxWndCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nud_maxDepth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_notice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_addr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.NumericUpDown nud_visitTS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cb_active;
    }
}