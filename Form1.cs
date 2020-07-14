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

namespace svg_generator
{
    public partial class Form1 : Form
    {
        StreamWriter sw = new StreamWriter("picture.svg");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            sw.WriteLine("<svg width = \"1000\" height = \"1000\" version = \"1.1\" xmlns = \"http://www.w3.org/2000/svg\" >");
        }

        private void radio_circle_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_circle.Checked || radio_square.Checked)
            {
                text_wid.Text = "Radius";
                numeric_hei.Visible = false;
                text_hei.Visible = false;
            }
            else
            {
                text_wid.Text = "Width";
                numeric_hei.Visible = true;
                text_hei.Visible = true;
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (radio_circle.Checked)
                sw.WriteLine("<circle cx = \"{0}\" cy = \"{1}\" r = \"{2}\" style=\"fill:rgb({3},{4},{5})\" />",numeric_X.Value,numeric_Y.Value, numeric_wid.Value, numeric_red.Value, numeric_green.Value, numeric_blue.Value);

            if (radio_ellipse.Checked)
                sw.WriteLine("<ellipse cx = \"{0}\" cy = \"{1}\" rx = \"{2}\" ry = \"{3}\" style=\"fill:rgb({4},{5},{6})\" />", numeric_X.Value, numeric_Y.Value, numeric_wid.Value, numeric_hei.Value, numeric_red.Value, numeric_green.Value, numeric_blue.Value);

            if (radio_square.Checked)
                sw.WriteLine("<rect x = \"{0}\" y = \"{1}\" width = \"{2}\" height = \"{3}\" style=\"fill:rgb({4},{5},{6})\" />", numeric_X.Value, numeric_Y.Value, numeric_wid.Value, numeric_wid.Value, numeric_red.Value, numeric_green.Value, numeric_blue.Value);
        
            if (radio_rectangle.Checked)
                sw.WriteLine("<rect x = \"{0}\" y = \"{1}\" width = \"{2}\" height = \"{3}\" style=\"fill:rgb({4},{5},{6})\" />", numeric_X.Value, numeric_Y.Value, numeric_wid.Value, numeric_hei.Value, numeric_red.Value, numeric_green.Value, numeric_blue.Value);
        }

        private void button_end_Click(object sender, EventArgs e)
        {
            sw.WriteLine("</svg>");
            sw.Flush();
            sw.Close();
            this.Close();
        }

        private void radio_square_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_circle.Checked || radio_square.Checked)
            {
                text_wid.Text = "Radius";
                numeric_hei.Visible = false;
                text_hei.Visible = false;
            }
            else
            {
                text_wid.Text = "Width";
                numeric_hei.Visible = true;
                text_hei.Visible = true;
            }
        }
    }
}
