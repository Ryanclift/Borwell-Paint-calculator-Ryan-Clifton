using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_calculator
{
    public partial class Form1 : Form
    {       
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {            
            /*defines all variables needed*/
            decimal volume;
            decimal floor;
            decimal Height = Convert.ToDecimal(txtHeight.Text);
            decimal Length = Convert.ToDecimal(txtLength.Text);
            decimal Width = Convert.ToDecimal(txtWidth.Text);
            decimal Coverage = Convert.ToDecimal(txtCoverage.Text);
            decimal Coats = Convert.ToDecimal(txtCoats.Text);            
           
            /*Works out volume*/
            volume = Height * Length * Width;
            txtVolume.Text = Convert.ToString(volume);

            /*works out floor area*/
            floor = Length * Width;
            txtFloor.Text = Convert.ToString(floor);

            /*works out wall surface area, only needs to work out 
             * two walls as the opposite walls will be same size*/
            decimal Side1 = Width * Height;
            decimal Side2 = Length * Height;

            /*works out total surface area for all 4 walls with number of coats wanted*/
            decimal area = (2 * (Side1 + Side2)) * Coats;

            /*works out amount of paint needed*/
            decimal Paint = area / Coverage;
            txtPaint.Text = Convert.ToString(Paint);

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
