using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace AutoSaveEditorr
{
    public partial class FormMain : Form
    {
        private string? currentFilePath = null;
        private readonly string autosaveTempPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "autosave.txt");
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentFilePath))
            {
                File.WriteAllText(currentFilePath, txtcontect.Text);
                MessageBox.Show("ذخیره انجام شد!");
            }
            else
            {
                using (SaveFileDialog saveFile = new SaveFileDialog())
                {
                    saveFile.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        currentFilePath = saveFile.FileName;
                        File.WriteAllText(currentFilePath, txtcontect.Text);
                        MessageBox.Show("ذخیره انجام شد!");
                    }
                }
            }
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveAsFile = new SaveFileDialog())
            {
                saveAsFile.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (saveAsFile.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = saveAsFile.FileName;
                    File.WriteAllText(currentFilePath, txtcontect.Text);
                    this.Text = Path.GetFileName(currentFilePath);
                    MessageBox.Show("فایل با نام جدید ذخیره شد!");
                }
            }
        }
        private void SaveData()
        {
            try
            {
                if (!string.IsNullOrEmpty(currentFilePath))
                    File.WriteAllText(currentFilePath, txtcontect.Text);
                else
                    File.WriteAllText(autosaveTempPath, txtcontect.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Autosave failed: " + ex.Message);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            SaveData();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            timer1.Interval = 30000;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }


        public FormMain()
        {
            InitializeComponent();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.KeyPreview = true;
            this.KeyDown += FormMain_KeyDown;

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtcontect.Clear();
            MessageBox.Show("ایتم جدید اضافه شد!");

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Filter = "Text file (*.txt)|*.txt|All Files (*.*)|*.*";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    string content = File.ReadAllText(openFile.FileName);
                    txtcontect.Text = content;
                    this.Text = Path.GetFileName(openFile.FileName);
                }
            }

        }




        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("آیا می‌خواهید خارج شوید؟", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }


        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtcontect.SelectedText != "")
                txtcontect.Cut();

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtcontect.SelectedText != "")
                txtcontect.Copy();

        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtcontect.Paste();

        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtcontect.SelectAll();

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtcontect.Clear();

        }

        private void txtcontect_TextChanged(object sender, EventArgs e)
        {

        }
        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                saveToolStripMenuItem_Click(sender, e);
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.O)
            {
                openToolStripMenuItem_Click(sender, e);
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.N)
            {
                newToolStripMenuItem_Click(sender, e);
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.X)
            {
                cutToolStripMenuItem_Click(sender, e);
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.C)
            {
                copyToolStripMenuItem_Click(sender, e);
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.V)
            {
                pasteToolStripMenuItem_Click(sender, e);
                e.SuppressKeyPress = true;

            }
            else if (e.Control && e.KeyCode == Keys.Q)
            {
                exitToolStripMenuItem_Click(sender, e); 
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.D)
            {
                clearToolStripMenuItem_Click(sender, e); 
                e.SuppressKeyPress = true;
                 }
            }

    }
}
