namespace TimerTick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdStartX_Click(object sender, EventArgs e)
        {
            TimAnzeige.Enabled = true;
        }

        private void CmdStopX_Click(object sender, EventArgs e)
        {
            TimAnzeige.Enabled=false;
        }

        private void TimAnzeige_Tick(object sender, EventArgs e)
        {
            LblAnzeige.Text += "x";
        }
    }
}
