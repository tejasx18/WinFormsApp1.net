namespace WinFormsApp1
{
    partial class Employee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtHRA = new TextBox();
            txtDA = new TextBox();
            txtTA = new TextBox();
            txtPF = new TextBox();
            txtGrossSalary = new TextBox();
            txtName = new TextBox();
            txtBasicSalary = new TextBox();
            txtId = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 79);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 134);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(145, 190);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 2;
            label3.Text = "Basic Salary";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(537, 263);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 3;
            label4.Text = "Gross Salary";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(539, 72);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 4;
            label5.Text = "HRA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(539, 117);
            label6.Name = "label6";
            label6.Size = new Size(30, 20);
            label6.TabIndex = 5;
            label6.Text = "DA";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(539, 162);
            label7.Name = "label7";
            label7.Size = new Size(26, 20);
            label7.TabIndex = 6;
            label7.Text = "TA";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(539, 207);
            label8.Name = "label8";
            label8.Size = new Size(24, 20);
            label8.TabIndex = 7;
            label8.Text = "PF";
            // 
            // txtHRA
            // 
            txtHRA.Location = new Point(652, 72);
            txtHRA.Name = "txtHRA";
            txtHRA.ReadOnly = true;
            txtHRA.Size = new Size(170, 27);
            txtHRA.TabIndex = 8;
            // 
            // txtDA
            // 
            txtDA.Location = new Point(652, 110);
            txtDA.Name = "txtDA";
            txtDA.ReadOnly = true;
            txtDA.Size = new Size(170, 27);
            txtDA.TabIndex = 9;
            // 
            // txtTA
            // 
            txtTA.Location = new Point(652, 155);
            txtTA.Name = "txtTA";
            txtTA.ReadOnly = true;
            txtTA.Size = new Size(170, 27);
            txtTA.TabIndex = 10;
            // 
            // txtPF
            // 
            txtPF.Location = new Point(652, 204);
            txtPF.Name = "txtPF";
            txtPF.ReadOnly = true;
            txtPF.Size = new Size(170, 27);
            txtPF.TabIndex = 11;
            // 
            // txtGrossSalary
            // 
            txtGrossSalary.Location = new Point(652, 263);
            txtGrossSalary.Name = "txtGrossSalary";
            txtGrossSalary.ReadOnly = true;
            txtGrossSalary.Size = new Size(170, 27);
            txtGrossSalary.TabIndex = 12;
            // 
            // txtName
            // 
            txtName.Location = new Point(242, 134);
            txtName.Name = "txtName";
            txtName.Size = new Size(220, 27);
            txtName.TabIndex = 13;
            // 
            // txtBasicSalary
            // 
            txtBasicSalary.Location = new Point(242, 190);
            txtBasicSalary.Name = "txtBasicSalary";
            txtBasicSalary.Size = new Size(220, 27);
            txtBasicSalary.TabIndex = 14;
            // 
            // txtId
            // 
            txtId.Location = new Point(242, 79);
            txtId.Name = "txtId";
            txtId.Size = new Size(220, 27);
            txtId.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(438, 399);
            button1.Name = "button1";
            button1.Size = new Size(125, 29);
            button1.TabIndex = 16;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 540);
            Controls.Add(button1);
            Controls.Add(txtId);
            Controls.Add(txtBasicSalary);
            Controls.Add(txtName);
            Controls.Add(txtGrossSalary);
            Controls.Add(txtPF);
            Controls.Add(txtTA);
            Controls.Add(txtDA);
            Controls.Add(txtHRA);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Employee";
            Text = "Employee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtHRA;
        private TextBox txtDA;
        private TextBox txtTA;
        private TextBox txtPF;
        private TextBox txtGrossSalary;
        private TextBox txtName;
        private TextBox txtBasicSalary;
        private TextBox txtId;
        private Button button1;
    }
}