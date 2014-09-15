namespace workshopgui
{
    partial class CatchAFish
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
            this.btnfish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnfish
            // 
            this.btnfish.Image = global::workshopgui.Properties.Resources.BigFish;
            this.btnfish.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnfish.Location = new System.Drawing.Point(329, 151);
            this.btnfish.Name = "btnfish";
            this.btnfish.Size = new System.Drawing.Size(119, 88);
            this.btnfish.TabIndex = 0;
            this.btnfish.UseVisualStyleBackColor = true;
            this.btnfish.MouseEnter += new System.EventHandler(this.Fish_MouseEnter);
            // 
            // CatchAFish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 361);
            this.Controls.Add(this.btnfish);
            this.Name = "CatchAFish";
            this.Text = "CatchAFish";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnfish;
    }
}