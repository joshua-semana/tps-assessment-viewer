using Microsoft.EntityFrameworkCore;

namespace SAR
{
    public partial class frmLogin : Form
    {
        const int ERROR_PROVIDER_ICON_PADDING = 8;

        private static ErrorProvider err = new();
        private static List<Control> fieldsLogin = [];

        public frmLogin()
        {
            InitializeComponent();

            fieldsLogin = [
                TxtStudentNumber,
                TxtPassword
            ];

            SetErrorIconPaddings(fieldsLogin);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            ClearErrors(fieldsLogin);

            if (string.IsNullOrEmpty(TxtStudentNumber.Text))
            {
                err.SetError(TxtStudentNumber, "Enter your student number.");
                return;
            }

            if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                err.SetError(TxtPassword, "Enter your password.");
                return;
            }

            string studentNumber = TxtStudentNumber.Text.Trim();
            string password = TxtPassword.Text.Trim();

            if (IsAuthorized(studentNumber, password))
            {
                // Go To Main Page
            }
        }

        public bool IsAuthorized(string StudentNumber, string Password)
        {
            using Data.Database.Context context = new();

            var account = context.StudentAccounts.Where(sa => sa.StudentId == StudentNumber).FirstOrDefault();

            if (account == null)
            {
                err.SetError(TxtStudentNumber, "We can't find this account.");
                return false;
            }

            if (Password != account.Password)
            {
                err.SetError(TxtPassword, "Password is incorrect.");
                return false;
            }

            return true;
        }

        // --- UTILITIES ---

        private static void SetErrorIconPaddings(List<Control> Fields)
        {
            foreach (Control Control in Fields)
            {
                if (Control as TextBox != null)
                {
                    err.SetIconPadding(Control, ERROR_PROVIDER_ICON_PADDING);
                }
            }
        }

        private static void ClearErrors(List<Control> Fields)
        {
            foreach (Control Control in Fields)
            {
                if (Control as TextBox != null)
                {
                    err.SetError(Control, "");
                }
            }
        }
    }
}
