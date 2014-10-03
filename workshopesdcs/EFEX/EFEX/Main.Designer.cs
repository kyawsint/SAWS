namespace EFEX
{
    partial class Main
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
            this.btnvi = new System.Windows.Forms.Button();
            this.btnvr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnvi
            // 
            this.btnvi.Location = new System.Drawing.Point(40, 52);
            this.btnvi.Name = "btnvi";
            this.btnvi.Size = new System.Drawing.Size(75, 23);
            this.btnvi.TabIndex = 0;
            this.btnvi.Text = "Video Issue";
            this.btnvi.UseVisualStyleBackColor = true;
            this.btnvi.Click += new System.EventHandler(this.btnvi_Click);
            // 
            // btnvr
            // 
            this.btnvr.Location = new System.Drawing.Point(144, 52);
            this.btnvr.Name = "btnvr";
            this.btnvr.Size = new System.Drawing.Size(78, 23);
            this.btnvr.TabIndex = 1;
            this.btnvr.Text = "Video Return";
            this.btnvr.UseVisualStyleBackColor = true;
            this.btnvr.Click += new System.EventHandler(this.btnvr_Click);
            // 
            // VideoMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnvr);
            this.Controls.Add(this.btnvi);
            this.Name = "VideoMain";
            this.Text = "VideoMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnvi;
        private System.Windows.Forms.Button btnvr;
    }
}