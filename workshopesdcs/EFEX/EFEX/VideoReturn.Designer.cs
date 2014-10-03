namespace EFEX
{
    partial class VideoReturn
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
            this.lblcus = new System.Windows.Forms.Label();
            this.lblmovie = new System.Windows.Forms.Label();
            this.txtcus = new System.Windows.Forms.TextBox();
            this.dgvvr = new System.Windows.Forms.DataGridView();
            this.btnfind = new System.Windows.Forms.Button();
            this.txtmov = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvr)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcus
            // 
            this.lblcus.AutoSize = true;
            this.lblcus.Location = new System.Drawing.Point(35, 48);
            this.lblcus.Name = "lblcus";
            this.lblcus.Size = new System.Drawing.Size(51, 13);
            this.lblcus.TabIndex = 0;
            this.lblcus.Text = "Customer";
            // 
            // lblmovie
            // 
            this.lblmovie.AutoSize = true;
            this.lblmovie.Location = new System.Drawing.Point(214, 48);
            this.lblmovie.Name = "lblmovie";
            this.lblmovie.Size = new System.Drawing.Size(36, 13);
            this.lblmovie.TabIndex = 1;
            this.lblmovie.Text = "Movie";
            // 
            // txtcus
            // 
            this.txtcus.Location = new System.Drawing.Point(92, 45);
            this.txtcus.Name = "txtcus";
            this.txtcus.Size = new System.Drawing.Size(100, 20);
            this.txtcus.TabIndex = 2;
            this.txtcus.TextChanged += new System.EventHandler(this.txtcus_TextChanged);
            // 
            // dgvvr
            // 
            this.dgvvr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvr.Location = new System.Drawing.Point(24, 125);
            this.dgvvr.MultiSelect = false;
            this.dgvvr.Name = "dgvvr";
            this.dgvvr.ReadOnly = true;
            this.dgvvr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvvr.Size = new System.Drawing.Size(453, 289);
            this.dgvvr.TabIndex = 3;
            // 
            // btnfind
            // 
            this.btnfind.Location = new System.Drawing.Point(402, 45);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(75, 23);
            this.btnfind.TabIndex = 4;
            this.btnfind.Text = "Find";
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // txtmov
            // 
            this.txtmov.Location = new System.Drawing.Point(266, 45);
            this.txtmov.Name = "txtmov";
            this.txtmov.Size = new System.Drawing.Size(100, 20);
            this.txtmov.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // VideoReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmov);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.dgvvr);
            this.Controls.Add(this.txtcus);
            this.Controls.Add(this.lblmovie);
            this.Controls.Add(this.lblcus);
            this.Name = "VideoReturn";
            this.Text = "VideoReturn";
            this.Load += new System.EventHandler(this.VideoReturn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvvr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcus;
        private System.Windows.Forms.Label lblmovie;
        private System.Windows.Forms.TextBox txtcus;
        private System.Windows.Forms.DataGridView dgvvr;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.TextBox txtmov;
        private System.Windows.Forms.Label label1;
    }
}