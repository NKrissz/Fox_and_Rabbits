using Fox_And_Rabbits.Animals;
using Fox_And_Rabbits.Grass;

namespace Fox_And_Rabbits
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.None;

        }

        private async void Btn_generate_Click(object sender, EventArgs e)
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

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            tb_cols.Visible = false;
            tb_rows.Visible = false;
            bt_generate.Visible = false;



            lbl_rounds.Visible = true;
            lbl_RabbitCount.Visible = true;
            int rounds = 0;



            while (sim.RabbitCounter() != 0)
            {
                for (int i = 0; i < sim.Grid.GetLength(0); i++)
                {
                    for (int j = 0; j < sim.Grid.GetLength(1); j++)
                    {
                        sim.TenderGrassActions(i, j);
                        pictureBox1.Image = bitmap;

                        sim.InitiativeGrassActions(i, j);
                        pictureBox1.Image = bitmap;

                        sim.RabbitActions(i, j);
                        pictureBox1.Image = bitmap;

                        sim.FoxActions(i, j);

                        pictureBox1.Image = bitmap;

                        
                    }
                }
                sim.UpdateGrid(bitmap);
                pictureBox1.Image = bitmap;
                await Task.Delay(1000);
               
                sim.ResetStats();


                rounds++;
                lbl_rounds.Text = $"Eltelt k�r�k: {rounds}";
                lbl_RabbitCount.Text = $"A nyulak sz�ma: {sim.RabbitCounter()}";
            }

          


        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}