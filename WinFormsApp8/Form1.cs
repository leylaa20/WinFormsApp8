namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        public Brush Brush { get; set; }
        Pen pen = new Pen(Color.Black, 2);

        Bitmap bitmap;
        Graphics graphics;

        bool startPaint;
        Point startPoint;
        int count, cX, cY, x, y;

        public Form1()
        {
            InitializeComponent();

            Brush = new SolidBrush(Color.Black);
            bitmap = new Bitmap(Width, Height);
            graphics = Graphics.FromImage(bitmap);

            BackgroundImage = bitmap;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            startPaint = false;
            x = startPoint.X - cX;
            y = startPoint.Y - cY;

            if (rb_pen.Checked)
            {
                if (count == 1)
                    graphics.DrawEllipse(pen, cX, cY, x, y);

                if (count == 2)
                    graphics.DrawRectangle(pen, cX, cY, x, y);

                if (count == 3)
                    graphics.DrawLine(pen, cX, cY, startPoint.X, startPoint.Y);
            }

            if (rb_brush.Checked)
            {
                if (count == 1)
                    graphics.FillEllipse(Brush, cX, cY, x, y);

                if (count == 2)
                    graphics.FillRectangle(Brush, cX, cY, x, y);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            startPaint = true;

            cX = e.X;
            cY = e.Y;
            x = e.X - cX;
            y = e.Y - cY;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Refresh();
            startPoint = e.Location;
        }

        private void btn_ellipse_Click(object sender, EventArgs e) => count = 1;
        private void btn_rectangle_Click(object sender, EventArgs e) => count = 2;
        private void btn_line_Click(object sender, EventArgs e) => count = 3;

        private void btn_color_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();

            btn_color.BackColor = colorDialog1.Color;
            pen.Color = colorDialog1.Color;
            Brush = new SolidBrush(colorDialog1.Color);
        }

    }
}