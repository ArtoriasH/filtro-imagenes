namespace ProyectoFinalProcesamientoImagenes
{
    partial class Form2
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
            this.btnInvert = new System.Windows.Forms.Button();
            this.btnSolarize = new System.Windows.Forms.Button();
            this.btnBinary = new System.Windows.Forms.Button();
            this.btnSepia = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnGray = new System.Windows.Forms.Button();
            this.PBRed = new System.Windows.Forms.ProgressBar();
            this.PBGreen = new System.Windows.Forms.ProgressBar();
            this.PBBlue = new System.Windows.Forms.ProgressBar();
            this.LBHistograma = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInvert
            // 
            this.btnInvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnInvert.FlatAppearance.BorderSize = 0;
            this.btnInvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvert.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInvert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInvert.Location = new System.Drawing.Point(1310, 655);
            this.btnInvert.Name = "btnInvert";
            this.btnInvert.Size = new System.Drawing.Size(227, 45);
            this.btnInvert.TabIndex = 19;
            this.btnInvert.Text = "Invert";
            this.btnInvert.UseVisualStyleBackColor = false;
            this.btnInvert.Click += new System.EventHandler(this.btnInvert_Click);
            // 
            // btnSolarize
            // 
            this.btnSolarize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSolarize.FlatAppearance.BorderSize = 0;
            this.btnSolarize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolarize.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSolarize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSolarize.Location = new System.Drawing.Point(1046, 575);
            this.btnSolarize.Name = "btnSolarize";
            this.btnSolarize.Size = new System.Drawing.Size(227, 45);
            this.btnSolarize.TabIndex = 18;
            this.btnSolarize.Text = "Solarize";
            this.btnSolarize.UseVisualStyleBackColor = false;
            this.btnSolarize.Click += new System.EventHandler(this.btnSolarize_Click);
            // 
            // btnBinary
            // 
            this.btnBinary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBinary.FlatAppearance.BorderSize = 0;
            this.btnBinary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBinary.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBinary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBinary.Location = new System.Drawing.Point(1310, 575);
            this.btnBinary.Name = "btnBinary";
            this.btnBinary.Size = new System.Drawing.Size(227, 45);
            this.btnBinary.TabIndex = 17;
            this.btnBinary.Text = "Binary";
            this.btnBinary.UseVisualStyleBackColor = false;
            this.btnBinary.Click += new System.EventHandler(this.btnBinary_Click);
            // 
            // btnSepia
            // 
            this.btnSepia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSepia.FlatAppearance.BorderSize = 0;
            this.btnSepia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSepia.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSepia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSepia.Location = new System.Drawing.Point(1046, 655);
            this.btnSepia.Name = "btnSepia";
            this.btnSepia.Size = new System.Drawing.Size(227, 45);
            this.btnSepia.TabIndex = 16;
            this.btnSepia.Text = "Sepia";
            this.btnSepia.UseVisualStyleBackColor = false;
            this.btnSepia.Click += new System.EventHandler(this.btnSepia_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(64, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(918, 684);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(530, 844);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(227, 45);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnUpload.FlatAppearance.BorderSize = 0;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpload.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpload.Location = new System.Drawing.Point(258, 844);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(227, 45);
            this.btnUpload.TabIndex = 13;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnGray
            // 
            this.btnGray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnGray.FlatAppearance.BorderSize = 0;
            this.btnGray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGray.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGray.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGray.Location = new System.Drawing.Point(1178, 725);
            this.btnGray.Name = "btnGray";
            this.btnGray.Size = new System.Drawing.Size(227, 45);
            this.btnGray.TabIndex = 12;
            this.btnGray.Text = "Gray";
            this.btnGray.UseVisualStyleBackColor = false;
            this.btnGray.Click += new System.EventHandler(this.btnGray_Click);
            // 
            // PBRed
            // 
            this.PBRed.Location = new System.Drawing.Point(1297, 105);
            this.PBRed.Maximum = 255;
            this.PBRed.Name = "PBRed";
            this.PBRed.Size = new System.Drawing.Size(172, 23);
            this.PBRed.TabIndex = 20;
            // 
            // PBGreen
            // 
            this.PBGreen.Location = new System.Drawing.Point(1297, 149);
            this.PBGreen.Maximum = 255;
            this.PBGreen.Name = "PBGreen";
            this.PBGreen.Size = new System.Drawing.Size(172, 23);
            this.PBGreen.TabIndex = 21;
            // 
            // PBBlue
            // 
            this.PBBlue.Location = new System.Drawing.Point(1297, 202);
            this.PBBlue.Maximum = 255;
            this.PBBlue.Name = "PBBlue";
            this.PBBlue.Size = new System.Drawing.Size(172, 23);
            this.PBBlue.TabIndex = 22;
            // 
            // LBHistograma
            // 
            this.LBHistograma.AutoSize = true;
            this.LBHistograma.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBHistograma.Location = new System.Drawing.Point(1275, 25);
            this.LBHistograma.Name = "LBHistograma";
            this.LBHistograma.Size = new System.Drawing.Size(227, 54);
            this.LBHistograma.TabIndex = 23;
            this.LBHistograma.Text = "Histograma";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1228, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 28);
            this.label1.TabIndex = 24;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1218, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 28);
            this.label2.TabIndex = 25;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1228, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 28);
            this.label3.TabIndex = 26;
            this.label3.Text = "Blue";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1601, 971);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBHistograma);
            this.Controls.Add(this.PBBlue);
            this.Controls.Add(this.PBGreen);
            this.Controls.Add(this.PBRed);
            this.Controls.Add(this.btnInvert);
            this.Controls.Add(this.btnSolarize);
            this.Controls.Add(this.btnBinary);
            this.Controls.Add(this.btnSepia);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnGray);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnInvert;
        private Button btnSolarize;
        private Button btnBinary;
        private Button btnSepia;
        private PictureBox pictureBox1;
        private Button btnSave;
        private Button btnUpload;
        private Button btnGray;
        private ProgressBar PBRed;
        private ProgressBar PBGreen;
        private ProgressBar PBBlue;
        private Label LBHistograma;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}