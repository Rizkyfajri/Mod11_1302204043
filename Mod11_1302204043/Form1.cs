using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mod11_1302204043
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtOutput1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProcess1_Click(object sender, EventArgs e)
        {
            PusatDataSingleton Data1 = PusatDataSingleton.GetPusatDataSingleton;
            PusatDataSingleton Data2 = PusatDataSingleton.GetPusatDataSingleton;

            string input1 = txtData1.Text;

            Data1.AddSebuahData(input1);
            Data2.PrintSemuaData();


        }

        private void txtData1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            PusatDataSingleton Data1 = PusatDataSingleton.GetPusatDataSingleton;
            PusatDataSingleton Data2 = PusatDataSingleton.GetPusatDataSingleton;

            Data2.HapusSebuahData(0);
            Data1.PrintSemuaData();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            PusatDataSingleton Data1 = PusatDataSingleton.GetPusatDataSingleton;
            PusatDataSingleton Data2 = PusatDataSingleton.GetPusatDataSingleton;
            var data = Data1.GetSemuaData();

            Console.WriteLine(data.Count());
        }
    }
}
