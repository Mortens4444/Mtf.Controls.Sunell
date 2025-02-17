using Mtf.MessageBoxes;

namespace Mtf.Controls.Sunell.Test
{
    public partial class MainFormLegacy : Form
    {
        public MainFormLegacy()
        {
            InitializeComponent();
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                sunellVideoWindow.Connect("192.168.0.201", 30001, "admin", "Tibi2025");
            }
            catch (Exception ex)
            {
                ErrorBox.Show(ex);
            }
        }

        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (sunellVideoWindow.IsConnected)
                {
                    sunellVideoWindow.Disconnect();
                }
            }
            catch (Exception ex)
            {
                ErrorBox.Show(ex);
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            btnConnect.PerformClick();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnDisconnect.PerformClick();
        }
    }
}
