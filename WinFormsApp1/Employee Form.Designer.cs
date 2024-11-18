namespace WinFormsApp1
{
    partial class Employee_Form
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
            btnClear = new Button();
            btnJSONR = new Button();
            btnSOAPR = new Button();
            btnXMLR = new Button();
            btnBinaryR = new Button();
            btnJSONW = new Button();
            btnSOAPW = new Button();
            btnXMLW = new Button();
            btnBinaryW = new Button();
            txtSalary = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.Location = new Point(581, 35);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 29;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnJSONR
            // 
            btnJSONR.Location = new Point(308, 386);
            btnJSONR.Name = "btnJSONR";
            btnJSONR.Size = new Size(114, 29);
            btnJSONR.TabIndex = 28;
            btnJSONR.Text = "JSON Read";
            btnJSONR.UseVisualStyleBackColor = true;
            btnJSONR.Click += btnJSONR_Click;
            // 
            // btnSOAPR
            // 
            btnSOAPR.Location = new Point(308, 334);
            btnSOAPR.Name = "btnSOAPR";
            btnSOAPR.Size = new Size(114, 29);
            btnSOAPR.TabIndex = 27;
            btnSOAPR.Text = "SOAP Read";
            btnSOAPR.UseVisualStyleBackColor = true;
            btnSOAPR.Click += btnSOAPR_Click;
            // 
            // btnXMLR
            // 
            btnXMLR.Location = new Point(308, 284);
            btnXMLR.Name = "btnXMLR";
            btnXMLR.Size = new Size(114, 29);
            btnXMLR.TabIndex = 26;
            btnXMLR.Text = "XML Read";
            btnXMLR.UseVisualStyleBackColor = true;
            btnXMLR.Click += btnXMLR_Click;
            // 
            // btnBinaryR
            // 
            btnBinaryR.Location = new Point(308, 236);
            btnBinaryR.Name = "btnBinaryR";
            btnBinaryR.Size = new Size(114, 29);
            btnBinaryR.TabIndex = 25;
            btnBinaryR.Text = "Binary Read";
            btnBinaryR.UseVisualStyleBackColor = true;
            btnBinaryR.Click += btnBinaryR_Click;
            // 
            // btnJSONW
            // 
            btnJSONW.Location = new Point(175, 386);
            btnJSONW.Name = "btnJSONW";
            btnJSONW.Size = new Size(114, 29);
            btnJSONW.TabIndex = 24;
            btnJSONW.Text = "JSON Write";
            btnJSONW.UseVisualStyleBackColor = true;
            btnJSONW.Click += btnJSONW_Click;
            // 
            // btnSOAPW
            // 
            btnSOAPW.Location = new Point(175, 334);
            btnSOAPW.Name = "btnSOAPW";
            btnSOAPW.Size = new Size(114, 29);
            btnSOAPW.TabIndex = 23;
            btnSOAPW.Text = "SOAP Write";
            btnSOAPW.UseVisualStyleBackColor = true;
            btnSOAPW.Click += btnSOAPW_Click;
            // 
            // btnXMLW
            // 
            btnXMLW.Location = new Point(175, 284);
            btnXMLW.Name = "btnXMLW";
            btnXMLW.Size = new Size(114, 29);
            btnXMLW.TabIndex = 22;
            btnXMLW.Text = "XML Write";
            btnXMLW.UseVisualStyleBackColor = true;
            btnXMLW.Click += btnXMLW_Click;
            // 
            // btnBinaryW
            // 
            btnBinaryW.Location = new Point(175, 236);
            btnBinaryW.Name = "btnBinaryW";
            btnBinaryW.Size = new Size(114, 29);
            btnBinaryW.TabIndex = 21;
            btnBinaryW.Text = "Binary Write";
            btnBinaryW.UseVisualStyleBackColor = true;
            btnBinaryW.Click += btnBinaryW_Click;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(203, 164);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(219, 27);
            txtSalary.TabIndex = 20;
            // 
            // txtName
            // 
            txtName.Location = new Point(203, 95);
            txtName.Name = "txtName";
            txtName.Size = new Size(219, 27);
            txtName.TabIndex = 19;
            // 
            // txtId
            // 
            txtId.Location = new Point(203, 35);
            txtId.Name = "txtId";
            txtId.Size = new Size(219, 27);
            txtId.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 171);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 17;
            label3.Text = "Salary";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 102);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 16;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 42);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 15;
            label1.Text = "Id";
            // 
            // Employee_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnJSONR);
            Controls.Add(btnSOAPR);
            Controls.Add(btnXMLR);
            Controls.Add(btnBinaryR);
            Controls.Add(btnJSONW);
            Controls.Add(btnSOAPW);
            Controls.Add(btnXMLW);
            Controls.Add(btnBinaryW);
            Controls.Add(txtSalary);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Employee_Form";
            Text = "Employee_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClear;
        private Button btnJSONR;
        private Button btnSOAPR;
        private Button btnXMLR;
        private Button btnBinaryR;
        private Button btnJSONW;
        private Button btnSOAPW;
        private Button btnXMLW;
        private Button btnBinaryW;
        private TextBox txtSalary;
        private TextBox txtName;
        private TextBox txtId;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}