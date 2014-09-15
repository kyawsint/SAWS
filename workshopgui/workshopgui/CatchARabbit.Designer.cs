namespace workshopgui
{
    partial class CatchARabbit
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
            this.btnrabbit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnrabbit
            // 
            this.btnrabbit.Image = global::workshopgui.Properties.Resources.rabbit;
            this.btnrabbit.Location = new System.Drawing.Point(283, 57);
            this.btnrabbit.Name = "btnrabbit";
            this.btnrabbit.Size = new System.Drawing.Size(174, 117);
            this.btnrabbit.TabIndex = 0;
            this.btnrabbit.Text = "Rabbit";
            this.btnrabbit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnrabbit.UseVisualStyleBackColor = true;
            this.btnrabbit.Click += new System.EventHandler(this.btnrabbit_Click);
            // 
            // eg1_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 345);
            this.Controls.Add(this.btnrabbit);
            this.Name = "eg1_4";
            this.Text = "Catch A Rabbit";
            this.Load += new System.EventHandler(this.eg1_4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnrabbit;

    }
}