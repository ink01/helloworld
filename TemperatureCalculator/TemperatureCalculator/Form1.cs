namespace TemperatureCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            //textBoxC.Text = "Hello";
            //get input dorm taxtbox
            string input = textBoxC.Text;
            
            //convert to f
            //f =c*9/5+32
            double c = Convert.ToDouble(input);
            double f = c * 9 / 5 + 32;
            
            //show input to textbox
            textBoxF.Text = f.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonConvert2_Click(object sender, EventArgs e)
        {
            //get input dorm taxtbox
            string input = textBoxF.Text;

            //convert to f
            //f =5/9(f-32)
            double f = Convert.ToDouble(input);
            double c = (f-32)* 5/9 ;

            //show input to textbox
            textBoxC.Text = c.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxC.Text = "";
            textBoxF.Text = "";
        }

        
    }
}