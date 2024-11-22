namespace SAR.Views
{
    public partial class FrmMain : Form
    {
        public string StudentId { get; set; } = "";

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            using Data.Database.Context context = new();

            try
            {
                string firstName = context.Students.Where(s => s.StudentId == StudentId).First().FirstName;
                string middleName = context.Students.Where(s => s.StudentId == StudentId).First().MiddleName;
                string lastName = context.Students.Where(s => s.StudentId == StudentId).First().LastName;
                string fullName = $"{firstName} {middleName} {lastName}" ?? "Student Name";
                LblStudentName.Text = fullName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void LogOut()
        {
            Hide();
            FrmLogin form = new();
            form.ShowDialog();
            Close();
        }

        // --- EVENTS ---
        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            LogOut();
        }
    }
}
