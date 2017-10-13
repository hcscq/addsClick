namespace adsClicke
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_showWnd = new System.Windows.Forms.CheckBox();
            this.nud_maxWndCount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_maxDepth = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_delDepth = new System.Windows.Forms.Button();
            this.btn_alterDepth = new System.Windows.Forms.Button();
            this.btn_addDepth = new System.Windows.Forms.Button();
            this.dgv_depthInfo = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_delAddr = new System.Windows.Forms.Button();
            this.btn_alterAddr = new System.Windows.Forms.Button();
            this.btn_addAddr = new System.Windows.Forms.Button();
            this.dgv_addrInfo = new System.Windows.Forms.DataGridView();
            this.nud_acTimeSpan = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_startWork = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_maxWndCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_maxDepth)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_depthInfo)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_addrInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_acTimeSpan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "最大深度：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nud_acTimeSpan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_showWnd);
            this.groupBox1.Controls.Add(this.nud_maxWndCount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nud_maxDepth);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 84);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数";
            // 
            // cb_showWnd
            // 
            this.cb_showWnd.AutoSize = true;
            this.cb_showWnd.Location = new System.Drawing.Point(121, 49);
            this.cb_showWnd.Name = "cb_showWnd";
            this.cb_showWnd.Size = new System.Drawing.Size(72, 16);
            this.cb_showWnd.TabIndex = 6;
            this.cb_showWnd.Text = "显示窗口";
            this.cb_showWnd.UseVisualStyleBackColor = true;
            // 
            // nud_maxWndCount
            // 
            this.nud_maxWndCount.Location = new System.Drawing.Point(77, 46);
            this.nud_maxWndCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_maxWndCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_maxWndCount.Name = "nud_maxWndCount";
            this.nud_maxWndCount.Size = new System.Drawing.Size(33, 21);
            this.nud_maxWndCount.TabIndex = 4;
            this.nud_maxWndCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "最大窗口数：";
            // 
            // nud_maxDepth
            // 
            this.nud_maxDepth.Location = new System.Drawing.Point(77, 15);
            this.nud_maxDepth.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nud_maxDepth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_maxDepth.Name = "nud_maxDepth";
            this.nud_maxDepth.Size = new System.Drawing.Size(33, 21);
            this.nud_maxDepth.TabIndex = 2;
            this.nud_maxDepth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_delDepth);
            this.groupBox2.Controls.Add(this.btn_alterDepth);
            this.groupBox2.Controls.Add(this.btn_addDepth);
            this.groupBox2.Controls.Add(this.dgv_depthInfo);
            this.groupBox2.Location = new System.Drawing.Point(241, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(686, 371);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "深度";
            // 
            // btn_delDepth
            // 
            this.btn_delDepth.Location = new System.Drawing.Point(492, 342);
            this.btn_delDepth.Name = "btn_delDepth";
            this.btn_delDepth.Size = new System.Drawing.Size(75, 23);
            this.btn_delDepth.TabIndex = 3;
            this.btn_delDepth.Text = "删除";
            this.btn_delDepth.UseVisualStyleBackColor = true;
            this.btn_delDepth.Click += new System.EventHandler(this.btn_delDepth_Click);
            // 
            // btn_alterDepth
            // 
            this.btn_alterDepth.Location = new System.Drawing.Point(410, 342);
            this.btn_alterDepth.Name = "btn_alterDepth";
            this.btn_alterDepth.Size = new System.Drawing.Size(75, 23);
            this.btn_alterDepth.TabIndex = 2;
            this.btn_alterDepth.Text = "修改";
            this.btn_alterDepth.UseVisualStyleBackColor = true;
            this.btn_alterDepth.Click += new System.EventHandler(this.btn_alterDepth_Click);
            // 
            // btn_addDepth
            // 
            this.btn_addDepth.Location = new System.Drawing.Point(328, 342);
            this.btn_addDepth.Name = "btn_addDepth";
            this.btn_addDepth.Size = new System.Drawing.Size(75, 23);
            this.btn_addDepth.TabIndex = 1;
            this.btn_addDepth.Text = "添加";
            this.btn_addDepth.UseVisualStyleBackColor = true;
            this.btn_addDepth.Click += new System.EventHandler(this.btn_addDepth_Click);
            // 
            // dgv_depthInfo
            // 
            this.dgv_depthInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_depthInfo.Location = new System.Drawing.Point(7, 14);
            this.dgv_depthInfo.Name = "dgv_depthInfo";
            this.dgv_depthInfo.RowTemplate.Height = 23;
            this.dgv_depthInfo.Size = new System.Drawing.Size(673, 323);
            this.dgv_depthInfo.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_delAddr);
            this.groupBox3.Controls.Add(this.btn_alterAddr);
            this.groupBox3.Controls.Add(this.btn_addAddr);
            this.groupBox3.Controls.Add(this.dgv_addrInfo);
            this.groupBox3.Location = new System.Drawing.Point(12, 103);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(223, 281);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "地址";
            // 
            // btn_delAddr
            // 
            this.btn_delAddr.Location = new System.Drawing.Point(135, 253);
            this.btn_delAddr.Name = "btn_delAddr";
            this.btn_delAddr.Size = new System.Drawing.Size(58, 23);
            this.btn_delAddr.TabIndex = 3;
            this.btn_delAddr.Text = "删除";
            this.btn_delAddr.UseVisualStyleBackColor = true;
            this.btn_delAddr.Click += new System.EventHandler(this.btn_delAddr_Click);
            // 
            // btn_alterAddr
            // 
            this.btn_alterAddr.Location = new System.Drawing.Point(70, 253);
            this.btn_alterAddr.Name = "btn_alterAddr";
            this.btn_alterAddr.Size = new System.Drawing.Size(59, 23);
            this.btn_alterAddr.TabIndex = 2;
            this.btn_alterAddr.Text = "修改";
            this.btn_alterAddr.UseVisualStyleBackColor = true;
            this.btn_alterAddr.Click += new System.EventHandler(this.btn_alterAddr_Click);
            // 
            // btn_addAddr
            // 
            this.btn_addAddr.Location = new System.Drawing.Point(7, 253);
            this.btn_addAddr.Name = "btn_addAddr";
            this.btn_addAddr.Size = new System.Drawing.Size(57, 23);
            this.btn_addAddr.TabIndex = 1;
            this.btn_addAddr.Text = "添加";
            this.btn_addAddr.UseVisualStyleBackColor = true;
            this.btn_addAddr.Click += new System.EventHandler(this.btn_addAddr_Click);
            // 
            // dgv_addrInfo
            // 
            this.dgv_addrInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_addrInfo.Location = new System.Drawing.Point(8, 20);
            this.dgv_addrInfo.Name = "dgv_addrInfo";
            this.dgv_addrInfo.RowTemplate.Height = 23;
            this.dgv_addrInfo.Size = new System.Drawing.Size(207, 227);
            this.dgv_addrInfo.TabIndex = 0;
            // 
            // nud_acTimeSpan
            // 
            this.nud_acTimeSpan.Location = new System.Drawing.Point(175, 15);
            this.nud_acTimeSpan.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nud_acTimeSpan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_acTimeSpan.Name = "nud_acTimeSpan";
            this.nud_acTimeSpan.Size = new System.Drawing.Size(33, 21);
            this.nud_acTimeSpan.TabIndex = 8;
            this.nud_acTimeSpan.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "操作间隔：";
            // 
            // btn_startWork
            // 
            this.btn_startWork.Location = new System.Drawing.Point(852, 390);
            this.btn_startWork.Name = "btn_startWork";
            this.btn_startWork.Size = new System.Drawing.Size(75, 23);
            this.btn_startWork.TabIndex = 5;
            this.btn_startWork.Text = "启动";
            this.btn_startWork.UseVisualStyleBackColor = true;
            this.btn_startWork.Click += new System.EventHandler(this.btn_startWork_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 420);
            this.Controls.Add(this.btn_startWork);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_maxWndCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_maxDepth)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_depthInfo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_addrInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_acTimeSpan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nud_maxDepth;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_depthInfo;
        private System.Windows.Forms.Button btn_delDepth;
        private System.Windows.Forms.Button btn_alterDepth;
        private System.Windows.Forms.Button btn_addDepth;
        private System.Windows.Forms.CheckBox cb_showWnd;
        private System.Windows.Forms.NumericUpDown nud_maxWndCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_delAddr;
        private System.Windows.Forms.Button btn_alterAddr;
        private System.Windows.Forms.Button btn_addAddr;
        private System.Windows.Forms.DataGridView dgv_addrInfo;
        private System.Windows.Forms.NumericUpDown nud_acTimeSpan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_startWork;
    }
}

