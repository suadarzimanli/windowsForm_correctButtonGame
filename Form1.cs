using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Find the secret button.");
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello! Find the correct button.");
        }

        private void btn2_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Fail");
        }

        private void btnSuccess_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("You found me!");
        }

        private void btn3_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Fail");
        }

        private void btn1_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Fail");
        }

        private void btnClick_MouseHover(object sender, EventArgs e)
        {
            btnClick.BackColor = Color.Red;
        }

        private void btnClick_MouseLeave(object sender, EventArgs e)
        {
            btnClick.BackColor = Color.White;
        }
    }
}
