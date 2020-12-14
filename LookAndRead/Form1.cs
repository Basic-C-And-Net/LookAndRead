using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LookAndRead
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            panelSubMenuBooks.Visible = false;
            panelSepet.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelSubMenuBooks.Visible == true)
                panelSubMenuBooks.Visible = false;
            if (panelSepet.Visible == true)
                panelSepet.Visible = false;
        }

        private void showSubMenu(Panel panel)
        {
            if (panelSubMenuBooks.Visible == false)
            {
                hideSubMenu();
                panel.Visible = true;
            }
            else
            {
                panel.Visible = false;
            }
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuBooks);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new CokSatanlar());
            //..
            //Your code
            //..
            hideSubMenu();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //..
            //Your code
            //..
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //..
            //Your code
            //..
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSepet);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            openChildForm(new Sepet());
            //..
            //Your code
            //..
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //..
            //Your code
            //..
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //..
            //Your code
            //..
            hideSubMenu();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
