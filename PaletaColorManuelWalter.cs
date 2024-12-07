using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreacionComponentePropio_ManuelWalter
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public Color devolver_color()
        {
            return panel1.BackColor;
        }

        public String devolver_color_srting()
        {
            return "R: "+numericUpDown1.Value+" G: "+ numericUpDown2.Value + " B: "+ numericUpDown3.Value;
        }

        private void pulsa_boton(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            Color c = b.BackColor;

            panel1.BackColor = c;

            int R = c.R;
            int G = c.G;
            int B = c.B;

            numericUpDown1.Value = R;
            numericUpDown2.Value = G;
            numericUpDown3.Value = B;

            trackBar1.Value = (int)R;
            trackBar2.Value = (int)G;
            trackBar3.Value = (int)B;

        }

        private void pulsa_boton_cambiante(object sender, MouseEventArgs e)
        {

            Button b = (Button)sender;

            if (e.Button == MouseButtons.Left)
            {
                Color c = b.BackColor;

                panel1.BackColor = c;

                int R = c.R;
                int G = c.G;
                int B = c.B;

                numericUpDown1.Value = R;
                numericUpDown2.Value = G;
                numericUpDown3.Value = B;

                trackBar1.Value = (int)R;
                trackBar2.Value = (int)G;
                trackBar3.Value = (int)B;

            }
            else if(e.Button == MouseButtons.Right)
            {
                Color c = panel1.BackColor;

                b.BackColor = c;
            }
        }

        private void cambia_trackbar(object sender, EventArgs e)
        {
            int R = trackBar1.Value;
            int G = trackBar2.Value;
            int B = trackBar3.Value;

            numericUpDown1.Value = R;
            numericUpDown2.Value = G;
            numericUpDown3.Value = B;

            Color c = Color.FromArgb(R, G, B);

            panel1.BackColor = c;

        }

        private void cambia_numericUpDown(object sender, EventArgs e)
        {
            decimal R = numericUpDown1.Value;
            decimal G = numericUpDown2.Value;
            decimal B = numericUpDown3.Value;

            trackBar1.Value = (int)R;
            trackBar2.Value = (int)G;
            trackBar3.Value = (int)B;

            Color c = Color.FromArgb((int)R, (int)G, (int)B);

            panel1.BackColor = c;

        }
    }
}
