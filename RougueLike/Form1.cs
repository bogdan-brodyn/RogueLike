namespace RougueLike
{
    public partial class Form1 : Form
    {
        private Map map = new Map(20, 10);
        private Point person = new Point(1, 1);
        public Form1()
        {
            InitializeComponent();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var graphics = panel1.CreateGraphics();
            var pen = new Pen(Color.Black);
            var solidBrush = new SolidBrush(Color.Black);

            var rectSize = Math.Min(panel1.Width / map.Width, panel1.Height / map.Height);
            panel1.Size = new Size(map.Width * rectSize, map.Height * rectSize);
            panel1.Location = new Point(
                (ClientSize.Width - panel1.Width) / 2,
                (ClientSize.Height - panel1.Height) / 2);

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

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}