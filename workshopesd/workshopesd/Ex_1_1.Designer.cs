namespace workshopesd
{
    partial class Ex_1_1
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
            this.txtvideo_code = new System.Windows.Forms.TextBox();
            this.txtrental_price = new System.Windows.Forms.TextBox();
            this.lblvideo_code = new System.Windows.Forms.Label();
            this.lblrenten_price = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtvideo_code
            // 
            this.txtvideo_code.Location = new System.Drawing.Point(160, 83);
            this.txtvideo_code.Name = "txtvideo_code";
            this.txtvideo_code.Size = new System.Drawing.Size(150, 20);
            this.txtvideo_code.TabIndex = 1;
            // 
            // txtrental_price
            // 
            this.txtrental_price.Location = new System.Drawing.Point(160, 131);
            this.txtrental_price.Name = "txtrental_price";
            this.txtrental_price.Size = new System.Drawing.Size(150, 20);
            this.txtrental_price.TabIndex = 2;
            // 
            // lblvideo_code
            // 
            this.lblvideo_code.AutoSize = true;
            this.lblvideo_code.Location = new System.Drawing.Point(83, 86);
            this.lblvideo_code.Name = "lblvideo_code";
            this.lblvideo_code.Size = new System.Drawing.Size(71, 13);
            this.lblvideo_code.TabIndex = 0;
            this.lblvideo_code.Text = "Video Code : ";
            // 
            // lblrenten_price
            // 
            this.lblrenten_price.AutoSize = true;
            this.lblrenten_price.Location = new System.Drawing.Point(83, 134);
            this.lblrenten_price.Name = "lblrenten_price";
            this.lblrenten_price.Size = new System.Drawing.Size(74, 13);
            this.lblrenten_price.TabIndex = 3;
            this.lblrenten_price.Text = "Rental Price : ";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(128, 214);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // Ex_1_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 344);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.lblrenten_price);
            this.Controls.Add(this.txtrental_price);
            this.Controls.Add(this.txtvideo_code);
            this.Controls.Add(this.lblvideo_code);
            this.Name = "Ex_1_1";
            this.Text = "Change Video Rental Price";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtvideo_code;
        private System.Windows.Forms.TextBox txtrental_price;
        private System.Windows.Forms.Label lblvideo_code;
        private System.Windows.Forms.Label lblrenten_price;
        private System.Windows.Forms.Button btn_update;

    }
}