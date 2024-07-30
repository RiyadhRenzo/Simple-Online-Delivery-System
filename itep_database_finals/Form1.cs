using MySql.Data.MySqlClient;
namespace itep_database_finals
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

        private void button1_Click(object sender, EventArgs e) { 
        Form2 f2 = new Form2();
            this.Hide();
        f2.Show();}
        private void button2_Click(object sender, EventArgs e)        {
            Form3 f3 = new Form3();
            this.Hide();
                f3.Show();      
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Size = new Size(400, 400); // Set the desired width and height
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
