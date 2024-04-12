namespace RougueLike
{
    public partial class Form1 : Form
    {
        private Map map = new Map(20, 10);
        private Player player = new Player(1, 1);
        private Size blockSize = new Size();

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.CreateGraphics().Clear(BackColor);
            var graphics = panel1.CreateGraphics();
            var pen = new Pen(Color.Black);
            var solidBrush = new SolidBrush(Color.Black);

            var rectSize = Math.Min(panel1.Width / map.Width, panel1.Height / map.Height);
            panel1.Size = new Size(map.Width * rectSize, map.Height * rectSize);
            panel1.Location = new Point(
                (ClientSize.Width - panel1.Width) / 2,
                (ClientSize.Height - panel1.Height) / 2);
            blockSize = new Size(rectSize, rectSize);

            for (var x = 0; x < map.Width; x++)
            {
                for (var y = 0; y < map.Height; y++)
                {
                    if (map.IsWall(x, y))
                    {
                        var rectangle = new Rectangle(x * rectSize, y * rectSize, rectSize, rectSize);
                        graphics.DrawRectangle(pen, rectangle);
                        graphics.FillRectangle(solidBrush, rectangle);
                    }
                }
            }

            PlayerCat_Paint(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void ButtonUp_Click(object sender, EventArgs e)
        {
            player.GoUp(map);
            PlayerCat.Invalidate();
        }

        private void ButtonDown_Click(object sender, EventArgs e)
        {
            player.GoDown(map);
            PlayerCat.Invalidate();
        }

        private void ButtonRight_Click(object sender, EventArgs e)
        {
            player.GoRight(map);
            PlayerCat.Invalidate();
        }

        private void ButtonLeft_Click(object sender, EventArgs e)
        {
            player.GoLeft(map);
            PlayerCat.Invalidate();
        }

        private void PlayerCat_Paint(object sender, PaintEventArgs e)
        {
            PlayerCat.Location = new Point(
                panel1.Location.X + player.X * blockSize.Width,
                panel1.Location.Y + player.Y * blockSize.Height);
            PlayerCat.Size = blockSize;
        }
    }
}