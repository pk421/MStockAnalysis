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

        private void ReadCSVs_Click(object sender, EventArgs e)
        {
            bgReadCSVs.RunWorkerAsync();
        }
    
        private void STOP_Click(object sender, EventArgs e)
        {
            bgReadCSVs.CancelAsync();
            Console.WriteLine("STOP Hit");
        }

        private void bgReadCSVs_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bg = sender as BackgroundWorker;
            using (CsvFileReader reader = new CsvFileReader("etc/Spy.csv"))
            {
                string[] date = new string[1];
                double[] Open = new double[1];
                double[] High = new double[1];
                double[] Low = new double[1];
                double[] Close = new double[1];
                double[] AdjClose = new double[1];
                double[] Volume = new double[1];


                CsvRow row = new CsvRow();
                int counter = 0;
                while (reader.ReadRow(row) && counter <= 5000 && !bgReadCSVs.CancellationPending)
                {
                    if (bgReadCSVs.CancellationPending == true)
                    {
                        e.Cancel = true;
                        return;
                    }

                    date[counter] = row[0];
                    Array.Resize(ref date, date.Length + 1);

                    Open[counter] = Convert.ToDouble(row[1]);
                    Array.Resize(ref Open, Open.Length + 1);

                    High[counter] = Convert.ToDouble(row[2]);
                    Array.Resize(ref High, High.Length + 1);

                    Low[counter] = Convert.ToDouble(row[3]);
                    Array.Resize(ref Low, Low.Length + 1);

                    Close[counter] = Convert.ToDouble(row[4]);
                    Array.Resize(ref Close, Close.Length + 1);

                    Volume[counter] = Convert.ToDouble(row[5]);
                    Array.Resize(ref Volume, Volume.Length + 1);

                    //bg.ReportProgress(0, date[counter]);
                    //Thread.Sleep(1);
                    //bg.ReportProgress(0, "\n");

                    //Thread.Sleep(1);
                    counter ++;
                }
                Array.Resize(ref date, date.Length - 1);

                bg.ReportProgress(0, date[4777]);
                Array.Reverse(date);
                Array.Reverse(Open);
                Array.Reverse(High);
                Array.Reverse(Low);
                Array.Reverse(Close);
                Array.Reverse(Volume);
                int l = date.Length;
                string d = date[4779];
                bg.ReportProgress(0, "\n");
                bg.ReportProgress(0, d);
                bg.ReportProgress(0, "\n");
                bg.ReportProgress(0, date.Length);
            }
            bg.ReportProgress(0, "Test Finished\n");
            return;
        }

        public void bgReadCSVs_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (bgReadCSVs.CancellationPending == false)
            {
                Console.Write(e.UserState);
            }
        }
        public void bgReadCSVs_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                Console.WriteLine("Cancel Completed");
            }
        }

    }
}
