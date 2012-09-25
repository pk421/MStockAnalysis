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
        private void txtSayHello_Click(object sender, EventArgs e)
        {
            //writing to the console now cuases the text to be displayed in the text box
            Console.WriteLine("\nHello World");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("\ntest");
            }
        }
    }
}
