namespace AutoSaveEditorr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "admin" && txtpass.Text == "123")
            {
                new FormMain().Show(); 
            }
            else
            {
                MessageBox.Show("username or password is incorrect!!!");
            }

        }
    }
}
