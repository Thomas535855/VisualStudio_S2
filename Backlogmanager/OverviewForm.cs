using Backlogmanager.BLL;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Backlogmanager
{

    public partial class OverviewForm : Form
    {
        private Home _home;
        private GameContainer _gameContainer;

        public OverviewForm(Home home)
        {
            InitializeComponent();
            _home = home;
            _gameContainer = new GameContainer();
        }

        private void OverviewForm_Load(object sender, EventArgs e)
        {
            Game test = new Game("Name", "Test", 4, "fg", "Fdf", 6);
            bool succes = _gameContainer.Add(test);
            if (succes)
            {
                Game gme = _gameContainer.GetById(test.GameId);
                AddGameToOverview(gme);
            }
            else { MessageBox.Show("Failed");  }
            
        }
    

        private void AddGameToOverview(Game game)
        {
            Label label = GenerateLabel(game);
            PictureBox pictureBox = GenerateImage(game);
            FlowLayoutPanel flpGamePanel = GenerateFLP(label, pictureBox);
            flpGameDisplay.Controls.Add(flpGamePanel);
        }

        private Label GenerateLabel(Game game)
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Text = $"{game.Name} \n" + $"{game.Year_of_Release}";
            return label;
        }

        private FlowLayoutPanel GenerateFLP(Label label, PictureBox picture)
        {
            FlowLayoutPanel flpGamePanel = new FlowLayoutPanel();
            flpGamePanel.Width = 325;
            flpGamePanel.Height = 380;
            flpGamePanel.BackColor = Color.LightGray;
            flpGamePanel.Padding = new Padding(10);
            flpGamePanel.Margin = new Padding(10);
            flpGamePanel.AutoSize = true;
            flpGamePanel.FlowDirection = FlowDirection.TopDown;

            flpGamePanel.Controls.Add(label);

            return flpGamePanel;
        }

        private PictureBox GenerateImage(Game game)
        {
            PictureBox image = new PictureBox();
            image.Width = 225;
            image.Height = 300;
            image.SizeMode = PictureBoxSizeMode.StretchImage;
            image.Image = Image.FromFile("D:\\Fontys School\\Semester 2\\VisualStudio_S2\\Backlogmanager\\Images\\placeholder.png");
            return image;
        }
    }
}
