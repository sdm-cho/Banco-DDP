using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Banco banco;        
        Form2 hijoLogin;
        Form3 hijoMain;
        DetalleCaja detalle;
        internal string texto;
        string email;
        string password;
        bool logueado;
        int pago;
        string cbu;
        public bool touched;    
        
        
       
        public Form1()
        {
            InitializeComponent();
            this.banco = new Banco();
            this.logueado = false;
            this.hijoLogin = new Form2(banco);
            this.hijoLogin.logueado = false;
            this.hijoLogin.MdiParent = this;
            this.hijoLogin.TransfEvento += TransfDelegado;            
            hijoLogin.Show();                       
            touched = false;

        }
        private void TransfDelegado(string Email, string Pass)
        {
            this.email = Email;
            this.password = Pass;
            if (banco.iniciarSesion(email,password))
            {
                MessageBox.Show("Usuario logueado, Email: " + email, "titulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.hijoLogin.Close();
                this.hijoMain = new Form3(new object[] { email, banco });
                this.hijoMain.email = Email;
                this.hijoMain.MdiParent = this;
                this.hijoMain.TransfEvento += this.TransfDelegadoDetalles;
                this.hijoMain.TransfEventoCerrarSesion += this.TransfDelegadoMainALogin;                               
                this.hijoMain.Show();
            }
            else
            {
                MessageBox.Show("Inicio de sesion incorrecto", "titulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hijoLogin.Show();
            }
        }
        public void TransfDelegadoDetalles(int id)
        {            
            this.detalle = new DetalleCaja(new object[] { banco, id });
            this.detalle.TransfEventoEliminarCaja += this.TransfDelegadoDetallesAMain;
            this.detalle.MdiParent = this;
            this.detalle.Show();
        }
        public void TransfDelegadoDetallesAMain()
        {
            this.detalle.Close();
            this.hijoMain = new Form3(new object[] { email, banco });            
            this.hijoMain.MdiParent = this;
            this.hijoMain.TransfEvento += this.TransfDelegadoDetalles;
            this.hijoMain.Show();
        }
        public void TransfDelegadoMainALogin()
        {
            this.hijoMain.Close();
            this.hijoLogin = new Form2(banco);
            this.hijoLogin.MdiParent = this;
            this.hijoLogin.TransfEvento += TransfDelegado;
            this.hijoLogin.Show();
        }
    }
}