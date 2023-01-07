using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public object[] argumentos;        
        public string email;
        public Banco miBanco;
        public int dni;
        public int id;
        public int usr;
        public int uId;
        public int pId;
        public string cbu;
        public float saldo;
        public string numero;
        public string codigoV;
        public float limite;
        public float consumos;
        public Pago pago;
        public TransfDelegado TransfEvento;
        public TransfDelegado TransfEvento2;
        public TransfDel TransfEventoCerrarSesion;        

        public Form3()
        {
            InitializeComponent();
            miBanco = new Banco();            
        }
        public Form3(string email , Banco b)
        {
            this.miBanco = b;
            this.email = email;            
        }
        public Form3(object[] args)
        {
            InitializeComponent();
            miBanco = (Banco)args[1];
            label2.Text = miBanco.mostrarEmail();
            label27.Text = miBanco.mostrarID().ToString();
            if (!miBanco.esADM())
            {
                tabControl1.TabPages.Remove(tabPage5);
            }
            refreshDataMovAdmin();
            refreshData();            
            refreshDataPagoRealizado();
            refreshDataPagos();
            refreshDataPlazo();
            refreshDataTarjeta();
            refreshDataUsuarios();
        }
        private void agregarCaja_Click(object sender, EventArgs e)
        {
            if (this.miBanco.crearCajaDeAhorro())
            {
                MessageBox.Show("Caja creada con exito");
                refreshData();
            }
            else MessageBox.Show("Error en la creacion de la caja");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            refreshData();
        }
        private void refreshData()
        {
            dataGridView1.Rows.Clear();
            if (miBanco.esADM())
            {
                foreach (CajaDeAhorro caja in miBanco.obtenerCajasBanco())
                {
                    dataGridView1.Rows.Add(caja.toArray());
                }
            }
            else
                foreach (CajaDeAhorro caja in miBanco.obtenerCajasDeAhorro())
                {
                    dataGridView1.Rows.Add(caja.toArray());
                }
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        /*private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {            
            int id = Int32.Parse(dataGridView1[0, e.RowIndex].Value.ToString());
            this.TransfEvento(id);
        } */       

        private void cerrarSesion_click(object sender, EventArgs e)
        {
            this.miBanco.cerrarSesion();
            MessageBox.Show("El usuario cerro sesion");
            this.TransfEventoCerrarSesion();
        }
        public delegate void TransfDel();

        private void crearPago_click(object sender, EventArgs e)
        {            
            this.miBanco.agregarPago(textBox1.Text, float.Parse(textBox2.Text), false, " ");
            MessageBox.Show("Pago creado con exito");
            refreshDataPagos();
        }

        private void verPagos_click(object sender, EventArgs e)
        {
            refreshDataPagos();
            refreshDataPagoRealizado();
        }
        private void refreshDataPagos()
        {
            dataGridView3.Rows.Clear();
            if (miBanco.esADM())
            {
                foreach(Pago p in this.miBanco.obtenerPagosBanco())
                {
                    if (p.pagado == false)
                    {
                        dataGridView3.Rows.Add(p.toArray());
                    }
                } 
            } else {
                foreach (Pago pago in this.miBanco.obtenerPagos())
                {
                    if (pago.pagado == false)
                    {
                        dataGridView3.Rows.Add(pago.toArray());
                    }
                }
            }                                 
        }
        private void refreshDataPagoRealizado()
        {
            dataGridView2.Rows.Clear();
            if (miBanco.esADM())
            {
                foreach (Pago pago in this.miBanco.obtenerPagosBanco())
                {
                    if (pago.pagado == true)
                    {
                        dataGridView2.Rows.Add(pago.toArray2());
                    }
                }
            }
            else
            {
                foreach (Pago pago in this.miBanco.obtenerPagos())
                {
                    if (pago.pagado == true)
                    {
                        dataGridView2.Rows.Add(pago.toArray2());
                    }
                }
            }
        }

        /*private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Int32.Parse(dataGridView3[0, e.RowIndex].Value.ToString());
            this.TransfEvento2(id);
        }*/
        public delegate void TransfDelegado(int id);       

        private void crearPlazo_click(object sender, EventArgs e)
        {

            if (this.miBanco.crearPlazoFijo(int.Parse(textBox3.Text), int.Parse(label27.Text), float.Parse(textBox4.Text)))
            {
                this.miBanco.retirar(int.Parse(textBox3.Text), float.Parse(textBox4.Text));
                MessageBox.Show("Plazo Fijo creado con exito");
                refreshDataPlazo();
            }
            else MessageBox.Show("No tiene saldo suficiente / La caja no le corresponde a este usuario");          
            
        }
        
        private void refreshDataPlazo()
        {
            dataGridView4.Rows.Clear();
            if (miBanco.esADM())
            {
                foreach (PlazoFijo plazo in this.miBanco.obtenerPlazosBanco())
                {
                    dataGridView4.Rows.Add(plazo.toArray());
                }
            }
            else
            {
                foreach (PlazoFijo plazo in this.miBanco.obtenerPlazosFijos())
                {
                    dataGridView4.Rows.Add(plazo.toArray());
                }
            }
        }

        private void mostrarPlazos_click(object sender, EventArgs e)
        {
            refreshDataPlazo();
        }        

        private void button8_Click(object sender, EventArgs e)
        {       
                this.miBanco.crearTarjeta();
                MessageBox.Show("Tarjeta creada con exito!"); 
                refreshDataTarjeta();
        }
        private void refreshDataTarjeta()
        {
            dataGridView5.Rows.Clear();
            if (miBanco.esADM())
            {
                foreach (Tarjeta tarjeta in miBanco.obtenerTarjetasBanco())
                {
                    dataGridView5.Rows.Add(tarjeta.toArray());
                }
            }
            else
            {
                foreach (Tarjeta tarjeta in miBanco.obtenerTarjetas())
                {
                    dataGridView5.Rows.Add(tarjeta.toArray());
                }
            }
        }
        private void refreshDataUsuarios()
        {
            dataGridView7.Rows.Clear();
            foreach (Usuario u in miBanco.obtenerUsuarios())
            {
                dataGridView7.Rows.Add(u.toArray());
            }
        }
        private void mostrarTarjetas_click(object sender, EventArgs e)
        {
            refreshDataTarjeta();
        }
        private void eliminarCaja_click(object sender, EventArgs e)
        {
            if (miBanco.borrarCajaAhorro(int.Parse(label15.Text)))
            {
                MessageBox.Show("Caja borrada con exito");
                refreshData();
            }
            else MessageBox.Show("La caja todavia tiene saldo");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            label12.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            label15.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            label16.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            refreshDataMovimientos();
        }

        private void depositar_Click(object sender, EventArgs e)
        {        
              this.miBanco.depositar(int.Parse(label15.Text), float.Parse(montoBox.Text));
              MessageBox.Show("Depositado con exito");                
              refreshDataMovimientos();
              refreshData();
        }

        private void refreshMovimientos_Click(object sender, EventArgs e)
        {
            refreshDataMovimientos();
        }
        public void refreshDataMovimientos()
        {
            dataGridView6.Rows.Clear();
            foreach (Movimiento mov in this.miBanco.obtenerMovimientos(int.Parse(label15.Text)))
                {
                    dataGridView6.Rows.Add(mov.toArray());
                }
        }
        
        public void refreshDataMovAdmin()
        {
            dataGridView6.Rows.Clear();
            if (miBanco.esADM())
            {
                foreach (Movimiento mov in this.miBanco.obtenerMovimientosBanco())
                {
                    dataGridView6.Rows.Add(mov.toArray());
                }
            }
        }

        private void transferir_Click(object sender, EventArgs e)
        {
            if (this.miBanco.transferir(int.Parse(label15.Text), int.Parse(cajaDestino.Text), float.Parse(montoBox.Text)))
            {
                MessageBox.Show("Transferencia realizada al id: " + cajaDestino.Text);
                refreshData();
                refreshDataMovimientos();
            }
            else MessageBox.Show("No tiene saldo suficiente");
        }

        private void retirar_Click(object sender, EventArgs e)
        {
            
            if (this.miBanco.retirar(int.Parse(label15.Text), float.Parse(montoBox.Text)))
            {
                MessageBox.Show("Retirado con exito");
                refreshData();
                refreshDataMovimientos();
            }
            else MessageBox.Show("No tiene saldo suficiente");
           
        }
        private void dataGridView5_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            label11.Text = dataGridView5[0, e.RowIndex].Value.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (this.miBanco.modificarTarjeta(int.Parse(label11.Text), float.Parse(limiteBox.Text)))
            {
                MessageBox.Show("Tarjeta modificada con exito");
                refreshDataTarjeta();
            }
            else MessageBox.Show("El limite no puede ser menor al consumo!");
        }
        private void eliminarTarjeta(object sender, EventArgs e)
        {
            if (this.miBanco.borrarTarjeta(int.Parse(label11.Text)))
            {
                MessageBox.Show("Tarjeta borrada con exito");
                refreshDataTarjeta();
            } else MessageBox.Show("La tarjeta tiene consumos, no se puede eliminar");
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idPago.Text = dataGridView3[0, e.RowIndex].Value.ToString();
            label25.Text = dataGridView3[0, e.RowIndex].Value.ToString();
            refreshDataPagos();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (this.miBanco.agregarTitular(int.Parse(label15.Text), int.Parse(textBox5.Text)))
            {
                MessageBox.Show("Titular agregado con exito");
                refreshData();
            }
            else MessageBox.Show("El usuario ya es titular de esta caja");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.miBanco.eliminarTitular(int.Parse(label15.Text), int.Parse(textBox5.Text)))
            {
                MessageBox.Show("Titular eliminado de la caja");
                refreshData();
            }
            else MessageBox.Show("La caja no puede quedar sin titulares");

        }
        private void verUsuarios(object sender, EventArgs e)
        {
            dataGridView7.Rows.Clear();
            refreshDataUsuarios();
        }

        private void dataGridView7_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            label20.Text = dataGridView7[0, e.RowIndex].Value.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (miBanco.modificarUsuario(int.Parse(label20.Text), textBox6.Text, textBox7.Text))
            {
                MessageBox.Show("Usuario modificado con exito!");
                refreshDataUsuarios();
            }
            else MessageBox.Show("Los datos son incorrectos");
        }
        private void pagarConTarjeta_click(object sender, EventArgs e)
        {
            if (this.miBanco.pagarConTarjeta(int.Parse(label25.Text), int.Parse(textBox8.Text), int.Parse(label27.Text)))
            {
                MessageBox.Show("Pagado con exito");                
                refreshDataPagos();
                refreshDataTarjeta();
                refreshDataPagoRealizado();
            }
            else { MessageBox.Show("No tiene saldo suficiente o la tarjeta no le corresponde a este usuario!"); }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (this.miBanco.pagarConCbu(int.Parse(label25.Text), int.Parse(textBox8.Text), int.Parse(label27.Text)))
            {
                MessageBox.Show("Pagado con exito");                
                refreshData();
                refreshDataPagos();
                refreshDataPagoRealizado();
            }
            else 
            {
                MessageBox.Show("No tiene saldo suficiente o la caja no le corresponde a este usuario!"); 
            }
        }

        private void eliminarUsuario_Click(object sender, EventArgs e)
        {
            if (miBanco.eliminarUsuario(int.Parse(label20.Text)))
            {
                MessageBox.Show("Usuario eliminado con exito!");
                refreshDataUsuarios();
            }
            else MessageBox.Show("No se puede eliminar al usuario");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            dataGridView8.Rows.Clear();
            string detalle = comboBox1.Text;
            foreach (Movimiento movimiento in this.miBanco.buscarMovimientoPorDetalle(int.Parse(label15.Text), detalle))
            {
                dataGridView8.Rows.Add(movimiento.toArray());
            }
        }
    }
}
