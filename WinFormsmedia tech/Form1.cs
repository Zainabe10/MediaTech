namespace WinFormsmedia_tech
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Panel headerPanel = new Panel();
            headerPanel.Dock = DockStyle.Fill;
            headerPanel.Height = 60;
            headerPanel.BackColor = Color.LightGray;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Label title = new Label();
            title.Text = "Media_Tech";
            title.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            title.AutoSize = true;
            title.Location = new Point(10, 20);



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void SeConnecter(object sender, EventArgs e)
        {

        }
    }
}
