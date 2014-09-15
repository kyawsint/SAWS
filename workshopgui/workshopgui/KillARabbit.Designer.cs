namespace workshopgui
{
    partial class KillARabbit
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
            this.btnRabbit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRabbit
            // 
            this.btnRabbit.Image = global::workshopgui.Properties.Resources.rabbit;
            this.btnRabbit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRabbit.Location = new System.Drawing.Point(188, 82);
            this.btnRabbit.Name = "btnRabbit";
            this.btnRabbit.Size = new System.Drawing.Size(146, 108);
            this.btnRabbit.TabIndex = 0;
            this.btnRabbit.Text = "Rabbit";
            this.btnRabbit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRabbit.UseVisualStyleBackColor = true;
            this.btnRabbit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Rabbit_MouseDown);
            this.btnRabbit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Rabbit_MouseUp);
            // 
            // KillARabbit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 318);
            this.Controls.Add(this.btnRabbit);
            this.Name = "KillARabbit";
            this.Text = "Kill A Rabbit";
            this.Load += new System.EventHandler(this.KillARabbit_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRabbit;
    }
}