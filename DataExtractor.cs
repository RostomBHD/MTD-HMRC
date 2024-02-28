using SAPbouiCOM;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

public class DataExtractor
{
    private SAPbouiCOM.Application SBO_Application;
    public Dictionary<string, decimal> returns;

    public DataExtractor()
    {
        ConnectToSBO();
        returns = new Dictionary<string, decimal>();
    }

    private void ConnectToSBO()
    {
        SboGuiApi sboGuiApi = new SboGuiApi();
        // Example connection string, replace with your actual connection string
        string connectionString = "0030002C0030002C00530041005000420044005F00440061007400650076002C0050004C006F006D0056004900490056";
        try
        {
            sboGuiApi.Connect(connectionString);
            SBO_Application = sboGuiApi.GetApplication(-1);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error connecting to SAP Business One: {ex.Message}");
            Environment.Exit(1); // Or handle the error as needed
        }
    }

    public void ExtractAmountFromMatrix()
    {
        try
        {
            SAPbouiCOM.Form activeForm = SBO_Application.Forms.ActiveForm;
            SAPbouiCOM.Matrix oMatrix = (SAPbouiCOM.Matrix)activeForm.Items.Item("200000010").Specific;
            int rowCount = oMatrix.VisualRowCount;
            string keyColumnUID = "1470000041"; // The UID for the key column
            string valueColumnUID = "200000015"; // The UID for the value column

            for (int i = 1; i <= rowCount; i++)
            {
                var keyCell = (SAPbouiCOM.EditText)oMatrix.Columns.Item(keyColumnUID).Cells.Item(i).Specific;
                var valueCell = (SAPbouiCOM.EditText)oMatrix.Columns.Item(valueColumnUID).Cells.Item(i).Specific;

                string key = keyCell.Value;
                string rawValue = valueCell.Value;
                string cleanedValue = Regex.Replace(rawValue, "[^0-9.-]", "");
                decimal decimalValue = decimal.Parse(cleanedValue, CultureInfo.InvariantCulture);

                // Applying specific formatting based on the box number
                int boxNumber = i; // Assuming row index directly corresponds to box number

                if (boxNumber >= 1 && boxNumber <= 5)
                {
                    // For boxes 1 to 5, ensure two decimal places. For zero, explicitly set to 0.00.
                    decimalValue = decimalValue == 0 ? 0.00m : Math.Round(decimalValue, 2);
                }
                else if (boxNumber >= 6 && boxNumber <= 9)
                {
                    // For boxes 6 to 9, round to the nearest whole number (0 decimal places). For zero, explicitly set to 0.
                    decimalValue = decimalValue == 0 ? 0m : Math.Round(decimalValue);
                }


                returns[key] = decimalValue;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error extracting data from the active form: {ex.Message}");
        }

        foreach (var key in returns.Keys)
        {
            Console.WriteLine(key);
        }

    }

}
