using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace vistas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            customizeDesing();
        }

        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void customizeDesing()
        {
            panelProductSubMenu.Visible = false;
            panelVentasSubMenu.Visible = false;

        }

        private void hideSubMenu()
        {
            if (panelProductSubMenu.Visible == true)
                panelProductSubMenu.Visible = false;
            if (panelVentasSubMenu.Visible == true)
                panelVentasSubMenu.Visible = false;
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmUsuario());
        }


    }
}
