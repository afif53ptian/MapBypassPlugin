using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Grimoire.Game;
using Grimoire.Networking;

namespace ExamplePacketPlugin
{
    public partial class Main : Form
    {
        public static Main Instance { get; } = new Main();

        public Main()
        {
            InitializeComponent();
        }

        public JoinHandler Handler { get; } = new JoinHandler();

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private async void btnBypass_Click(object sender, EventArgs e)
        {
            if (Player.IsLoggedIn)
            {
                btnStop.Enabled = true;
                btnBypass.Enabled = false;
                int delay = (int)numDelay.Value;
                int minIValue = (int)fromIValue.Value;
                int minIIndex = (int)fromIIndex.Value;
                int maxIValue = (int)toIValue.Value;
                int maxIIndex = (int)toIIndex.Value;

                for (int i = minIIndex; i <= maxIIndex; i++)
                {
                    if (!Player.IsLoggedIn || !btnStop.Enabled)
                        break;
                    for (int j = minIValue; j <= maxIValue; j++)
                    {
                        if (!Player.IsLoggedIn || !btnStop.Enabled)
                            break;
                        Proxy.Instance.SendToClient("{\"t\":\"xt\",\"b\":{\"r\":-1,\"o\":" +
                            "{\"cmd\":\"updateQuest\",\"iValue\":" + j + ",\"iIndex\":" + i + "}}}");
                        await Task.Delay(delay);
                        lbLog.Text = $"(iValue: {j}/{maxIValue}, iIndex: {i}/{maxIIndex})";
                    }
                }
                btnStop.Enabled = false;
                btnBypass.Enabled = true;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
        }
    }
}
