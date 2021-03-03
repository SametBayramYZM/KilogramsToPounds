using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KilogramsToPounds
{
    public partial class KilogramsToPounds : Form
    {
        public KilogramsToPounds()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double Kilograms = Convert.ToDouble(tbKilograms.Text);
            double Pounds = Convert.ToDouble(Kilograms * 2.2046);
            lbPounds.Text = Convert.ToString(Pounds);
        }
    }
}
