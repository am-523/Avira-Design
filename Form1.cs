using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avira_Design
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            status1.Visible = true;
            security1.Visible = false;
            privacy1.Visible = false;
            performance1.Visible = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            status1.Visible = false;
            security1.Visible = true;
            privacy1.Visible = false;
            performance1.Visible = false;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            status1.Visible = false;
            security1.Visible = false;
            privacy1.Visible = true;
            performance1.Visible = false;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            status1.Visible = false;
            security1.Visible = false;
            privacy1.Visible = false;
            performance1.Visible = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)

        {

            //if (!status1.Visible) guna2Transition1.ShowSync(status1);
            //else guna2Transition1.HideSync(status1);

            status1.Visible = true;
            security1.Visible = false;
            privacy1.Visible = false;
            performance1.Visible = false;
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            
        }
    }
}
