namespace ProyectoFinalProcesamientoImagenes
{
    partial class Form4
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
            btnSepiaC = new Button();
            btnPolaroid = new Button();
            btnSepia = new Button();
            pictureBox1 = new PictureBox();
            btnPlayVideo = new Button();
            btnUploadVideo = new Button();
            btnGray = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSepiaC
            // 
            btnSepiaC.BackColor = Color.FromArgb(192, 192, 255);
            btnSepiaC.FlatAppearance.BorderSize = 0;
            btnSepiaC.FlatStyle = FlatStyle.Flat;
            btnSepiaC.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnSepiaC.ForeColor = SystemColors.ButtonHighlight;
            btnSepiaC.Location = new Point(1302, 636);
            btnSepiaC.Name = "btnSepiaC";
            btnSepiaC.Size = new Size(227, 45);
            btnSepiaC.TabIndex = 27;
            btnSepiaC.Text = "SepiaC";
            btnSepiaC.UseVisualStyleBackColor = false;
            btnSepiaC.Click += btnSepiaC_Click;
            // 
            // btnPolaroid
            // 
            btnPolaroid.BackColor = Color.FromArgb(192, 192, 255);
            btnPolaroid.FlatAppearance.BorderSize = 0;
            btnPolaroid.FlatStyle = FlatStyle.Flat;
            btnPolaroid.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnPolaroid.ForeColor = SystemColors.ButtonHighlight;
            btnPolaroid.Location = new Point(1302, 556);
            btnPolaroid.Name = "btnPolaroid";
            btnPolaroid.Size = new Size(227, 45);
            btnPolaroid.TabIndex = 25;
            btnPolaroid.Text = "Polaroid";
            btnPolaroid.UseVisualStyleBackColor = false;
            btnPolaroid.Click += btnPolaroid_Click;
            // 
            // btnSepia
            // 
            btnSepia.BackColor = Color.FromArgb(192, 192, 255);
            btnSepia.FlatAppearance.BorderSize = 0;
            btnSepia.FlatStyle = FlatStyle.Flat;
            btnSepia.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnSepia.ForeColor = SystemColors.ButtonHighlight;
            btnSepia.Location = new Point(1038, 636);
            btnSepia.Name = "btnSepia";
            btnSepia.Size = new Size(227, 45);
            btnSepia.TabIndex = 24;
            btnSepia.Text = "Sepia";
            btnSepia.UseVisualStyleBackColor = false;
            btnSepia.Click += btnSepia_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(56, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(918, 684);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // btnPlayVideo
            // 
            btnPlayVideo.BackColor = Color.FromArgb(192, 192, 255);
            btnPlayVideo.FlatAppearance.BorderSize = 0;
            btnPlayVideo.FlatStyle = FlatStyle.Flat;
            btnPlayVideo.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlayVideo.ForeColor = SystemColors.ButtonHighlight;
            btnPlayVideo.Location = new Point(522, 825);
            btnPlayVideo.Name = "btnPlayVideo";
            btnPlayVideo.Size = new Size(227, 45);
            btnPlayVideo.TabIndex = 22;
            btnPlayVideo.Text = "Play Video";
            btnPlayVideo.UseVisualStyleBackColor = false;
            btnPlayVideo.Click += btnPlayVideo_Click;
            // 
            // btnUploadVideo
            // 
            btnUploadVideo.BackColor = Color.FromArgb(192, 192, 255);
            btnUploadVideo.FlatAppearance.BorderSize = 0;
            btnUploadVideo.FlatStyle = FlatStyle.Flat;
            btnUploadVideo.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnUploadVideo.ForeColor = SystemColors.ButtonHighlight;
            btnUploadVideo.Location = new Point(250, 825);
            btnUploadVideo.Name = "btnUploadVideo";
            btnUploadVideo.Size = new Size(227, 45);
            btnUploadVideo.TabIndex = 21;
            btnUploadVideo.Text = "Upload Video";
            btnUploadVideo.UseVisualStyleBackColor = false;
            btnUploadVideo.Click += btnUploadVideo_Click;
            // 
            // btnGray
            // 
            btnGray.BackColor = Color.FromArgb(192, 192, 255);
            btnGray.FlatAppearance.BorderSize = 0;
            btnGray.FlatStyle = FlatStyle.Flat;
            btnGray.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnGray.ForeColor = SystemColors.ButtonHighlight;
            btnGray.Location = new Point(1038, 556);
            btnGray.Name = "btnGray";
            btnGray.Size = new Size(227, 45);
            btnGray.TabIndex = 20;
            btnGray.Text = "Gray";
            btnGray.UseVisualStyleBackColor = false;
            btnGray.Click += btnGray_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1585, 932);
            Controls.Add(btnSepiaC);
            Controls.Add(btnPolaroid);
            Controls.Add(btnSepia);
            Controls.Add(pictureBox1);
            Controls.Add(btnPlayVideo);
            Controls.Add(btnUploadVideo);
            Controls.Add(btnGray);
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSepiaC;
        private Button btnPolaroid;
        private Button btnSepia;
        private PictureBox pictureBox1;
        private Button btnPlayVideo;
        private Button btnUploadVideo;
        private Button btnGray;
    }
}