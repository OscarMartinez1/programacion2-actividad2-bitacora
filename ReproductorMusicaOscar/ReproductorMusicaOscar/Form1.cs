using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReproductorMusicaOscar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            personalizardiseño();
        }

        private void personalizardiseño()
        {
            panelMediosSubMenu.Visible = false;
            panelListaReproduccion.Visible = false;
            panelEcualizador.Visible = false;
        }

        private void ocultarSubMenU()
        {
            if (panelMediosSubMenu.Visible == true)
            {
                panelMediosSubMenu.Visible = false;
            }
            if (panelListaReproduccion.Visible == true)
            {
                panelListaReproduccion.Visible = false;
            }
            if (panelEcualizador.Visible == true)
                panelEcualizador.Visible = false;

        }

        private void mostrarSubmenu(Panel algunSubMenu)
        {
            if (algunSubMenu.Visible == false)
            {
                ocultarSubMenU();
                algunSubMenu.Visible = true;

            }
            else
            {
                algunSubMenu.Visible = false;
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        #region SubMenuMedios   

        private void btnMedios_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelMediosSubMenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ocultarSubMenU();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ocultarSubMenU();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ocultarSubMenU();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ocultarSubMenU();
        }

        #endregion SubMenuMedios

        #region SubMenuReproduccion

        private void btnListaReproduccion_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelListaReproduccion);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ocultarSubMenU();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ocultarSubMenU();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ocultarSubMenU();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ocultarSubMenU();
        }

        #endregion SubMenuReproduccion

        #region SubMenuEcualizador

        private void btnEcualizador_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelEcualizador);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelMediosSubMenu);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelMediosSubMenu);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelMediosSubMenu);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelEcualizador);
        }
        #endregion SubMenuEcualizador
    }
}

