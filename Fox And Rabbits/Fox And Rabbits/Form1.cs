namespace Fox_And_Rabbits
{
    public partial class Form1 : Form
    {
        private const int gridSize = 10;
        private const int tileSize = 50; // Size of each tile in pixels
        public Form1()
        {
            InitializeComponent();
            InitializeGrid();
        }

        private void InitializeGrid()
        {
            for (int x = 0; x < gridSize; x++)
            {
                for (int y = 0; y < gridSize; y++)
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
        }
            private void Form1_Load(object sender, EventArgs e)
            {

            }
        }
    }