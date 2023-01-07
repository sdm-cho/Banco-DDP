using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public bool logueado;
        public int dni;
        public int id;
        public string password;
        public Banco elBanco;
        string email;

        public TransfDelegado TransfEvento;
        public Form2(Banco b)
        {
            logueado = false;
            InitializeComponent();
            elBanco = new Banco();
            elBanco = b;
        }
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            email = (txtCorreoInicio.Text);
            password = (txtContraInicio.Text);
            if (email != null && password != "")
            {
                this.TransfEvento(email, password);
            }
            else
                MessageBox.Show("Debe ingresar un usuario!");

        }
        public delegate void TransfDelegado(string email, string pass);

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(elBanco.agregarUsuario(int.Parse(txtDni.Text), txtNombre.Text, txtApellido.Text, txtCorreo.Text, txtContra.Text, checkBox1.Checked))
            {
                MessageBox.Show("Usuario registrado exitosamente");
            }
            else
                MessageBox.Show("Su Dni o Email ya forma parte del banco!");
        }
        private void btnMouseEnter(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            foreach (Control ctr in pPrincipal.Controls)
            {
                if (ctr is Button)
                {
                    bt.ForeColor = Color.Black;
                }
            }
        }
        private void btnMouseLeave(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            foreach (Control ctr in pPrincipal.Controls)
            {
                if (ctr is Button)
                {
                    bt.ForeColor = Color.White;
                }
            }
        }
        private void txtEnter(object sender, EventArgs e)
        {
            TextBox tx = sender as TextBox;
            foreach (Control ctr in pRegistro.Controls)
            {
                if (ctr is Panel && ctr.Name == "p" + tx.Tag.ToString())
                {
                    ctr.BackColor = Color.Black;
                }
            }
        }
        private void txtLeave(object sender, EventArgs e)
        {
            TextBox tx = sender as TextBox;
            foreach (Control ctr in pRegistro.Controls)
            {
                if (ctr is Panel && ctr.Name == "p" + tx.Tag.ToString())
                {
                    ctr.BackColor = Color.Silver;
                }
            }
        }
        private void txtEnter_1(object sender, EventArgs e)
        {
            TextBox tx = sender as TextBox;
            foreach (Control ctr in pIniciar.Controls)
            {
                if (ctr is Panel && ctr.Name == "p" + tx.Tag.ToString())
                {
                    ctr.BackColor = Color.Black;
                }
            }
        }
        private void txtLeave_1(object sender, EventArgs e)
        {
            TextBox tx = sender as TextBox;
            foreach (Control ctr in pIniciar.Controls)
            {
                if (ctr is Panel && ctr.Name == "p" + tx.Tag.ToString())
                {
                    ctr.BackColor = Color.Silver;
                }
            }
        }
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private bool controltimer = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!controltimer)
            {
                pContenedor.Left += 10;
                pRegistro.BringToFront();
                if (pContenedor.Left == 470)
                {
                    timer1.Stop();
                    controltimer = true;
                }
            }
            else
            {
                pContenedor.Left -= 10;
                pIniciar.BringToFront();
                if (pContenedor.Left == 0)
                {
                    timer1.Stop();
                    controltimer = false;
                }
            }
        }
        private void btnAcceder_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }


       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       

        private void pRegistro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAcceder_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
