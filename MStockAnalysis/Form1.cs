using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CsvReadWrite;

namespace MStockAnalysis
{
    public partial class Form1 : Form
    {

        // That's our custom TextWriter class
        TextWriter _writer = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Instantiate the writer
            _writer = new TextBoxStreamWriter(txtConsole);
            // Redirect the out Console stream
            Console.SetOut(_writer);
            Console.WriteLine("Now redirecting output to the textbox");
        }
    
        //This is called when the "Say Hello" button is clicked
        private void ReadCSVs(object sender, EventArgs e)
        {
            //writing to the console now cuases the text to be displayed in the text box
            Console.WriteLine("\nHello World");

            using (CsvFileReader reader = new CsvFileReader("etc/Spy.csv"))
            {
                CsvRow row = new CsvRow();
                int counter = 0;
                while (reader.ReadRow(row) && counter <=20)
                {
                    foreach (string s in row)
                    {
                        Console.Write(s);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                    counter++;
                }
            }
            Console.WriteLine("Finished");
            Console.WriteLine(Environment.CurrentDirectory);
        }
        private void STOP(object sender, EventArgs e)
        {
            Console.WriteLine("stopped");
            return;
        }

    }
}
