namespace inst_uygulama_1
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

        private void btnno_MouseHover(object sender, EventArgs e)
        {
            Random random = new Random();
            int x = random.Next(60, 640);
            int y = random.Next(60, 640);
            btnno.Location = new Point(x, y);

        }

        private void btnyes_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            button13.Visible = true;
            button14.Visible = true;
            button15.Visible = true;
            button16.Visible = true;
            button17.Visible = true;
            button18.Visible = true;
            button19.Visible = true;
            button20.Visible = true;
            button21.Visible = true;
            button22.Visible = true;
            button23.Visible = true;
            button24.Visible = true;
            button25.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            label2.Text = "SEN MÜKEMMEL BÝR YAZILIMCISIN :):)";
            btnno.Visible = false;


        }


    }
}
