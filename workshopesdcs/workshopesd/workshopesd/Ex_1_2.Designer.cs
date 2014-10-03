namespace workshopesd
{
    partial class Ex_1_2
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
            this.btn_retrieve = new System.Windows.Forms.Button();
            this.lbl_retrieve = new System.Windows.Forms.ListBox();
            this.txt_rating = new System.Windows.Forms.TextBox();
            this.lbl_rating = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_retrieve
            // 
            this.btn_retrieve.Location = new System.Drawing.Point(171, 126);
            this.btn_retrieve.Name = "btn_retrieve";
            this.btn_retrieve.Size = new System.Drawing.Size(75, 23);
            this.btn_retrieve.TabIndex = 0;
            this.btn_retrieve.Text = "Retrieve";
            this.btn_retrieve.UseVisualStyleBackColor = true;
            this.btn_retrieve.Click += new System.EventHandler(this.btn_retrieve_Click);
            // 
            // lbl_retrieve
            // 
            this.lbl_retrieve.FormattingEnabled = true;
            this.lbl_retrieve.Location = new System.Drawing.Point(212, 177);
            this.lbl_retrieve.Name = "lbl_retrieve";
            this.lbl_retrieve.Size = new System.Drawing.Size(298, 342);
            this.lbl_retrieve.TabIndex = 1;
            // 
            // txt_rating
            // 
            this.txt_rating.Location = new System.Drawing.Point(240, 52);
            this.txt_rating.Name = "txt_rating";
            this.txt_rating.Size = new System.Drawing.Size(100, 20);
            this.txt_rating.TabIndex = 2;
            // 
            // lbl_rating
            // 
            this.lbl_rating.AutoSize = true;
            this.lbl_rating.Location = new System.Drawing.Point(162, 52);
            this.lbl_rating.Name = "lbl_rating";
            this.lbl_rating.Size = new System.Drawing.Size(47, 13);
            this.lbl_rating.TabIndex = 3;
            this.lbl_rating.Text = "Rating : ";
            // 
            // Ex_1_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 531);
            this.Controls.Add(this.lbl_rating);
            this.Controls.Add(this.txt_rating);
            this.Controls.Add(this.lbl_retrieve);
            this.Controls.Add(this.btn_retrieve);
            this.Name = "Ex_1_2";
            this.Text = "Ex_1_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_retrieve;
        private System.Windows.Forms.ListBox lbl_retrieve;
        private System.Windows.Forms.TextBox txt_rating;
        private System.Windows.Forms.Label lbl_rating;
    }
}