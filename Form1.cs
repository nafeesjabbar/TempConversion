using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConversion
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

        private void btn_kelvin_Click(object sender, EventArgs e)
        {
            convertFromKelvin();
        }

        private void convertFromKelvin()
        {
            double k = 0;

            try
            {
                k = double.Parse(txt_kelvin.Text);
            }
            catch
            {
                MessageBox.Show("Try only numbers");
            }

            double c = k - 273.15;
            double f = (k - 273.15) * 9f / 5f + 32;

            txt_celsius.Text = c.ToString();
            txt_farhenheight.Text = f.ToString();
        }

        private void btn_farhenheight_Click(object sender, EventArgs e)
        {
            convertFromFahrenheight();
        }

        private void convertFromFahrenheight()
        {
            double f = 0;

            try
            {
                f = double.Parse(txt_farhenheight.Text);
            }
            catch
            {
                MessageBox.Show("Try only numbers");
            }

            double c = (f - 32) * 5f / 9f;
            double k = (f - 32) * 5f / 9f + 273.15;

            txt_celsius.Text = c.ToString();
            txt_kelvin.Text = k.ToString();
        }

        private void convertFromCelsius()
        {
            double c = 0;
            Math.Round(c);

            try
            {
                c = double.Parse(txt_celsius.Text);
            }
            catch
            {
                MessageBox.Show("Try only numbers");
            }

            double f = (c * 9f / 5f) + 32;
            double k = c + 273.15;

            txt_farhenheight.Text = f.ToString();
            txt_kelvin.Text = k.ToString();
        }

        private void btn_celsius_Click(object sender, EventArgs e)
        {
            convertFromCelsius();
        }

        private void txt_farhenheight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                convertFromFahrenheight();
            }
        }

        private void txt_celsius_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                convertFromCelsius();
            }
        }

        private void txt_kelvin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                convertFromKelvin();
            }
        }
    }
}
