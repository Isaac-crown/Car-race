namespace Car_race
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
        
        }   

      

        void moveline(int speed)
        {
           if(pictureBox1.Top >= 500)
            {pictureBox1.Top = 0;}
            else { pictureBox1.Top += speed;}


            if (pictureBox3.Top >= 500)
            { pictureBox3.Top = 0; }
            else { pictureBox3.Top += speed; }


            if (pictureBox4.Top >= 500)
            { pictureBox4.Top = 0; }
            else { pictureBox4.Top += speed; }


            if (pictureBox5.Top >= 500)
            { pictureBox5.Top = 0; }
            else { pictureBox5.Top += speed; }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }


        int gamespeed = 0;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                if(car.Left>0)
                car.Left += -8;
            }
            if(e.KeyCode == Keys.Right)
            {
                if(car.Right<350)
                car.Left += 8;

            }

            if(e.KeyCode == Keys.Up)
            {
                if(gamespeed < 21)
                {
                    gamespeed++;
                }
            }

            if(e.KeyCode == Keys.Down)
            {
                if(gamespeed > 0)
                {
                    gamespeed--;
                }
            }
        }

      

     
    }
}