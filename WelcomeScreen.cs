using System;
using MaterialSkin;
using MaterialSkin.Controls;
namespace StudentApp
{
    public partial class WelcomeScreen : MaterialForm
    {
        public WelcomeScreen()
        {
            InitializeComponent();
            LoadingBar();
            toolStripLabelDate.Text = DateTime.Now.ToShortDateString();
            toolStripLabelHour.Text = DateTime.Now.ToString("hh:mm:ss tt");
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue900, Primary.Blue900, Primary.LightBlue500, Accent.LightGreen700, TextShade.WHITE);
        }


        private void LoadingBar()
        {
            timerLoadingBar.Start();
            if (ProgressBar.Value < 100)
            {
                ProgressBar.Value += 10;
            }
            else
            {
                timerLoadingBar.Stop();
            }
        }

        private void timer_Tick(object sender, System.EventArgs e)
        {
            LoadingBar();
        }

        private void btnStartApp_Click(object sender, EventArgs e)
        {
            // Alt Shortcut added in properties &s  
            Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowDialog();
            Close();
        }
    }
}
