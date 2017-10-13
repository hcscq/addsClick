namespace adsClicke
{
    partial class webBrowser
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
            this.wb = new System.Windows.Forms.WebBrowser();
            this.btn_getCT = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wb
            // 
            this.wb.Location = new System.Drawing.Point(0, 0);
            this.wb.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb.Name = "wb";
            this.wb.Size = new System.Drawing.Size(1194, 261);
            this.wb.TabIndex = 0;
            // 
            // btn_getCT
            // 
            this.btn_getCT.Location = new System.Drawing.Point(1201, 226);
            this.btn_getCT.Name = "btn_getCT";
            this.btn_getCT.Size = new System.Drawing.Size(75, 23);
            this.btn_getCT.TabIndex = 1;
            this.btn_getCT.Text = "GetCT";
            this.btn_getCT.UseVisualStyleBackColor = true;
            this.btn_getCT.Click += new System.EventHandler(this.btn_getCT_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(1201, 197);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 2;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // webBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 261);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_getCT);
            this.Controls.Add(this.wb);
            this.Name = "webBrowser";
            this.Text = "webBrowser";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wb;
        private System.Windows.Forms.Button btn_getCT;
        private System.Windows.Forms.Button btn_refresh;
    }
}