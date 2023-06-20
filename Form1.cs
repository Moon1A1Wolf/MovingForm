namespace MovingForm
{
    public partial class Form1 : Form
    {
        private int temp = 0;
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public Form1()
        {
            InitializeComponent();
            timer.Interval = 25;
            timer.Tick += Timer_Tick;
            timer.Start();
            this.StartPosition = FormStartPosition.Manual;
            this.Height = 450;
            this.Width = 600;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            switch (temp)
            {
                case 0:
                    {
                        if (this.Left <= Screen.PrimaryScreen.Bounds.Width - this.Width)
                        {
                            this.Left += 10;
                        }
                        else
                        {
                            temp = 1;
                        }
                        break;
                    }
                case 1:
                    {
                        if (this.Top <= Screen.PrimaryScreen.Bounds.Height - this.Height)
                        {
                            this.Top += 10;
                        }
                        else
                        {
                            temp = 2;
                        }
                        break;
                    }
                case 2:
                    {
                        if (this.Left >= 0)
                        {
                            this.Left -= 10;
                        }
                        else
                        {
                            temp = 3;
                        }
                        break;
                    }
                case 3:
                    {
                        if (this.Top > 0)
                        {
                            this.Top -= 10;
                        }
                        else
                        {
                            temp = 0;
                        }
                        break;
                    }
            }
        }
    }
}
