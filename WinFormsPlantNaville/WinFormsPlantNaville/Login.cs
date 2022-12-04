using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Capa_Entidades;
using Capa_Negocio;

namespace WinFormsPlantNaville
{
    public partial class Login : Form
    {
        //Declaracion de variables que representa cada capa
        E_Users objeuser = new E_Users();
        N_Users objenuser = new N_Users();
        Inicio frm1 = new Inicio();

        //Variables para guardar los datos que necesita el programa
        public static string usuario_nombre;
        public static string area;

        /// <summary>
        /// Declaracion de funcion de logueo o de inicio de sesion
        /// </summary>
        void login_inc() 
        {
            //Creacion de tabla para validar los datos de los labels con los datos del SQL
            DataTable dt = new DataTable();
            objeuser.usuario = txtUsuario.Text;
            objeuser.clave = txtpass.Text;

            //Validacion de los datos con la Capa de Negocios
            dt = objenuser.N_user(objeuser);

            if(dt.Rows.Count > 0) 
            {
                //Proceso a mostrar si los datos se encuentran registrados
                MessageBox.Show("Bienvenido a PlantNaville " + dt.Rows[0][1].ToString(), " Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usuario_nombre = dt.Rows[0][1].ToString();
                area = dt.Rows[0][2].ToString();

                frm1.ShowDialog();

                Login login = new Login();
                login.ShowDialog();

                if (login.DialogResult == DialogResult.OK)
                    Application.Run(new Inicio());

                txtUsuario.Clear();
                txtpass.Clear();

            }

            else 
            {
                //Proceso a mostrar si los datos NO se encuentran registrados
                MessageBox.Show("Usuario o Contraseña incorrecta" + dt.Rows[0][1].ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        
        }

        public Login()
        {
            InitializeComponent();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            login_inc();
        }

        //Funcion del boton cancelar y/o cerrar
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
