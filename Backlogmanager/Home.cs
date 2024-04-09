using Backlogmanager.ASP;

namespace Backlogmanager
{
    public partial class Home : Form
    {
        public Form? _activeForm;
        private Button? _activeButton;
        public Home()
        {
            InitializeComponent();
            OpenChildForm(new OverviewForm(this), btnHome);
            btnHome.BackColor = Color.FromArgb(166, 166, 166);
            btnRegister.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void OpenChildForm(Form childForm, Button button)
        {
            if (_activeForm != null)
            { _activeForm.Close(); }

            ActivateButton(button);

            _activeForm = childForm;
            _activeForm.TopLevel = false;
            _activeForm.FormBorderStyle = FormBorderStyle.None;
            _activeForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void OpenChildForm(Form childForm)
        {
            if (_activeForm != null)
            { _activeForm.Close(); }

            _activeForm = childForm;
            _activeForm.TopLevel = false;
            _activeForm.FormBorderStyle = FormBorderStyle.None;
            _activeForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ActivateButton(Button button)
        {
            if (button == _activeButton)
            { return; }
            DisableButton();
            _activeButton = button;
            _activeButton.BackColor = Color.FromArgb(166, 166, 166);
        }

        private void DisableButton()
        {
            if (_activeButton == null)
            { return; }
            _activeButton.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new OverviewForm(this), (Button)sender);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RegisterForm(), (Button)sender);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProfileForm(), (Button)sender);
        }
    }
}
