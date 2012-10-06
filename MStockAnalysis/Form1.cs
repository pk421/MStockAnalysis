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
using System.Threading;

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


        private async void ReadCSVs_Click(object sender, EventArgs e)
        {
            //await ReadCSVs();
            backgroundWorker1.RunWorkerAsync();
        }
        
        public async Task<string> ReadCSVs()
        {
            //writing to the console now causes the text to be displayed in the text box
            Console.WriteLine("\nHello World");

            using (CsvFileReader reader = new CsvFileReader("etc/Spy.csv"))
            {
                CsvRow row = new CsvRow();
                int counter = 0;
                while (reader.ReadRow(row) && counter <=1000)
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
            var today = await Task.FromResult<string>(DateTime.Now.DayOfWeek.ToString());
            return "Finished Reading CSVs";
        }
        private void STOP(object sender, EventArgs e)
        {
            Console.WriteLine("hit stop button");
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //Console.WriteLine("Start Worker, now waiting");
            Thread.Sleep(10000);
            //backgroundWorker1.ReportProgress("progress reported!");

            string outs = "test";
            BackgroundWorker bg = sender as BackgroundWorker;
            bg.ReportProgress(0, outs.ToString());
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Console.WriteLine("test2");
        }

    }
}
