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

            int tileSize = 50;


            for (int x = 0; x < row; x++)
            {
                for (int y = 0; y < col; y++)
                {
                    var tile = new Panel
                    {
                        Size = new Size(tileSize, tileSize),
                        Location = new Point(x * tileSize, y * tileSize),
                        BackColor = (x + y) % 2 == 0 ? Color.White : Color.Black
                    };

                    Controls.Add(tile);
                }
            }


            Size = new Size((row * tileSize) + 100, (col * tileSize) + 100);

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