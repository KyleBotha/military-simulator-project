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
            this.btnRunSim = new System.Windows.Forms.Button();
            this.pbEnd = new System.Windows.Forms.PictureBox();
            this.pbMortar = new System.Windows.Forms.PictureBox();
            this.pbStart = new System.Windows.Forms.PictureBox();
            this.btnSumulate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbArmyCamp = new System.Windows.Forms.PictureBox();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMortar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStart)).BeginInit();
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
            this.pnlRight.Controls.Add(this.btnRunSim);
            this.pnlRight.Controls.Add(this.pbEnd);
            this.pnlRight.Controls.Add(this.pbMortar);
            this.pnlRight.Controls.Add(this.pbStart);
            this.pnlRight.Controls.Add(this.btnSumulate);
            this.pnlRight.Controls.Add(this.label1);
            this.pnlRight.Controls.Add(this.pbArmyCamp);
            this.pnlRight.Location = new System.Drawing.Point(800, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(350, 800);
            this.pnlRight.TabIndex = 1;
            this.pnlRight.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRight_Paint);
            // 
            // btnRunSim
            // 
            this.btnRunSim.Font = new System.Drawing.Font("Army", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunSim.Location = new System.Drawing.Point(37, 438);
            this.btnRunSim.Name = "btnRunSim";
            this.btnRunSim.Size = new System.Drawing.Size(235, 51);
            this.btnRunSim.TabIndex = 8;
            this.btnRunSim.Text = "Run Simulation";
            this.btnRunSim.UseVisualStyleBackColor = true;
            this.btnRunSim.Click += new System.EventHandler(this.btnRunSim_Click);
            // 
            // pbEnd
            // 
            this.pbEnd.BackColor = System.Drawing.Color.DimGray;
            this.pbEnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbEnd.ErrorImage = null;
            this.pbEnd.Image = ((System.Drawing.Image)(resources.GetObject("pbEnd.Image")));
            this.pbEnd.InitialImage = null;
            this.pbEnd.Location = new System.Drawing.Point(168, 62);
            this.pbEnd.Name = "pbEnd";
            this.pbEnd.Size = new System.Drawing.Size(104, 99);
            this.pbEnd.TabIndex = 7;
            this.pbEnd.TabStop = false;
            this.pbEnd.Click += new System.EventHandler(this.pbEnd_Click);
            // 
            // pbMortar
            // 
            this.pbMortar.BackColor = System.Drawing.Color.DimGray;
            this.pbMortar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbMortar.Image = ((System.Drawing.Image)(resources.GetObject("pbMortar.Image")));
            this.pbMortar.InitialImage = null;
            this.pbMortar.Location = new System.Drawing.Point(168, 186);
            this.pbMortar.Name = "pbMortar";
            this.pbMortar.Size = new System.Drawing.Size(104, 99);
            this.pbMortar.TabIndex = 6;
            this.pbMortar.TabStop = false;
            this.pbMortar.Click += new System.EventHandler(this.pbMortar_Click);
            // 
            // pbStart
            // 
            this.pbStart.BackColor = System.Drawing.Color.DimGray;
            this.pbStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbStart.InitialImage = null;
            this.pbStart.Location = new System.Drawing.Point(37, 62);
            this.pbStart.Name = "pbStart";
            this.pbStart.Size = new System.Drawing.Size(104, 99);
            this.pbStart.TabIndex = 5;
            this.pbStart.TabStop = false;
            this.pbStart.Click += new System.EventHandler(this.pbStart_Click);
            // 
            // btnSumulate
            // 
            this.btnSumulate.Font = new System.Drawing.Font("Army", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumulate.Location = new System.Drawing.Point(37, 362);
            this.btnSumulate.Name = "btnSumulate";
            this.btnSumulate.Size = new System.Drawing.Size(235, 51);
            this.btnSumulate.TabIndex = 4;
            this.btnSumulate.Text = "Setup Simulation";
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
            this.pbArmyCamp.BackColor = System.Drawing.Color.DimGray;
            this.pbArmyCamp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbArmyCamp.Image = ((System.Drawing.Image)(resources.GetObject("pbArmyCamp.Image")));
            this.pbArmyCamp.InitialImage = null;
            this.pbArmyCamp.Location = new System.Drawing.Point(37, 186);
            this.pbArmyCamp.Name = "pbArmyCamp";
            this.pbArmyCamp.Size = new System.Drawing.Size(104, 99);
            this.pbArmyCamp.TabIndex = 0;
            this.pbArmyCamp.TabStop = false;
            this.pbArmyCamp.Click += new System.EventHandler(this.pbArmyCamp_Click);
            // 
            // frmSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(1150, 900);
            this.ControlBox = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.pbEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMortar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArmyCamp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.PictureBox pbArmyCamp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSumulate;
        private System.Windows.Forms.PictureBox pbStart;
        private System.Windows.Forms.PictureBox pbMortar;
        private System.Windows.Forms.PictureBox pbEnd;
        private System.Windows.Forms.Button btnRunSim;
    }
}