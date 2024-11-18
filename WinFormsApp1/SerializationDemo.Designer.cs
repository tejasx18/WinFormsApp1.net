namespace WinFormsApp1
{
    partial class SerializationDemo
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
            txtId = new TextBox();
            txtName = new TextBox();
            txtPrice = new TextBox();
            btnBinaryW = new Button();
            btnXMLW = new Button();
            btnSOAPW = new Button();
            btnJSONW = new Button();
            btnBinaryR = new Button();
            btnXMLR = new Button();
            btnSOAPR = new Button();
            btnJSONR = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(356, 107);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(356, 167);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(356, 236);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // txtId
            // 
            txtId.Location = new Point(433, 100);
            txtId.Name = "txtId";
            txtId.Size = new Size(219, 27);
            txtId.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(433, 160);
            txtName.Name = "txtName";
            txtName.Size = new Size(219, 27);
            txtName.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(433, 229);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(219, 27);
            txtPrice.TabIndex = 5;
            // 
            // btnBinaryW
            // 
            btnBinaryW.Location = new Point(405, 301);
            btnBinaryW.Name = "btnBinaryW";
            btnBinaryW.Size = new Size(114, 29);
            btnBinaryW.TabIndex = 6;
            btnBinaryW.Text = "Binary Write";
            btnBinaryW.UseVisualStyleBackColor = true;
            btnBinaryW.Click += btnBinaryW_Click;
            // 
            // btnXMLW
            // 
            btnXMLW.Location = new Point(405, 349);
            btnXMLW.Name = "btnXMLW";
            btnXMLW.Size = new Size(114, 29);
            btnXMLW.TabIndex = 7;
            btnXMLW.Text = "XML Write";
            btnXMLW.UseVisualStyleBackColor = true;
            btnXMLW.Click += btnXMLW_Click;
            // 
            // btnSOAPW
            // 
            btnSOAPW.Location = new Point(405, 399);
            btnSOAPW.Name = "btnSOAPW";
            btnSOAPW.Size = new Size(114, 29);
            btnSOAPW.TabIndex = 8;
            btnSOAPW.Text = "SOAP Write";
            btnSOAPW.UseVisualStyleBackColor = true;
            btnSOAPW.Click += btnSOAPW_Click;
            // 
            // btnJSONW
            // 
            btnJSONW.Location = new Point(405, 451);
            btnJSONW.Name = "btnJSONW";
            btnJSONW.Size = new Size(114, 29);
            btnJSONW.TabIndex = 9;
            btnJSONW.Text = "JSON Write";
            btnJSONW.UseVisualStyleBackColor = true;
            btnJSONW.Click += btnJSONW_Click;
            // 
            // btnBinaryR
            // 
            btnBinaryR.Location = new Point(538, 301);
            btnBinaryR.Name = "btnBinaryR";
            btnBinaryR.Size = new Size(114, 29);
            btnBinaryR.TabIndex = 10;
            btnBinaryR.Text = "Binary Read";
            btnBinaryR.UseVisualStyleBackColor = true;
            btnBinaryR.Click += btnBinaryR_Click;
            // 
            // btnXMLR
            // 
            btnXMLR.Location = new Point(538, 349);
            btnXMLR.Name = "btnXMLR";
            btnXMLR.Size = new Size(114, 29);
            btnXMLR.TabIndex = 11;
            btnXMLR.Text = "XML Read";
            btnXMLR.UseVisualStyleBackColor = true;
            btnXMLR.Click += btnXMLR_Click;
            // 
            // btnSOAPR
            // 
            btnSOAPR.Location = new Point(538, 399);
            btnSOAPR.Name = "btnSOAPR";
            btnSOAPR.Size = new Size(114, 29);
            btnSOAPR.TabIndex = 12;
            btnSOAPR.Text = "SOAP Read";
            btnSOAPR.UseVisualStyleBackColor = true;
            btnSOAPR.Click += btnSOAPR_Click;
            // 
            // btnJSONR
            // 
            btnJSONR.Location = new Point(538, 451);
            btnJSONR.Name = "btnJSONR";
            btnJSONR.Size = new Size(114, 29);
            btnJSONR.TabIndex = 13;
            btnJSONR.Text = "JSON Read";
            btnJSONR.UseVisualStyleBackColor = true;
            btnJSONR.Click += btnJSONR_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(811, 100);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // SerializationDemo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 609);
            Controls.Add(btnClear);
            Controls.Add(btnJSONR);
            Controls.Add(btnSOAPR);
            Controls.Add(btnXMLR);
            Controls.Add(btnBinaryR);
            Controls.Add(btnJSONW);
            Controls.Add(btnSOAPW);
            Controls.Add(btnXMLW);
            Controls.Add(btnBinaryW);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SerializationDemo";
            Text = "SerializationDemo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtPrice;
        private Button btnBinaryW;
        private Button btnXMLW;
        private Button btnSOAPW;
        private Button btnJSONW;
        private Button btnBinaryR;
        private Button btnXMLR;
        private Button btnSOAPR;
        private Button btnJSONR;
        private Button btnClear;
    }
}