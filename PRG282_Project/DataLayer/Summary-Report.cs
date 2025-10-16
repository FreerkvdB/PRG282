using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Imported necessary namespaces
using PRG282_Project.BusinessLogicLayer;
using System.IO;
//This class is responsible for generating summary reports based on the data processed in the Business Logic Layer

namespace PRG282_Project.DataLayer
{
    internal class Summary_Report
    {
       private readonly string filename = @"summary.txt"; // Define the filename for the summary report

        public void SaveSummary(string summaryText) // This method will generate a summary report from the data calculated in the Business Logic Layer
        {
           
            FileStream fs = new FileStream(filename, FileMode.Create); // Create a new file stream to write to the summary file
            
            using (StreamWriter sw = new StreamWriter(fs))
            {
               sw.Write(summaryText);
            }

            fs.Close(); // Close the file stream
            Console.WriteLine("Summary report generated successfully.");
            Console.ReadLine(); // Pause to allow user to see the message
        }

        public string ReadSummary() // This method will read the summary report from the file and display it to the user
        {
            if (!File.Exists(filename))
            {
                return "File not found";
            }
            using (StreamReader sr = new StreamReader(filename))
            {
                return sr.ReadToEnd();
            }
        }
    }
}
