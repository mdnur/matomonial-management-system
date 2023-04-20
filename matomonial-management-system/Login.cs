using System;
using System.Windows.Forms;

namespace matomonial_management_system
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void singup_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SingUP().Show();

        }

        private void forgetbox_Load(object sender, EventArgs e)
        {

        }
    }
}
