namespace Operations_for_shortcut_files
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
            txtAccountNumber = new TextBox();
            txtCustomerName = new TextBox();
            txtBalance = new TextBox();
            txtAccountType = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnRegister = new Button();
            btnSearch = new Button();
            btnShowAll = new Button();
            btnDelete = new Button();
            rtbResult = new RichTextBox();
            SuspendLayout();
            // 
            // txtAccountNumber
            // 
            txtAccountNumber.Font = new Font("Segoe UI", 13F);
            txtAccountNumber.Location = new Point(47, 59);
            txtAccountNumber.Name = "txtAccountNumber";
            txtAccountNumber.Size = new Size(229, 31);
            txtAccountNumber.TabIndex = 0;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Font = new Font("Segoe UI", 13F);
            txtCustomerName.Location = new Point(47, 119);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(229, 31);
            txtCustomerName.TabIndex = 1;
            // 
            // txtBalance
            // 
            txtBalance.Font = new Font("Segoe UI", 13F);
            txtBalance.Location = new Point(47, 179);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(229, 31);
            txtBalance.TabIndex = 2;
            // 
            // txtAccountType
            // 
            txtAccountType.Font = new Font("Segoe UI", 13F);
            txtAccountType.Location = new Point(47, 239);
            txtAccountType.Name = "txtAccountType";
            txtAccountType.Size = new Size(229, 31);
            txtAccountType.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 36);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 4;
            label1.Text = "Account Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 101);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 5;
            label2.Text = "Customer Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 161);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "Balance:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 221);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 7;
            label4.Text = "Account Type";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(86, 285);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(142, 30);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(86, 326);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(142, 30);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(86, 367);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(142, 30);
            btnShowAll.TabIndex = 10;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(86, 408);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(142, 30);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // rtbResult
            // 
            rtbResult.Location = new Point(388, 82);
            rtbResult.Name = "rtbResult";
            rtbResult.Size = new Size(312, 179);
            rtbResult.TabIndex = 12;
            rtbResult.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbResult);
            Controls.Add(btnDelete);
            Controls.Add(btnShowAll);
            Controls.Add(btnSearch);
            Controls.Add(btnRegister);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAccountType);
            Controls.Add(txtBalance);
            Controls.Add(txtCustomerName);
            Controls.Add(txtAccountNumber);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAccountNumber;
        private TextBox txtCustomerName;
        private TextBox txtBalance;
        private TextBox txtAccountType;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnRegister;
        private Button btnSearch;
        private Button btnShowAll;
        private Button btnDelete;
        private RichTextBox rtbResult;
    }
}
