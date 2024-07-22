namespace ProyectoFinalProcesamientoImagenes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Form3());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Form2());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnFiltroVideo_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Form4());
        }
    }
}