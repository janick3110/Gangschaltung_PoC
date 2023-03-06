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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.flpCar = new System.Windows.Forms.FlowLayoutPanel();
            this.flpEnvironment = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitleEnvironment = new System.Windows.Forms.Label();
            this.lblSteigung = new System.Windows.Forms.Label();
            this.lblTitleCar = new System.Windows.Forms.Label();
            this.lblSubtitleWeight = new System.Windows.Forms.Label();
            this.lblSubtitleHP = new System.Windows.Forms.Label();
            this.lblSubtitleGears = new System.Windows.Forms.Label();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.tbHP = new System.Windows.Forms.TextBox();
            this.tbGears = new System.Windows.Forms.TextBox();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.flpCar.SuspendLayout();
            this.flpEnvironment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 568;
            this.splitContainer1.TabIndex = 0;
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
            this.splitContainer2.Size = new System.Drawing.Size(228, 450);
            this.splitContainer2.SplitterDistance = 126;
            this.splitContainer2.TabIndex = 0;
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
            this.flpCar.Size = new System.Drawing.Size(228, 320);
            this.flpCar.TabIndex = 0;
            // 
            // flpEnvironment
            // 
            this.flpEnvironment.Controls.Add(this.lblTitleEnvironment);
            this.flpEnvironment.Controls.Add(this.lblSteigung);
            this.flpEnvironment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpEnvironment.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpEnvironment.Location = new System.Drawing.Point(0, 0);
            this.flpEnvironment.Name = "flpEnvironment";
            this.flpEnvironment.Size = new System.Drawing.Size(228, 126);
            this.flpEnvironment.TabIndex = 0;
            // 
            // lblTitleEnvironment
            // 
            this.lblTitleEnvironment.AutoSize = true;
            this.lblTitleEnvironment.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.lblSteigung.Size = new System.Drawing.Size(79, 15);
            this.lblSteigung.TabIndex = 1;
            this.lblSteigung.Text = "Steigung: 0 %";
            // 
            // lblTitleCar
            // 
            this.lblTitleCar.AutoSize = true;
            this.lblTitleCar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.lblSubtitleWeight.Size = new System.Drawing.Size(50, 15);
            this.lblSubtitleWeight.TabIndex = 1;
            this.lblSubtitleWeight.Text = "Gewicht";
            // 
            // lblSubtitleHP
            // 
            this.lblSubtitleHP.AutoSize = true;
            this.lblSubtitleHP.Location = new System.Drawing.Point(3, 69);
            this.lblSubtitleHP.Name = "lblSubtitleHP";
            this.lblSubtitleHP.Size = new System.Drawing.Size(20, 15);
            this.lblSubtitleHP.TabIndex = 2;
            this.lblSubtitleHP.Text = "PS";
            // 
            // lblSubtitleGears
            // 
            this.lblSubtitleGears.AutoSize = true;
            this.lblSubtitleGears.Location = new System.Drawing.Point(3, 113);
            this.lblSubtitleGears.Name = "lblSubtitleGears";
            this.lblSubtitleGears.Size = new System.Drawing.Size(80, 15);
            this.lblSubtitleGears.TabIndex = 3;
            this.lblSubtitleGears.Text = "Anzahl Gänge";
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(3, 43);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(149, 23);
            this.tbWeight.TabIndex = 4;
            // 
            // tbHP
            // 
            this.tbHP.Location = new System.Drawing.Point(3, 87);
            this.tbHP.Name = "tbHP";
            this.tbHP.Size = new System.Drawing.Size(149, 23);
            this.tbHP.TabIndex = 5;
            // 
            // tbGears
            // 
            this.tbGears.Location = new System.Drawing.Point(3, 131);
            this.tbGears.Name = "tbGears";
            this.tbGears.Size = new System.Drawing.Size(149, 23);
            this.tbGears.TabIndex = 6;
            // 
            // btnSwitch
            // 
            this.btnSwitch.BackColor = System.Drawing.Color.Tomato;
            this.btnSwitch.BackgroundImage = global::Gangschaltung_PoC.Properties.Resources.onoff;
            this.btnSwitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSwitch.Location = new System.Drawing.Point(3, 160);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(132, 132);
            this.btnSwitch.TabIndex = 7;
            this.btnSwitch.UseVisualStyleBackColor = false;
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
            this.splitContainer3.Size = new System.Drawing.Size(568, 450);
            this.splitContainer3.SplitterDistance = 238;
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
            this.splitContainer4.Size = new System.Drawing.Size(568, 238);
            this.splitContainer4.SplitterDistance = 283;
            this.splitContainer4.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.numericUpDown1.Location = new System.Drawing.Point(0, 215);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(283, 23);
            this.numericUpDown1.TabIndex = 0;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.numericUpDown2.Location = new System.Drawing.Point(0, 215);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(281, 23);
            this.numericUpDown2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 215);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(281, 215);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "GUI";
            this.Text = "GUI";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.flpCar.ResumeLayout(false);
            this.flpCar.PerformLayout();
            this.flpEnvironment.ResumeLayout(false);
            this.flpEnvironment.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
    }
}