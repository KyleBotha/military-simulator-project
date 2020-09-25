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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBattlefieldPicker));
            this.pbMap1 = new System.Windows.Forms.PictureBox();
            this.lblMap1Name = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMap1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMap1
            // 
            this.pbMap1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbMap1.BackgroundImage")));
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
            // frmBattlefieldPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(800, 402);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblMap1Name);
            this.Controls.Add(this.pbMap1);
            this.Name = "frmBattlefieldPicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pbMap1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMap1;
        private System.Windows.Forms.Label lblMap1Name;
        private System.Windows.Forms.Label lblTitle;
    }
}