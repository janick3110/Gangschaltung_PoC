using System.Windows.Forms;

namespace Gangschaltung_PoC
{
    partial class GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.flpEnvironment = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitleEnvironment = new System.Windows.Forms.Label();
            this.lblSteigung = new System.Windows.Forms.Label();
            this.flpCar = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitleCar = new System.Windows.Forms.Label();
            this.lblSubtitleWeight = new System.Windows.Forms.Label();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.lblSubtitleHP = new System.Windows.Forms.Label();
            this.tbHP = new System.Windows.Forms.TextBox();
            this.lblSubtitleGears = new System.Windows.Forms.Label();
            this.tbGears = new System.Windows.Forms.TextBox();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrentGear = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.bntGearshift = new System.Windows.Forms.Button();
            this.btnBrake = new System.Windows.Forms.Button();
            this.btnAccelerate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.flpEnvironment.SuspendLayout();
            this.flpCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(558, 390);
            this.splitContainer1.SplitterDistance = 396;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer3.Size = new System.Drawing.Size(396, 390);
            this.splitContainer3.SplitterDistance = 206;
            this.splitContainer3.SplitterWidth = 3;
            this.splitContainer3.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer4.Panel1.Controls.Add(this.numericUpDown1);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.pictureBox2);
            this.splitContainer4.Panel2.Controls.Add(this.numericUpDown2);
            this.splitContainer4.Size = new System.Drawing.Size(396, 206);
            this.splitContainer4.SplitterDistance = 196;
            this.splitContainer4.SplitterWidth = 3;
            this.splitContainer4.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 186);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.numericUpDown1.Location = new System.Drawing.Point(0, 186);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(196, 20);
            this.numericUpDown1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(197, 186);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.numericUpDown2.Location = new System.Drawing.Point(0, 186);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(197, 20);
            this.numericUpDown2.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.flpEnvironment);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.flpCar);
            this.splitContainer2.Size = new System.Drawing.Size(159, 390);
            this.splitContainer2.SplitterDistance = 109;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 0;
            // 
            // flpEnvironment
            // 
            this.flpEnvironment.Controls.Add(this.lblTitleEnvironment);
            this.flpEnvironment.Controls.Add(this.lblSteigung);
            this.flpEnvironment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpEnvironment.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpEnvironment.Location = new System.Drawing.Point(0, 0);
            this.flpEnvironment.Name = "flpEnvironment";
            this.flpEnvironment.Size = new System.Drawing.Size(159, 109);
            this.flpEnvironment.TabIndex = 0;
            // 
            // lblTitleEnvironment
            // 
            this.lblTitleEnvironment.AutoSize = true;
            this.lblTitleEnvironment.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblTitleEnvironment.Location = new System.Drawing.Point(3, 0);
            this.lblTitleEnvironment.Name = "lblTitleEnvironment";
            this.lblTitleEnvironment.Size = new System.Drawing.Size(76, 25);
            this.lblTitleEnvironment.TabIndex = 0;
            this.lblTitleEnvironment.Text = "Umwelt";
            // 
            // lblSteigung
            // 
            this.lblSteigung.AutoSize = true;
            this.lblSteigung.Location = new System.Drawing.Point(3, 25);
            this.lblSteigung.Name = "lblSteigung";
            this.lblSteigung.Size = new System.Drawing.Size(72, 13);
            this.lblSteigung.TabIndex = 1;
            this.lblSteigung.Text = "Steigung: 0 %";
            // 
            // flpCar
            // 
            this.flpCar.Controls.Add(this.lblTitleCar);
            this.flpCar.Controls.Add(this.lblSubtitleWeight);
            this.flpCar.Controls.Add(this.tbWeight);
            this.flpCar.Controls.Add(this.lblSubtitleHP);
            this.flpCar.Controls.Add(this.tbHP);
            this.flpCar.Controls.Add(this.lblSubtitleGears);
            this.flpCar.Controls.Add(this.tbGears);
            this.flpCar.Controls.Add(this.btnSwitch);
            this.flpCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpCar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpCar.Location = new System.Drawing.Point(0, 0);
            this.flpCar.Name = "flpCar";
            this.flpCar.Size = new System.Drawing.Size(159, 278);
            this.flpCar.TabIndex = 0;
            // 
            // lblTitleCar
            // 
            this.lblTitleCar.AutoSize = true;
            this.lblTitleCar.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblTitleCar.Location = new System.Drawing.Point(3, 0);
            this.lblTitleCar.Name = "lblTitleCar";
            this.lblTitleCar.Size = new System.Drawing.Size(52, 25);
            this.lblTitleCar.TabIndex = 0;
            this.lblTitleCar.Text = "Auto";
            // 
            // lblSubtitleWeight
            // 
            this.lblSubtitleWeight.AutoSize = true;
            this.lblSubtitleWeight.Location = new System.Drawing.Point(3, 25);
            this.lblSubtitleWeight.Name = "lblSubtitleWeight";
            this.lblSubtitleWeight.Size = new System.Drawing.Size(46, 13);
            this.lblSubtitleWeight.TabIndex = 1;
            this.lblSubtitleWeight.Text = "Gewicht";
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(3, 41);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(128, 20);
            this.tbWeight.TabIndex = 4;
            this.tbWeight.Text = "1200";
            // 
            // lblSubtitleHP
            // 
            this.lblSubtitleHP.AutoSize = true;
            this.lblSubtitleHP.Location = new System.Drawing.Point(3, 64);
            this.lblSubtitleHP.Name = "lblSubtitleHP";
            this.lblSubtitleHP.Size = new System.Drawing.Size(21, 13);
            this.lblSubtitleHP.TabIndex = 2;
            this.lblSubtitleHP.Text = "PS";
            // 
            // tbHP
            // 
            this.tbHP.Location = new System.Drawing.Point(3, 80);
            this.tbHP.Name = "tbHP";
            this.tbHP.Size = new System.Drawing.Size(128, 20);
            this.tbHP.TabIndex = 5;
            this.tbHP.Text = "75";
            // 
            // lblSubtitleGears
            // 
            this.lblSubtitleGears.AutoSize = true;
            this.lblSubtitleGears.Location = new System.Drawing.Point(3, 103);
            this.lblSubtitleGears.Name = "lblSubtitleGears";
            this.lblSubtitleGears.Size = new System.Drawing.Size(74, 13);
            this.lblSubtitleGears.TabIndex = 3;
            this.lblSubtitleGears.Text = "Anzahl Gänge";
            // 
            // tbGears
            // 
            this.tbGears.Location = new System.Drawing.Point(3, 119);
            this.tbGears.Name = "tbGears";
            this.tbGears.Size = new System.Drawing.Size(128, 20);
            this.tbGears.TabIndex = 6;
            this.tbGears.Text = "5";
            // 
            // btnSwitch
            // 
            this.btnSwitch.BackColor = System.Drawing.Color.Tomato;
            this.btnSwitch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSwitch.BackgroundImage")));
            this.btnSwitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSwitch.Location = new System.Drawing.Point(3, 145);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(113, 114);
            this.btnSwitch.TabIndex = 7;
            this.btnSwitch.UseVisualStyleBackColor = false;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.flowLayoutPanel2);
            this.splitContainer5.Size = new System.Drawing.Size(396, 181);
            this.splitContainer5.SplitterDistance = 116;
            this.splitContainer5.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.lblCurrentGear);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(116, 181);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aktueller Gang";
            // 
            // lblCurrentGear
            // 
            this.lblCurrentGear.AutoSize = true;
            this.lblCurrentGear.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F);
            this.lblCurrentGear.Location = new System.Drawing.Point(3, 48);
            this.lblCurrentGear.Name = "lblCurrentGear";
            this.lblCurrentGear.Size = new System.Drawing.Size(86, 120);
            this.lblCurrentGear.TabIndex = 1;
            this.lblCurrentGear.Text = "-";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.bntGearshift);
            this.flowLayoutPanel2.Controls.Add(this.btnBrake);
            this.flowLayoutPanel2.Controls.Add(this.btnAccelerate);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(276, 181);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // bntGearshift
            // 
            this.bntGearshift.Location = new System.Drawing.Point(3, 3);
            this.bntGearshift.Name = "bntGearshift";
            this.bntGearshift.Size = new System.Drawing.Size(84, 175);
            this.bntGearshift.TabIndex = 0;
            this.bntGearshift.Text = "Kupplung";
            this.bntGearshift.UseVisualStyleBackColor = true;
            // 
            // btnBrake
            // 
            this.btnBrake.Location = new System.Drawing.Point(93, 3);
            this.btnBrake.Name = "btnBrake";
            this.btnBrake.Size = new System.Drawing.Size(84, 175);
            this.btnBrake.TabIndex = 1;
            this.btnBrake.Text = "Bremspedal";
            this.btnBrake.UseVisualStyleBackColor = true;
            // 
            // btnAccelerate
            // 
            this.btnAccelerate.Location = new System.Drawing.Point(183, 3);
            this.btnAccelerate.Name = "btnAccelerate";
            this.btnAccelerate.Size = new System.Drawing.Size(84, 175);
            this.btnAccelerate.TabIndex = 2;
            this.btnAccelerate.Text = "Gaspedal";
            this.btnAccelerate.UseVisualStyleBackColor = true;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 390);
            this.Controls.Add(this.splitContainer1);
            this.Name = "GUI";
            this.Text = "GUI";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.flpEnvironment.ResumeLayout(false);
            this.flpEnvironment.PerformLayout();
            this.flpCar.ResumeLayout(false);
            this.flpCar.PerformLayout();
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private FlowLayoutPanel flpEnvironment;
        private Label lblTitleEnvironment;
        private Label lblSteigung;
        private FlowLayoutPanel flpCar;
        private Label lblTitleCar;
        private Label lblSubtitleWeight;
        private TextBox tbWeight;
        private Label lblSubtitleHP;
        private TextBox tbHP;
        private Label lblSubtitleGears;
        private TextBox tbGears;
        private Button btnSwitch;
        private SplitContainer splitContainer3;
        private SplitContainer splitContainer4;
        private PictureBox pictureBox1;
        private NumericUpDown numericUpDown1;
        private PictureBox pictureBox2;
        private NumericUpDown numericUpDown2;
        private SplitContainer splitContainer5;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label lblCurrentGear;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button bntGearshift;
        private Button btnBrake;
        private Button btnAccelerate;
    }
}