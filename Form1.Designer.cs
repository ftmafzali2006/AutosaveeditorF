namespace AutoSaveEditorr
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtuser = new TextBox();
            txtpass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnlogin = new Button();
            SuspendLayout();
            // 
            // txtuser
            // 
            txtuser.BackColor = SystemColors.ActiveBorder;
            txtuser.Location = new Point(164, 104);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(199, 31);
            txtuser.TabIndex = 0;
            // 
            // txtpass
            // 
            txtpass.BackColor = SystemColors.AppWorkspace;
            txtpass.Location = new Point(164, 148);
            txtpass.Name = "txtpass";
            txtpass.PasswordChar = '*';
            txtpass.Size = new Size(199, 31);
            txtpass.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(369, 104);
            label1.Name = "label1";
            label1.Size = new Size(110, 25);
            label1.TabIndex = 2;
            label1.Text = " : Username ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(369, 148);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 3;
            label2.Text = ": Password";
            // 
            // btnlogin
            // 
            btnlogin.BackColor = SystemColors.ControlDark;
            btnlogin.Location = new Point(202, 217);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(112, 54);
            btnlogin.TabIndex = 4;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(489, 450);
            Controls.Add(btnlogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtpass);
            Controls.Add(txtuser);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtuser;
        private TextBox txtpass;
        private Label label1;
        private Label label2;
        private Button btnlogin;
    }
}
