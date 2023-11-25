using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JunaidPractice
{
    public partial class colour_dialog : Form
    {
        public colour_dialog()
        {
            InitializeComponent();
        }

        private void Btn_front_color_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                this.ForeColor = color.Color;
            }
        }

        private void Btn_background_color_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = color.Color;
            }
        }

        private void Btn_font_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if (font.ShowDialog() == DialogResult.OK)
            {
                label1.Font = font.Font;
            }
        }
    }
}
