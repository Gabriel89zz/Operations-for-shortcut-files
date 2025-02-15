using System.Text;

namespace Operations_for_shortcut_files
{
    public partial class Form1 : Form
    {
        private string dataFile = Path.Combine(Application.StartupPath, "accounts.dat");


        private const int RecordSize = 150;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                int accountNumber = int.Parse(txtAccountNumber.Text);
                string customerName = txtCustomerName.Text.Trim();
                decimal balance = decimal.Parse(txtBalance.Text);
                string accountType = txtAccountType.Text.Trim();

                if (string.IsNullOrEmpty(customerName) || balance < 0 || string.IsNullOrEmpty(accountType))
                {
                    MessageBox.Show("Please enter valid data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string accountData = FormatRecord(accountNumber, customerName, balance, accountType);

                using (FileStream fs = new FileStream(dataFile, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    long position = (accountNumber - 1) * RecordSize;
                    fs.Seek(position, SeekOrigin.Begin);
                    byte[] buffer = Encoding.UTF8.GetBytes(accountData);
                    fs.Write(buffer, 0, buffer.Length);
                }

                MessageBox.Show("Account registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int accountNumber = int.Parse(txtAccountNumber.Text);

                using (FileStream fs = new FileStream(dataFile, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    long position = (accountNumber - 1) * RecordSize; 
                    fs.Seek(position, SeekOrigin.Begin);

                    byte[] buffer = new byte[RecordSize];
                    int bytesRead = fs.Read(buffer, 0, RecordSize);

                    if (bytesRead == 0)
                    {
                        MessageBox.Show("Account not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string record = Encoding.UTF8.GetString(buffer).TrimEnd('\0');
                    var data = record.Split('|');

                    rtbResult.Clear();
                    rtbResult.AppendText($"Account Number: {data[0]}\nCustomer Name: {data[1]}\nBalance: {decimal.Parse(data[2]):C}\nAccount Type: {data[3]}\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {

            try
            {
                rtbResult.Clear();

                if (!File.Exists(dataFile))
                {
                    MessageBox.Show("No accounts registered.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                using (FileStream fs = new FileStream(dataFile, FileMode.Open, FileAccess.Read))
                {
                    byte[] buffer = new byte[RecordSize];
                    while (fs.Read(buffer, 0, RecordSize) > 0)
                    {
                        string record = Encoding.UTF8.GetString(buffer).TrimEnd('\0');

                        if (!string.IsNullOrWhiteSpace(record))
                        {
                            var data = record.Split('|');

                            if (data.Length >= 4)
                            {
                                string accountNumber = data[0];
                                string customerName = data[1];
                                string balanceText = data[2];
                                string accountType = data[3];

                                if (!decimal.TryParse(balanceText, out decimal balance))
                                {
                                    balance = 0;
                                }

                                rtbResult.AppendText($"Account Number: {accountNumber}, Customer Name: {customerName}, Balance: {balance:C}, Account Type: {accountType}\n");
                            }
                            else
                            {
                                rtbResult.AppendText($"Invalid record found: {record}\n");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int accountNumber = int.Parse(txtAccountNumber.Text);

                using (FileStream fs = new FileStream(dataFile, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    long position = (accountNumber - 1) * RecordSize; 
                    fs.Seek(position, SeekOrigin.Begin);

                    byte[] buffer = new byte[RecordSize];
                    Array.Clear(buffer, 0, buffer.Length);
                    fs.Write(buffer, 0, buffer.Length);
                }

                MessageBox.Show("Account deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string FormatRecord(int accountNumber, string customerName, decimal balance, string accountType)
        {
            StringBuilder record = new StringBuilder();
            record.Append($"{accountNumber}|{customerName.PadRight(70)}|{balance:F2}|{accountType.PadRight(10)}");
            return record.ToString().PadRight(RecordSize, '\0'); 
        }

        private void ClearFields()
        {
            txtAccountNumber.Clear();
            txtCustomerName.Clear();
            txtBalance.Clear();
            txtAccountType.Clear();
        }
    }
}
