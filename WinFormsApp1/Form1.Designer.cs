namespace WinFormsApp1
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
            label1 = new Label();
            label2 = new Label();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            btnlogin = new Button();
            btnreset = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(363, 146);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "UserName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(363, 200);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // txtusername
            // 
            txtusername.Location = new Point(486, 146);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(198, 27);
            txtusername.TabIndex = 2;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(486, 197);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '$';
            txtpassword.Size = new Size(198, 27);
            txtpassword.TabIndex = 3;
            // 
            // btnlogin
            // 
            btnlogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnlogin.Location = new Point(380, 270);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(121, 37);
            btnlogin.TabIndex = 4;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // btnreset
            // 
            btnreset.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnreset.Location = new Point(533, 270);
            btnreset.Name = "btnreset";
            btnreset.Size = new Size(124, 37);
            btnreset.TabIndex = 5;
            btnreset.Text = "Reset";
            btnreset.UseVisualStyleBackColor = true;
            btnreset.Click += btnreset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 519);
            Controls.Add(btnreset);
            Controls.Add(btnlogin);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Login Form";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtusername;
        private TextBox txtpassword;
        private Button btnlogin;
        private Button btnreset;
    }
}
