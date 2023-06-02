using Repository.Models;

namespace PE_SE172159
{
    public partial class Form1 : Form
    {
        BankAccountTypeContext context;
        public Form1()
        {
            InitializeComponent();
            txt_pwd.PasswordChar = '*';
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_user.Text;
            string pwd = txt_pwd.Text;

            if (username == "" || pwd == "")
            {
                MessageBox.Show("UserAccount or Password is not empty!!!", "Message", MessageBoxButtons.OK);
            }
            else
            {
                context = new BankAccountTypeContext();
                var account = context.Users.FirstOrDefault(x => x.UserId == username && x.Password == pwd);
                if (account == null)
                {
                    MessageBox.Show("UserAccount or Password is not correct!!", "Message", MessageBoxButtons.OK);
                }
                else if (account != null && account.UserRole == 1)
                {
                    Management management = new Management();
                    this.Hide();
                    management.Show();
                }
                else
                {
                    MessageBox.Show("You are not allowed to access this function.", "Message", MessageBoxButtons.OK);
                }
            }
        }
    }
}