
using System.Windows.Forms;

namespace MTD
{
    public partial class Form1 : Form
    {
        private DataExtractor extractor;

        public Form1()
        {
            InitializeComponent();

            this.Load += new EventHandler(Form1_Load);
   


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\aph-support\source\repos\MTD\MTD\logo.png"); // Adjust the path

            extractor = new DataExtractor();
            extractor.ExtractAmountFromMatrix();
            var returns = extractor.returns; // Assuming SampleDict is accessible


            string SAP_DATA = string.Empty;

            foreach (var entry in returns)
            {
                // Append each key-value pair to the string, with each pair on a new line
                SAP_DATA += $"{entry.Key}: {entry.Value}\n";
            }

            // Remove the last newline character to avoid extra space at the end
            if (SAP_DATA.Length > 0)
            {
                SAP_DATA = SAP_DATA.Remove(SAP_DATA.Length - 1);
            }

            // Set the concatenated string as the label text
            sap_data.Text = SAP_DATA;

            // Make sure the label can display multiple lines
            label1.AutoSize = true;  // This will allow the label to expand as necessary
            label1.MaximumSize = new Size(200, 0); // Adjust width as necessary, height will be auto
            label1.TextAlign = ContentAlignment.TopLeft;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var returns = extractor.returns; // Assuming SampleDict is accessible

            // Dates and text inputs from the form
            string fromDate = From_date.Value.Date.ToString("dd/MM/yyyy");
            string toDate = To_date.Value.Date.ToString("dd/MM/yyyy");

            string companyName = CompanyName.Text;
            string registrationNum = RegistrationNum.Text;

            string NJT = "NJT_MTD_VAT";
            var version = 1.0;
            string Version = version.ToString("F1", System.Globalization.CultureInfo.InvariantCulture); //to make it 1.0 in the file and not 1

            string import_ID = "StdCSV";

            DateTime now = DateTime.Now;

            // Format it to DD/MM/YYYY HH:MM:SS
            string timeStamp = now.ToString("dd/MM/yyyy HH:mm:ss");



            // Define CSV file path (adjust the path as necessary)
            string csvFilePath = @"C:\Users\aph-support\Desktop\MTD.csv";

            // Create and open the file
            using (StreamWriter sw = new StreamWriter(csvFilePath))
            {
                // Prepare the first part of the row with company info and dates
                string firstPartOfRow = $"{NJT},{Version},{import_ID},{timeStamp},{companyName},{registrationNum},{fromDate},{toDate}";

                // Initialize a string to hold all dictionary values
                string dictValues = "";

                // Concatenate all dictionary values separated by commas
                foreach (var value in returns.Values)
                {
                    dictValues += $",{value}";
                }

                // Write the combined row to the CSV
                sw.WriteLine(firstPartOfRow + dictValues);
            }

            // Indicate completion
            MessageBox.Show("CSV file created successfully , you can now submit the file on NJT VAT ");
        }




        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CompanyName_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistrationNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
