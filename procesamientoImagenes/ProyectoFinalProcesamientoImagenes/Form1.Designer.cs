namespace ProyectoFinalProcesamientoImagenes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnFiltroVideo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVideoFilter = new System.Windows.Forms.Button();
            this.btnImageFilter = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.btnFiltroVideo);
            this.panelSideMenu.Controls.Add(this.label1);
            this.panelSideMenu.Controls.Add(this.btnVideoFilter);
            this.panelSideMenu.Controls.Add(this.btnImageFilter);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 971);
            this.panelSideMenu.TabIndex = 0;
            // 
            // btnFiltroVideo
            // 
            this.btnFiltroVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnFiltroVideo.FlatAppearance.BorderSize = 0;
            this.btnFiltroVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroVideo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFiltroVideo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnFiltroVideo.Location = new System.Drawing.Point(0, 326);
            this.btnFiltroVideo.Name = "btnFiltroVideo";
            this.btnFiltroVideo.Size = new System.Drawing.Size(250, 55);
            this.btnFiltroVideo.TabIndex = 4;
            this.btnFiltroVideo.Text = "Video Filter";
            this.btnFiltroVideo.UseVisualStyleBackColor = false;
            this.btnFiltroVideo.Click += new System.EventHandler(this.btnFiltroVideo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(9, 894);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Procesamiento Imagenes";
            // 
            // btnVideoFilter
            // 
            this.btnVideoFilter.BackColor = System.Drawing.Color.White;
            this.btnVideoFilter.FlatAppearance.BorderSize = 0;
            this.btnVideoFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVideoFilter.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVideoFilter.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnVideoFilter.Location = new System.Drawing.Point(0, 404);
            this.btnVideoFilter.Name = "btnVideoFilter";
            this.btnVideoFilter.Size = new System.Drawing.Size(250, 55);
            this.btnVideoFilter.TabIndex = 2;
            this.btnVideoFilter.Text = "Video";
            this.btnVideoFilter.UseVisualStyleBackColor = false;
            this.btnVideoFilter.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnImageFilter
            // 
            this.btnImageFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnImageFilter.FlatAppearance.BorderSize = 0;
            this.btnImageFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImageFilter.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnImageFilter.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnImageFilter.Location = new System.Drawing.Point(0, 250);
            this.btnImageFilter.Name = "btnImageFilter";
            this.btnImageFilter.Size = new System.Drawing.Size(250, 55);
            this.btnImageFilter.TabIndex = 1;
            this.btnImageFilter.Text = "Image Filter";
            this.btnImageFilter.UseVisualStyleBackColor = false;
            this.btnImageFilter.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 194);
            this.panelLogo.TabIndex = 0;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Location = new System.Drawing.Point(245, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1601, 971);
            this.panelChildForm.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1846, 971);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelSideMenu.ResumeLayout(false);
            this.panelSideMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelSideMenu;
        private Button btnVideoFilter;
        private Button btnImageFilter;
        private Panel panelLogo;
        private Label label1;
        private Panel panelChildForm;
        private Button btnFiltroVideo;
    }
}