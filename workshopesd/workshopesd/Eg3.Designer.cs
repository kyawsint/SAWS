namespace workshopesd
{
    partial class Eg3
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_retrieve = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // btn_retrieve
            // 
            this.btn_retrieve.Location = new System.Drawing.Point(221, 75);
            this.btn_retrieve.Name = "btn_retrieve";
            this.btn_retrieve.Size = new System.Drawing.Size(75, 23);
            this.btn_retrieve.TabIndex = 1;
            this.btn_retrieve.Text = "Retrieve";
            this.btn_retrieve.UseVisualStyleBackColor = true;
            this.btn_retrieve.Click += new System.EventHandler(this.btn_retrieve_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(221, 129);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(221, 184);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 3;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // Eg3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 414);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_retrieve);
            this.Controls.Add(this.label1);
            this.Name = "Eg3";
            this.Text = "Eg3";
            this.Load += new System.EventHandler(this.Eg3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_retrieve;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_insert;
    }
}