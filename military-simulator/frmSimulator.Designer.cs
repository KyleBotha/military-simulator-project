namespace military_simulator
{
    partial class frmSimulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSimulator));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.btnSumulate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbArmyCamp = new System.Windows.Forms.PictureBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbArmyCamp)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.DarkGray;
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(800, 800);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.Click += new System.EventHandler(this.panel1_Click);
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pnlRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRight.Controls.Add(this.btnSumulate);
            this.pnlRight.Controls.Add(this.label1);
            this.pnlRight.Controls.Add(this.pbArmyCamp);
            this.pnlRight.Location = new System.Drawing.Point(800, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(350, 900);
            this.pnlRight.TabIndex = 1;
            this.pnlRight.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRight_Paint);
            // 
            // btnSumulate
            // 
            this.btnSumulate.Location = new System.Drawing.Point(56, 291);
            this.btnSumulate.Name = "btnSumulate";
            this.btnSumulate.Size = new System.Drawing.Size(216, 51);
            this.btnSumulate.TabIndex = 4;
            this.btnSumulate.Text = "Simulate";
            this.btnSumulate.UseVisualStyleBackColor = true;
            this.btnSumulate.Click += new System.EventHandler(this.btnSumulate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Army", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Click to choose which item to drop";
            // 
            // pbArmyCamp
            // 
            this.pbArmyCamp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbArmyCamp.Image = ((System.Drawing.Image)(resources.GetObject("pbArmyCamp.Image")));
            this.pbArmyCamp.InitialImage = null;
            this.pbArmyCamp.Location = new System.Drawing.Point(36, 54);
            this.pbArmyCamp.Name = "pbArmyCamp";
            this.pbArmyCamp.Size = new System.Drawing.Size(104, 99);
            this.pbArmyCamp.TabIndex = 0;
            this.pbArmyCamp.TabStop = false;
            this.pbArmyCamp.Click += new System.EventHandler(this.pbArmyCamp_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBottom.Location = new System.Drawing.Point(0, 800);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(800, 100);
            this.pnlBottom.TabIndex = 2;
            this.pnlBottom.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBottom_Paint);
            // 
            // frmSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(1150, 900);
            this.ControlBox = false;
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frmSimulator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSimulator";
            this.Load += new System.EventHandler(this.frmSimulator_Load);
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbArmyCamp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.PictureBox pbArmyCamp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSumulate;
    }
}