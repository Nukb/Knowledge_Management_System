using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Knowledge_Management_System.Forms;


namespace Knowledge_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            date_label.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }

        private void dashboard_button_MouseHover(object sender, EventArgs e)
        {
            dashboard_button.ForeColor = Color.White;
            dashboard_button.BackColor = Color.LightSeaGreen;
        }

        private void dashboard_button_MouseLeave(object sender, EventArgs e)
        {
            dashboard_button.ForeColor = Color.LightSeaGreen;
            dashboard_button.BackColor = Color.LightCyan;
        }

        private void book_button_MouseHover(object sender, EventArgs e)
        {
            book_button.ForeColor = Color.White;
            book_button.BackColor = Color.LightSeaGreen;
        }

        private void book_button_MouseLeave(object sender, EventArgs e)
        {
            book_button.ForeColor = Color.LightSeaGreen;
            book_button.BackColor = Color.LightCyan;
        }

        private void reader_button_MouseHover(object sender, EventArgs e)
        {
            reader_button.ForeColor = Color.White;
            reader_button.BackColor = Color.LightSeaGreen;
        }

        private void reader_button_MouseLeave(object sender, EventArgs e)
        {
            reader_button.ForeColor = Color.LightSeaGreen;
            reader_button.BackColor = Color.LightCyan;
        }

        private void employee_button_MouseHover(object sender, EventArgs e)
        {
            employee_button.ForeColor = Color.White;
            employee_button.BackColor = Color.LightSeaGreen;
        }

        private void employee_button_MouseLeave(object sender, EventArgs e)
        {
            employee_button.ForeColor = Color.LightSeaGreen;
            employee_button.BackColor = Color.LightCyan;
        }

        private void report_button_MouseHover(object sender, EventArgs e)
        {
            report_button.ForeColor = Color.White;
            report_button.BackColor = Color.LightSeaGreen;
        }

        private void report_button_MouseLeave(object sender, EventArgs e)
        {
            report_button.ForeColor = Color.LightSeaGreen;
            report_button.BackColor = Color.LightCyan;
        }

        private void segtting_button_MouseHover(object sender, EventArgs e)
        {
            segtting_button.ForeColor = Color.White;
            segtting_button.BackColor = Color.LightSeaGreen;
        }

        private void segtting_button_MouseLeave(object sender, EventArgs e)
        {
            segtting_button.ForeColor = Color.LightSeaGreen;
            segtting_button.BackColor = Color.LightCyan;
        }

        private void dashboard_button_Click(object sender, EventArgs e)
        {
            statistic_label.Visible = true;
            main_panel2.Visible = true;
            events_label.Visible = true;
            main_panel3.Visible = true;

            
        }
    }
}
