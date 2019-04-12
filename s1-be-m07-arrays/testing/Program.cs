using System;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testing
{
    
    
   public partial class Form1 : Form
       {
          private const String Letters = "abcdefghijklmnopqrstuvwxyz";
            private readonly char[] Alphanumeric = (Letters + Letters.ToUpper() + "0123456789").ToCharArray();

            public Form1()
            {
                InitializeComponent();
            }

            private void btGenerate_Click(object sender, EventArgs e)
            {
                Ibres.Items.Add(generateRandomAlphanumeri(Convert.ToInt32(tbLenght.Text)));
            }

       private String generateRandomAlphanumeric(int lenght)
       {
                StringBuilder result = new StringBuilder();
                Random rn = new Random();
                for (int i = 0; i < lenght; i++)
                {
                    result.Append(Alphanumeric[rn.Next(Alphanumeric.Length)]);
                }
                return result.ToString();
       }
   }
    
}