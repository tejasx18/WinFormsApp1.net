namespace WinFormsApp1
{
    partial class Product
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
            btnWrite = new Button();
            btnRead = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(262, 85);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(262, 144);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(262, 213);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // txtId
            // 
            txtId.Location = new Point(357, 78);
            txtId.Name = "txtId";
            txtId.Size = new Size(165, 27);
            txtId.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(357, 144);
            txtName.Name = "txtName";
            txtName.Size = new Size(165, 27);
            txtName.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(357, 213);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(165, 27);
            txtPrice.TabIndex = 5;
            // 
            // btnWrite
            // 
            btnWrite.Location = new Point(262, 281);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(120, 29);
            btnWrite.TabIndex = 6;
            btnWrite.Text = "Write";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(400, 281);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(122, 29);
            btnRead.TabIndex = 7;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRead);
            Controls.Add(btnWrite);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Product";
            Text = "Product";
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
        private Button btnWrite;
        private Button btnRead;
    }
}