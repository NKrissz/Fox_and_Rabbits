using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Fox_And_Rabbits.Animals;


namespace Fox_And_Rabbits
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }



        private void Button1_Click(object sender, EventArgs e)
        {

            Simulation sim = new(int.Parse(tb_rows.Text), int.Parse(tb_cols.Text), 15);


            sim.StartGame(out Bitmap bitmap);


            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            tb_cols.Visible = false;
            tb_rows.Visible = false;
            bt_generate.Visible = false;


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


            // Display the bitmap in the PictureBox
            pictureBox1.Image = bitmap;
        }
    }
}