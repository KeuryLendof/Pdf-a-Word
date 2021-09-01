using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pdf_a_Word
{
    public partial class Carga : Form
    {
        public Carga()
        {
            InitializeComponent();
        }


        private void Carga_Load(object sender, EventArgs e)
        {
            
            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 4000;
            circularProgressBar1.Step = 4;

            for(int x = 0; x < 4000; x++)
            {
                circularProgressBar1.PerformStep();
            }


            

        }
    }
}
