using Microsoft.WindowsAPICodePack.Dialogs;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ValorantMenuChanger
{
    public partial class ValorantMenuChanger : Form
    {
        public ValorantMenuChanger()
        {
            InitializeComponent();
        }

        private void ValorantMenuChanger_Load(object sender, EventArgs e)
        {
            if (Directory.Exists("C:\\Riot Games\\VALORANT"))
            {
                status.Text = "Detected";
                status.ForeColor = Color.Green;
                gamepath.Text = @"C:\\Riot Games\\VALORANT";
            }
            Properties.Settings.Default.path = "";
            Properties.Settings.Default.Save();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Downloads";
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                vidpath.Text = dialog.FileName;
                Properties.Settings.Default.path = dialog.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            File.Delete("C:\\Riot Games\\VALORANT\\live\\ShooterGame\\Content\\Movies\\Menu\\HomePage_Gekko.mp4"); //HomePage_Gekko
            File.Move(Properties.Settings.Default.path, "C:\\Riot Games\\VALORANT\\live\\ShooterGame\\Content\\Movies\\Menu\\HomePage_Gekko.mp4");
            File.Copy("C:\\Riot Games\\VALORANT\\live\\ShooterGame\\Content\\Movies\\Menu\\HomePage_Gekko.mp4", Properties.Settings.Default.path);

            File.Delete("C:\\Riot Games\\VALORANT\\live\\ShooterGame\\Content\\Movies\\Menu\\HomepageEp6A2.mp4"); //HomepageEp6A2
            File.Move(Properties.Settings.Default.path, "C:\\Riot Games\\VALORANT\\live\\ShooterGame\\Content\\Movies\\Menu\\HomepageEp6A2.mp4");
            File.Copy("C:\\Riot Games\\VALORANT\\live\\ShooterGame\\Content\\Movies\\Menu\\HomepageEp6A2.mp4", Properties.Settings.Default.path);

            File.Delete("C:\\Riot Games\\VALORANT\\live\\ShooterGame\\Content\\Movies\\Menu\\HomepageEp6A3_Arcade.mp4"); //HomepageEp6A3_Arcade
            File.Move(Properties.Settings.Default.path, "C:\\Riot Games\\VALORANT\\live\\ShooterGame\\Content\\Movies\\Menu\\HomepageEp6A3_Arcade.mp4");
            File.Copy("C:\\Riot Games\\VALORANT\\live\\ShooterGame\\Content\\Movies\\Menu\\HomepageEp6A3_Arcade.mp4", Properties.Settings.Default.path);

            File.Delete("C:\\Riot Games\\VALORANT\\live\\ShooterGame\\Content\\Movies\\Menu\\HomeScreeen_VCT23_Masters_Tokyo23.mp4"); //HomeScreeen_VCT23_Masters_Tokyo23
            File.Move(Properties.Settings.Default.path, "C:\\Riot Games\\VALORANT\\live\\ShooterGame\\Content\\Movies\\Menu\\HomeScreeen_VCT23_Masters_Tokyo23.mp4");
            File.Copy("C:\\Riot Games\\VALORANT\\live\\ShooterGame\\Content\\Movies\\Menu\\HomeScreeen_VCT23_Masters_Tokyo23.mp4", Properties.Settings.Default.path);

            File.Delete("C:\\Riot Games\\VALORANT\\live\\ShooterGame\\Content\\Movies\\Menu\\HomeScreenEp7_Deadlock.mp4"); //HomeScreenEp7_Deadlock
            File.Move(Properties.Settings.Default.path, "C:\\Riot Games\\VALORANT\\live\\ShooterGame\\Content\\Movies\\Menu\\HomeScreenEp7_Deadlock.mp4");
            File.Copy("C:\\Riot Games\\VALORANT\\live\\ShooterGame\\Content\\Movies\\Menu\\HomeScreenEp7_Deadlock.mp4", Properties.Settings.Default.path);

            MessageBox.Show("Swapped!");
        }
    }
}