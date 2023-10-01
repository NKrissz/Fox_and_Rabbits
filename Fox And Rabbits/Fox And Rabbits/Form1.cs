namespace Fox_And_Rabbits
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();



        }

        private void InitializeGrid()
        {
            int row = int.Parse(tb_rows.Text);
            int col = int.Parse(tb_cols.Text);
            Random rnd = new Random();

            int tileSize = 15; //size in pixel


            for (int x = 0; x < row; x++)
            {
                for (int y = 0; y < col; y++)
                {
                    var tile = new Panel
                    {
                        Size = new Size(tileSize, tileSize),
                        Location = new Point(x * tileSize, y * tileSize),
                    };

                    switch (rnd.Next(1, 101))
                    {
                        case int n when (n >= 1 && n <= 29):
                            tile.BackColor = Color.LightGreen;
                            break;
                        case int n when (n >= 30 && n <= 59):
                            tile.BackColor = Color.Green;
                            break;
                        case int n when (n >= 60 && n <= 84):
                            tile.BackColor = Color.DarkGreen;
                            break;
                        case int n when (n >= 85 && n <= 94):
                            tile.BackColor = Color.DarkSlateGray;
                            break;
                        case int n when (n >= 95 && n <= 100):
                            tile.BackColor = Color.Red;
                            break;
                        default:
                            tile.BackColor = Color.RosyBrown;
                            break;
                    }

                    Controls.Add(tile);
                }
            }


            Size = new Size((row * tileSize), (col * tileSize) + 40);

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            InitializeGrid();
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            tb_cols.Visible = false;
            tb_rows.Visible = false;
            bt_generate.Visible = false;

        }
    }
}