using Backlogmanager.BLL;

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
            foreach (Game game in _gameContainer.GetTop())
            {
                AddGameToOverview(game);
            }
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
            label.Text = $"{game.Name} \n \n" + $"{game.Publisher}\n" + $"{game.Year_of_Release}";
            return label;
        }

        private FlowLayoutPanel GenerateFLP(Label label, PictureBox picture)
        {
            FlowLayoutPanel flpGamePanel = new FlowLayoutPanel();
            flpGamePanel.Width = 250;
            flpGamePanel.Height = 435;
            flpGamePanel.BackColor = Color.LightGray;
            flpGamePanel.Padding = new Padding(10);
            flpGamePanel.Margin = new Padding(10);
            flpGamePanel.AutoSize = false;
            flpGamePanel.FlowDirection = FlowDirection.TopDown;

            flpGamePanel.Controls.Add(picture);
            flpGamePanel.Controls.Add(label);

            return flpGamePanel;
        }

        private PictureBox GenerateImage(Game game)
        {
            PictureBox image = new PictureBox();
            image.Width = 225;
            image.Height = 300;
            image.SizeMode = PictureBoxSizeMode.StretchImage;
            image.ImageLocation = @"D:\Fontys School\Semester 2\VisualStudio_S2\Backlogmanager\Resources\placeholder.png";
            return image;
        }
    }
}
