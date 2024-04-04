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
            TimAnzeige.Enabled = false;
        }

        private void TimAnzeige_Tick(object sender, EventArgs e)
        {
            LblAnzeige.Text += "x";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelRot_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelBlau_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelGelb_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelGruen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CmdLetsPlay_Click(object sender, EventArgs e)
        {
            TimPlay.Enabled = true;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TimPlay_Tick(object sender, EventArgs e)
        {

            // Bewegt das rote Panel diagonal nach oben links.
            PanelRot.Location = new Point(PanelRot.Location.X - 10, PanelRot.Location.Y - 10);

            // Bewegt das blaue Panel diagonal nach oben rechts.
            PanelBlau.Location = new Point(PanelBlau.Location.X + 10, PanelBlau.Location.Y - 10);

            // Bewegt das gelbe Panel diagonal nach unten links.
            PanelGelb.Location = new Point(PanelGelb.Location.X - 10, PanelGelb.Location.Y + 10);

            // Bewegt das grüne Panel diagonal nach unten rechts.
            PanelGruen.Location = new Point(PanelGruen.Location.X + 10, PanelGruen.Location.Y + 10);
        }

        private void CmdLetsPause_Click(object sender, EventArgs e)
        {
            TimPlay.Enabled = false;
        }
    }
}
