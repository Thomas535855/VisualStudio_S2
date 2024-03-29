using Backlogmanager.BLL;

namespace Backlogmanager
{
    public partial class RegisterForm : Form
    {
        private UserContainer _userContainer;
        private User _user;
        public RegisterForm()
        {
            InitializeComponent();
            _userContainer = new UserContainer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateInfo())
            {
                string name = tboxUsername.Text;
                string email = tboxEmail.Text;
                string password = tboxPassword.Text;

                User user = new User(name, email, 0, password);
                bool succes = _userContainer.Add(user);
                if (succes)
                {
                    MessageBox.Show("Succes");
                }
                else { MessageBox.Show("Failed"); }
            }
            else { MessageBox.Show("Please fill out all fields"); }
            
        }

        private bool ValidateInfo()
        {
            bool succes = true;
            if (string.IsNullOrEmpty(tboxUsername.Text)) { succes = false; }
            else if (string.IsNullOrEmpty(tboxEmail.Text)) { succes = false; }
            else if (string.IsNullOrEmpty(tboxPassword.Text)) { succes = false; }
            return succes;
        }
    }
}
