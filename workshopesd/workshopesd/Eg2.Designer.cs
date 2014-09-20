namespace workshopesd
{
    partial class Eg2
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
            this.btn_updconcat = new System.Windows.Forms.Button();
            this.btn_updparam = new System.Windows.Forms.Button();
            this.btn_updsto = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_updconcat
            // 
            this.btn_updconcat.Location = new System.Drawing.Point(293, 48);
            this.btn_updconcat.Name = "btn_updconcat";
            this.btn_updconcat.Size = new System.Drawing.Size(135, 23);
            this.btn_updconcat.TabIndex = 0;
            this.btn_updconcat.Text = "Upd Concat";
            this.btn_updconcat.UseVisualStyleBackColor = true;
            this.btn_updconcat.Click += new System.EventHandler(this.btn_updconcat_Click);
            // 
            // btn_updparam
            // 
            this.btn_updparam.Location = new System.Drawing.Point(293, 93);
            this.btn_updparam.Name = "btn_updparam";
            this.btn_updparam.Size = new System.Drawing.Size(135, 23);
            this.btn_updparam.TabIndex = 1;
            this.btn_updparam.Text = "Upd Param";
            this.btn_updparam.UseVisualStyleBackColor = true;
            this.btn_updparam.Click += new System.EventHandler(this.btn_updparam_Click);
            // 
            // btn_updsto
            // 
            this.btn_updsto.Location = new System.Drawing.Point(293, 142);
            this.btn_updsto.Name = "btn_updsto";
            this.btn_updsto.Size = new System.Drawing.Size(135, 23);
            this.btn_updsto.TabIndex = 2;
            this.btn_updsto.Text = "Upd StordPrco";
            this.btn_updsto.UseVisualStyleBackColor = true;
            this.btn_updsto.Click += new System.EventHandler(this.btn_updsto_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(119, 216);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(309, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // Eg2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 380);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_updsto);
            this.Controls.Add(this.btn_updparam);
            this.Controls.Add(this.btn_updconcat);
            this.Name = "Eg2";
            this.Text = "Eg2";
            this.Load += new System.EventHandler(this.Eg2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_updconcat;
        private System.Windows.Forms.Button btn_updparam;
        private System.Windows.Forms.Button btn_updsto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
    }
}