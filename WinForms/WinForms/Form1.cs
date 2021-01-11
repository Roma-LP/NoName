using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Form1 : Form
    {
        CollectionTR CTR = new CollectionTR();
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateButtonTrain_Click(object sender, EventArgs e)
        {
            CTR.Add(new TRAIN(Program.WriteDest(), Program.WriteTrainNumber(), Program.WriteTime()));
            Console.Clear();
        }

        private void OutPutButton_Click(object sender, EventArgs e)
        {
            Console.Clear();
          
               
            TextBoxMain.Text = CTR.PrintAll();
            
        }

        private void TextBoxMain_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
