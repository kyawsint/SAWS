namespace workshopgui
{
    partial class eg1_3a
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
            this.btnreset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(189, 177);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 23);
            this.btnreset.TabIndex = 0;
            this.btnreset.Text = "Button";
            this.btnreset.UseVisualStyleBackColor = true;
            // 
            // eg1_3a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 237);
            this.Controls.Add(this.btnreset);
            this.Name = "eg1_3a";
            this.Text = "My First Form Application";
            this.Load += new System.EventHandler(this.eg1_3a_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnreset;
    }
}