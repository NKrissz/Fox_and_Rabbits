namespace Fox_And_Rabbits
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.None;

        }

        private void Btn_generate_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            Simulation sim = new(int.Parse(tb_rows.Text), int.Parse(tb_cols.Text), 15);
            sim.StartGame(out Bitmap bitmap);

            // Calculate the required size for the PictureBox based on the content
            int pictureBoxWidth = sim.X * sim.CellSize;
            int pictureBoxHeight = sim.Y * sim.CellSize;

            // Set the PictureBox size to fit the content
            pictureBox1.Size = new Size(pictureBoxWidth, pictureBoxHeight);


            // Calculate the center position of the form
            int centerX = (ClientSize.Width - pictureBox1.Width) / 2;
            int centerY = (ClientSize.Height - pictureBox1.Height) / 2;

            // Set the PictureBox's location to center it on the form
            pictureBox1.Location = new Point(centerX, centerY);



            pictureBox1.Image = bitmap;

            sim.PassageOfTime(bitmap);

            pictureBox1.Image = bitmap;



            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            tb_cols.Visible = false;
            tb_rows.Visible = false;
            bt_generate.Visible = false;


            lbl_RabbitCount.Visible = true;
            lbl_RabbitCount.Text = $"A nyuak száma: {sim.RabbitCounter()}";
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}