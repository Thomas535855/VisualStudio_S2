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

        
    }
}
