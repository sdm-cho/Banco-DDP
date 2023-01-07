using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class DetalleCaja : Form
    {
               
        public Banco miBanco;
        public int id;
        public string Cbu;
        public int idDestino;
        public TransfDelegado TransfEventoEliminarCaja;

        public DetalleCaja(Banco b, int id)
        {
            this.miBanco = b;
            this.id = id;            
        }
        public DetalleCaja(object[] args)
        {
            InitializeComponent();
            miBanco = (Banco)args[0];                    
        }
        public void refreshData()
        {            
            dataGridView1.Rows.Clear();
            foreach (Movimiento mov in this.miBanco.obtenerMovimientos(id))             
                dataGridView1.Rows.Add(mov.toArray());            
        }        

        private void depositar_Click(object sender, EventArgs e)
        {            
            float monto = float.Parse(this.textBox1.Text);
            this.miBanco.depositar(id, monto);
            MessageBox.Show("Depositado con exito");
            label5.Text = miBanco.obtenerSaldoCaja(id).ToString();
            refreshData();
        }       

        private void mostrarDatos_Click(object sender, EventArgs e)
        {
            refreshData();            
        }

        private void transferir_Click(object sender, EventArgs e)
        {           
            
            if (this.miBanco.transferir(id, id, int.Parse(label5.Text))) { 
            MessageBox.Show("Transferencia realizada al cbu: " + this.textBox2.Text);
                refreshData();
        } else MessageBox.Show("No tiene saldo suficiente");

            label5.Text = miBanco.obtenerSaldoCaja(id).ToString();
        }

        private void retirar_Click(object sender, EventArgs e)
        {
            float monto = float.Parse(this.textBox1.Text);
            if (this.miBanco.retirar(id, monto)) {
                MessageBox.Show("Retirado con exito");
                refreshData();
             } else MessageBox.Show("No tiene saldo suficiente");
            label5.Text = miBanco.obtenerSaldoCaja(id).ToString();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (this.miBanco.borrarCajaAhorro(id))
            {
                MessageBox.Show("Caja borrada con exito");
            }
            this.TransfEventoEliminarCaja();
        }
        public delegate void TransfDelegado();

        private void dataGridView2_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();            
        }
    }

}