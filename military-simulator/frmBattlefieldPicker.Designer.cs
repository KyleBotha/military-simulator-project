namespace military_simulator
{
    partial class frmBattlefieldPicker
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
            this.pbMap1 = new System.Windows.Forms.PictureBox();
            this.lblMap1Name = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbMap2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbMap3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMap1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMap2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMap3)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMap1
            // 
            this.pbMap1.Location = new System.Drawing.Point(65, 117);
            this.pbMap1.Name = "pbMap1";
            this.pbMap1.Size = new System.Drawing.Size(678, 123);
            this.pbMap1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMap1.TabIndex = 0;
            this.pbMap1.TabStop = false;
            this.pbMap1.Click += new System.EventHandler(this.pbMap1_Click);
            // 
            // lblMap1Name
            // 
            this.lblMap1Name.AutoSize = true;
            this.lblMap1Name.BackColor = System.Drawing.Color.Yellow;
            this.lblMap1Name.Font = new System.Drawing.Font("Army", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMap1Name.Location = new System.Drawing.Point(337, 167);
            this.lblMap1Name.Name = "lblMap1Name";
            this.lblMap1Name.Size = new System.Drawing.Size(148, 29);
            this.lblMap1Name.TabIndex = 1;
            this.lblMap1Name.Text = "Mountains";
            this.lblMap1Name.Click += new System.EventHandler(this.lblMap1Name_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Yellow;
            this.lblTitle.Font = new System.Drawing.Font("Army", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(194, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(435, 42);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Pick your battlefield";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Army", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Swiss Alps";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pbMap2
            // 
            this.pbMap2.Location = new System.Drawing.Point(65, 264);
            this.pbMap2.Name = "pbMap2";
            this.pbMap2.Size = new System.Drawing.Size(678, 123);
            this.pbMap2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMap2.TabIndex = 3;
            this.pbMap2.TabStop = false;
            this.pbMap2.Click += new System.EventHandler(this.pbMap2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Army", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(318, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "City Outskirts";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pbMap3
            // 
            this.pbMap3.Location = new System.Drawing.Point(65, 408);
            this.pbMap3.Name = "pbMap3";
            this.pbMap3.Size = new System.Drawing.Size(678, 123);
            this.pbMap3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMap3.TabIndex = 5;
            this.pbMap3.TabStop = false;
            this.pbMap3.Click += new System.EventHandler(this.pbMap3_Click);
            // 
            // frmBattlefieldPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbMap3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbMap2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblMap1Name);
            this.Controls.Add(this.pbMap1);
            this.Name = "frmBattlefieldPicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmBattlefieldPicker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMap1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMap2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMap3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMap1;
        private System.Windows.Forms.Label lblMap1Name;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbMap2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbMap3;
    }
}