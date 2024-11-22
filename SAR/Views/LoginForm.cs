using SAR.Views;

namespace SAR
{
    public partial class FrmLogin : Form
    {
        const int ERROR_PROVIDER_ICON_PADDING = 8;

        private static ErrorProvider errorProvider = new();
        private static List<Control> fieldsLogin = [];

        public FrmLogin()
        {
            InitializeComponent();

            fieldsLogin = [
                TxtStudentNumber,
                TxtPassword
            ];

            SetErrorIconPaddings(fieldsLogin);
        }

        private void Login()
        {
            ClearErrors(fieldsLogin);

            if (string.IsNullOrEmpty(TxtStudentNumber.Text))
            {
                SetError(TxtStudentNumber, "Enter student number here.");
                return;
            }

            if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                SetError(TxtPassword, "Enter your password.");
                return;
            }

            string studentNumber = TxtStudentNumber.Text.Trim();
            string password = TxtPassword.Text.Trim();

            if (IsAuthorized(studentNumber, password))
            {
                Hide();
                FrmMain form = new()
                {
                    StudentId = studentNumber
                };
                form.ShowDialog();
                Close();
            }
        }

        public bool IsAuthorized(string StudentNumber, string Password)
        {
            List<Control> LoginFields = [
                TxtStudentNumber,
                TxtPassword,
                BtnLogin
            ];

            using Data.Database.Context context = new();

            try
            {
                var account = context.StudentAccounts.Where(sa => sa.StudentId == StudentNumber).FirstOrDefault();

                if (account == null)
                {
                    SetError(TxtStudentNumber, "We can't find this account.");
                    return false;
                }

                if (Password != account.Password)
                {
                    SetError(TxtPassword, "Password is incorrect.");
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        // --- UTILITIES ---

        private static void SetErrorIconPaddings(List<Control> Fields)
        {
            foreach (Control Field in Fields)
            {
                if (Field as TextBox != null)
                {
                    errorProvider.SetIconPadding(Field, ERROR_PROVIDER_ICON_PADDING);
                }
            }
        }

        private static void ClearErrors(List<Control> Fields)
        {
            foreach (Control Field in Fields)
            {
                if (Field as TextBox != null)
                {
                    SetError(Field, "");
                }
            }
        }

        private static void SetError(Control control, string description = "Something is wrong here.")
        {
            errorProvider.SetError(control, description);
        }

        private void SetEnable(List<Control> Fields, bool EnableStatus)
        {
            foreach (Control Field in Fields)
            {
                Field.Enabled = EnableStatus;
            }
        }

        // --- EVENTS ---

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                Login();
            }
        }
    }
}
