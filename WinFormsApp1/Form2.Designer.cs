namespace WinFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pContenedor = new System.Windows.Forms.Panel();
            this.pIniciar = new System.Windows.Forms.Panel();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.pCorreoI = new System.Windows.Forms.Panel();
            this.pContraI = new System.Windows.Forms.Panel();
            this.txtCorreoInicio = new System.Windows.Forms.TextBox();
            this.txtContraInicio = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pRegistro = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.pCorreo = new System.Windows.Forms.Panel();
            this.pContra = new System.Windows.Forms.Panel();
            this.pDni = new System.Windows.Forms.Panel();
            this.pApellido = new System.Windows.Forms.Panel();
            this.pNombre = new System.Windows.Forms.Panel();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pPrincipal.SuspendLayout();
            this.pContenedor.SuspendLayout();
            this.pIniciar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pPrincipal
            // 
            this.pPrincipal.AutoSize = true;
            this.pPrincipal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pPrincipal.BackgroundImage")));
            this.pPrincipal.Controls.Add(this.label13);
            this.pPrincipal.Controls.Add(this.btnAcceder);
            this.pPrincipal.Controls.Add(this.btnRegistrarse);
            this.pPrincipal.Controls.Add(this.label4);
            this.pPrincipal.Controls.Add(this.label2);
            this.pPrincipal.Controls.Add(this.label3);
            this.pPrincipal.Controls.Add(this.label1);
            this.pPrincipal.Location = new System.Drawing.Point(0, -1);
            this.pPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Size = new System.Drawing.Size(700, 702);
            this.pPrincipal.TabIndex = 0;
            this.pPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.pPrincipal_Paint);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(11, 394);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(673, 19);
            this.label13.TabIndex = 2;
            this.label13.Text = "Copyright &copy; GRUPO 2 BY ARROJO /ENRIQUEZ /GARAY HARTER / DIAZ MONFORT /SUAREZ" +
    " IBARRA ";
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.Color.Black;
            this.btnAcceder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAcceder.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceder.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAcceder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAcceder.Location = new System.Drawing.Point(48, 153);
            this.btnAcceder.Margin = new System.Windows.Forms.Padding(2);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(232, 36);
            this.btnAcceder.TabIndex = 1;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click_1);
            this.btnAcceder.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnAcceder.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.Color.Black;
            this.btnRegistrarse.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRegistrarse.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnRegistrarse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarse.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrarse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistrarse.Location = new System.Drawing.Point(380, 153);
            this.btnRegistrarse.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(232, 36);
            this.btnRegistrarse.TabIndex = 1;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            this.btnRegistrarse.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnRegistrarse.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(313, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Inicia sesión haciendo click en el boton de abajo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(341, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Registrate haciendo click en el boton de abajo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(57, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "¿Cuentas con un usuario?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(380, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Aún no tienes una cuenta?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pContenedor
            // 
            this.pContenedor.BackColor = System.Drawing.Color.White;
            this.pContenedor.Controls.Add(this.pIniciar);
            this.pContenedor.Controls.Add(this.pRegistro);
            this.pContenedor.Location = new System.Drawing.Point(0, 7);
            this.pContenedor.Margin = new System.Windows.Forms.Padding(2);
            this.pContenedor.Name = "pContenedor";
            this.pContenedor.Size = new System.Drawing.Size(329, 350);
            this.pContenedor.TabIndex = 2;
            // 
            // pIniciar
            // 
            this.pIniciar.BackColor = System.Drawing.Color.White;
            this.pIniciar.Controls.Add(this.btnIniciar);
            this.pIniciar.Controls.Add(this.pCorreoI);
            this.pIniciar.Controls.Add(this.pContraI);
            this.pIniciar.Controls.Add(this.txtCorreoInicio);
            this.pIniciar.Controls.Add(this.txtContraInicio);
            this.pIniciar.Controls.Add(this.label11);
            this.pIniciar.Controls.Add(this.label12);
            this.pIniciar.Controls.Add(this.label16);
            this.pIniciar.Controls.Add(this.pictureBox2);
            this.pIniciar.Location = new System.Drawing.Point(0, 5);
            this.pIniciar.Margin = new System.Windows.Forms.Padding(2);
            this.pIniciar.Name = "pIniciar";
            this.pIniciar.Size = new System.Drawing.Size(329, 340);
            this.pIniciar.TabIndex = 0;
            this.pIniciar.Paint += new System.Windows.Forms.PaintEventHandler(this.pRegistro_Paint);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.Black;
            this.btnIniciar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIniciar.ForeColor = System.Drawing.Color.White;
            this.btnIniciar.Location = new System.Drawing.Point(11, 217);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(2);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(308, 29);
            this.btnIniciar.TabIndex = 5;
            this.btnIniciar.Text = "Acceder";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // pCorreoI
            // 
            this.pCorreoI.BackColor = System.Drawing.Color.Silver;
            this.pCorreoI.Location = new System.Drawing.Point(11, 154);
            this.pCorreoI.Margin = new System.Windows.Forms.Padding(2);
            this.pCorreoI.Name = "pCorreoI";
            this.pCorreoI.Size = new System.Drawing.Size(308, 2);
            this.pCorreoI.TabIndex = 4;
            // 
            // pContraI
            // 
            this.pContraI.BackColor = System.Drawing.Color.Silver;
            this.pContraI.Location = new System.Drawing.Point(11, 194);
            this.pContraI.Margin = new System.Windows.Forms.Padding(2);
            this.pContraI.Name = "pContraI";
            this.pContraI.Size = new System.Drawing.Size(308, 2);
            this.pContraI.TabIndex = 4;
            // 
            // txtCorreoInicio
            // 
            this.txtCorreoInicio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreoInicio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCorreoInicio.Location = new System.Drawing.Point(11, 135);
            this.txtCorreoInicio.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreoInicio.Name = "txtCorreoInicio";
            this.txtCorreoInicio.Size = new System.Drawing.Size(308, 18);
            this.txtCorreoInicio.TabIndex = 3;
            this.txtCorreoInicio.Tag = "CorreoI";
            this.txtCorreoInicio.Enter += new System.EventHandler(this.txtEnter_1);
            this.txtCorreoInicio.Leave += new System.EventHandler(this.txtLeave_1);
            // 
            // txtContraInicio
            // 
            this.txtContraInicio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraInicio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContraInicio.Location = new System.Drawing.Point(11, 175);
            this.txtContraInicio.Margin = new System.Windows.Forms.Padding(2);
            this.txtContraInicio.Name = "txtContraInicio";
            this.txtContraInicio.PasswordChar = '*';
            this.txtContraInicio.Size = new System.Drawing.Size(308, 18);
            this.txtContraInicio.TabIndex = 3;
            this.txtContraInicio.Tag = "ContraI";
            this.txtContraInicio.Enter += new System.EventHandler(this.txtEnter_1);
            this.txtContraInicio.Leave += new System.EventHandler(this.txtLeave_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(8, 118);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 19);
            this.label11.TabIndex = 2;
            this.label11.Text = "Correo Electronico :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(8, 158);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 19);
            this.label12.TabIndex = 2;
            this.label12.Text = "Contraseña :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(95, 67);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 20);
            this.label16.TabIndex = 1;
            this.label16.Text = "Iniciar Sesión";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(85, 11);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(147, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pRegistro
            // 
            this.pRegistro.BackColor = System.Drawing.Color.White;
            this.pRegistro.Controls.Add(this.checkBox1);
            this.pRegistro.Controls.Add(this.btnRegistrar);
            this.pRegistro.Controls.Add(this.pCorreo);
            this.pRegistro.Controls.Add(this.pContra);
            this.pRegistro.Controls.Add(this.pDni);
            this.pRegistro.Controls.Add(this.pApellido);
            this.pRegistro.Controls.Add(this.pNombre);
            this.pRegistro.Controls.Add(this.txtCorreo);
            this.pRegistro.Controls.Add(this.txtContra);
            this.pRegistro.Controls.Add(this.txtDni);
            this.pRegistro.Controls.Add(this.txtApellido);
            this.pRegistro.Controls.Add(this.txtNombre);
            this.pRegistro.Controls.Add(this.label10);
            this.pRegistro.Controls.Add(this.label9);
            this.pRegistro.Controls.Add(this.label8);
            this.pRegistro.Controls.Add(this.label7);
            this.pRegistro.Controls.Add(this.label6);
            this.pRegistro.Controls.Add(this.label5);
            this.pRegistro.Controls.Add(this.pictureBox1);
            this.pRegistro.Location = new System.Drawing.Point(0, 5);
            this.pRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.pRegistro.Name = "pRegistro";
            this.pRegistro.Size = new System.Drawing.Size(329, 340);
            this.pRegistro.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(12, 313);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(105, 19);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Administrador";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Black;
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(11, 277);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(308, 29);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // pCorreo
            // 
            this.pCorreo.BackColor = System.Drawing.Color.Silver;
            this.pCorreo.Location = new System.Drawing.Point(11, 227);
            this.pCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.pCorreo.Name = "pCorreo";
            this.pCorreo.Size = new System.Drawing.Size(308, 2);
            this.pCorreo.TabIndex = 4;
            this.pCorreo.Enter += new System.EventHandler(this.txtEnter);
            this.pCorreo.Leave += new System.EventHandler(this.txtLeave);
            // 
            // pContra
            // 
            this.pContra.BackColor = System.Drawing.Color.Silver;
            this.pContra.Location = new System.Drawing.Point(11, 266);
            this.pContra.Margin = new System.Windows.Forms.Padding(2);
            this.pContra.Name = "pContra";
            this.pContra.Size = new System.Drawing.Size(308, 2);
            this.pContra.TabIndex = 4;
            this.pContra.Enter += new System.EventHandler(this.txtEnter);
            this.pContra.Leave += new System.EventHandler(this.txtLeave);
            // 
            // pDni
            // 
            this.pDni.BackColor = System.Drawing.Color.Silver;
            this.pDni.Location = new System.Drawing.Point(11, 187);
            this.pDni.Margin = new System.Windows.Forms.Padding(2);
            this.pDni.Name = "pDni";
            this.pDni.Size = new System.Drawing.Size(308, 2);
            this.pDni.TabIndex = 4;
            this.pDni.Enter += new System.EventHandler(this.txtEnter);
            this.pDni.Leave += new System.EventHandler(this.txtLeave);
            // 
            // pApellido
            // 
            this.pApellido.BackColor = System.Drawing.Color.Silver;
            this.pApellido.Location = new System.Drawing.Point(11, 148);
            this.pApellido.Margin = new System.Windows.Forms.Padding(2);
            this.pApellido.Name = "pApellido";
            this.pApellido.Size = new System.Drawing.Size(308, 2);
            this.pApellido.TabIndex = 4;
            this.pApellido.Tag = "";
            this.pApellido.Enter += new System.EventHandler(this.txtEnter);
            this.pApellido.Leave += new System.EventHandler(this.txtLeave);
            // 
            // pNombre
            // 
            this.pNombre.BackColor = System.Drawing.Color.Silver;
            this.pNombre.Location = new System.Drawing.Point(8, 108);
            this.pNombre.Margin = new System.Windows.Forms.Padding(2);
            this.pNombre.Name = "pNombre";
            this.pNombre.Size = new System.Drawing.Size(308, 2);
            this.pNombre.TabIndex = 4;
            this.pNombre.Enter += new System.EventHandler(this.txtEnter);
            this.pNombre.Leave += new System.EventHandler(this.txtLeave);
            // 
            // txtCorreo
            // 
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCorreo.Location = new System.Drawing.Point(11, 208);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(308, 18);
            this.txtCorreo.TabIndex = 3;
            this.txtCorreo.Tag = "Correo";
            this.txtCorreo.Enter += new System.EventHandler(this.txtEnter);
            this.txtCorreo.Leave += new System.EventHandler(this.txtLeave);
            // 
            // txtContra
            // 
            this.txtContra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContra.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContra.Location = new System.Drawing.Point(11, 247);
            this.txtContra.Margin = new System.Windows.Forms.Padding(2);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(308, 18);
            this.txtContra.TabIndex = 3;
            this.txtContra.Tag = "Contra";
            this.txtContra.Enter += new System.EventHandler(this.txtEnter);
            this.txtContra.Leave += new System.EventHandler(this.txtLeave);
            // 
            // txtDni
            // 
            this.txtDni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDni.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDni.Location = new System.Drawing.Point(11, 168);
            this.txtDni.Margin = new System.Windows.Forms.Padding(2);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(308, 18);
            this.txtDni.TabIndex = 3;
            this.txtDni.Tag = "Dni";
            this.txtDni.Enter += new System.EventHandler(this.txtEnter);
            this.txtDni.Leave += new System.EventHandler(this.txtLeave);
            // 
            // txtApellido
            // 
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtApellido.Location = new System.Drawing.Point(11, 128);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(308, 18);
            this.txtApellido.TabIndex = 3;
            this.txtApellido.Tag = "Apellido";
            this.txtApellido.Enter += new System.EventHandler(this.txtEnter);
            this.txtApellido.Leave += new System.EventHandler(this.txtLeave);
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(8, 89);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(308, 18);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.Tag = "Nombre";
            this.txtNombre.Enter += new System.EventHandler(this.txtEnter);
            this.txtNombre.Leave += new System.EventHandler(this.txtLeave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(8, 191);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 19);
            this.label10.TabIndex = 2;
            this.label10.Text = "Correo Electronico :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(8, 230);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 19);
            this.label9.TabIndex = 2;
            this.label9.Text = "Contraseña :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(8, 151);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "Dni :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(8, 112);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Apellido :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 72);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nombre :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(109, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Registro";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(77, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(700, 702);
            this.Controls.Add(this.pContenedor);
            this.Controls.Add(this.pPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(8, 8);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pPrincipal.ResumeLayout(false);
            this.pPrincipal.PerformLayout();
            this.pContenedor.ResumeLayout(false);
            this.pIniciar.ResumeLayout(false);
            this.pIniciar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pRegistro.ResumeLayout(false);
            this.pRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pPrincipal;
        private Button btnAcceder;
        private Button btnRegistrarse;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label1;
        private Panel pContenedor;
        private Panel pRegistro;
        private TextBox txtNombre;
        private Label label6;
        private Label label5;
        private PictureBox pictureBox1;
        private Button btnRegistrar;
        private Panel pCorreo;
        private Panel pContra;
        private Panel pDni;
        private Panel pApellido;
        private Panel pNombre;
        private TextBox txtCorreo;
        private TextBox txtContra;
        private TextBox txtDni;
        private TextBox txtApellido;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Panel pIniciar;
        private Button btnIniciar;
        private Panel pCorreoI;
        private Panel pContraI;
        private TextBox txtCorreoInicio;
        private TextBox txtContraInicio;
        private Label label11;
        private Label label12;
        private Label label16;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private Label label13;
        private CheckBox checkBox1;
    }
}