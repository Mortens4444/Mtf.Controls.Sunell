using Mtf.MessageBoxes;

namespace Mtf.Controls.Sunell.Test
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                sunellVideoWindow.Connect("192.168.0.120", 30001, "admin", "admin");
            }
            catch (Exception ex)
            {
                ErrorBox.Show(ex);
            }
        }

        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            if (sunellVideoWindow.IsConnected)
            {
                sunellVideoWindow.Disconnect();
            }
        }
    }
}
