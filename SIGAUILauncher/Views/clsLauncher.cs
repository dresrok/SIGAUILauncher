using System;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.IO;

namespace SIGAUILauncher.Views
{
    public partial class clsLauncher : Form
    {
        #region 1:Atributos
        #region 1.1:Propios y Derivables
        private string atrRutaAbsoluta = "";
        #endregion
        #region 1.2:Asociativos
        #endregion
        #region 1.3 Puente
        #endregion
        #region 1.4 Estado
        #endregion
        #endregion
        #region 2:Métodos
        #region 2.1:Constructor, Clonador, Comparador, Inicializador, Modificador y Destructor
        public clsLauncher()
        {
            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();
            Thread.Sleep(4500);
            InitializeComponent();
            t.Abort();            
        }
        private void clsLauncher_Load(object sender, EventArgs e)
        {
            this.Activate();
        }
        #endregion
        #region 2.2:Accesores
        #region 2.2.1:Accesores De Atributo Propio y Derivable
        #endregion
        #region 2.2.2:Accesores De Atributo Asociativo
        #endregion
        #endregion
        #region 2.3:Mutadores
        #region 2.3.1:Mutadores De Atributo Propio y Derivable
        #endregion
        #region 2.3.2:Mutadores Asociativos y Disociativos
        #endregion
        #endregion
        #region 2.4:Servicios CRUD
        public void SplashStart()
        {
            Application.Run(new clsLoader());
        }        
        #region 2.4.1:Registradores
        #endregion
        #region 2.4.2:Actualizadores
        #endregion
        #region 2.4.3:Eliminadores
        #endregion
        #endregion
        #region 2.5:Servicios de Persistencia
        #region 2.5.1:Materializadores
        #endregion
        #region 2.5.2:Des-Materializadores
        #endregion
        #region 2.5.3:Serializadores
        #endregion
        #region 2.5.4:Des-Serializadores
        #endregion
        #endregion
        #region 2.6:Servicios de Consulta
        #endregion
        #region 2.7: Servicios de IGU
        private void lblSitioCau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(this.lblSitioCau.Text);
        }             

        private void btnIniciarSigaui2014_Click(object sender, EventArgs e)
        {
            this.atrRutaAbsoluta = Program.getSigaui2014();
            Process.Start(this.atrRutaAbsoluta);
            this.Close();
        }

        private void btnIniciarSigaui2015_Click(object sender, EventArgs e)
        {
            this.atrRutaAbsoluta = Program.getSigaui2015();
            Process.Start(this.atrRutaAbsoluta);
            this.Close();
        }

        private void btnIniciarSigauiFases_Click(object sender, EventArgs e)
        {
            this.atrRutaAbsoluta = Program.getSigauiFases();
            Process.Start(this.atrRutaAbsoluta);
            this.Close();
        } 
        #region 2.7.1:Servicios de Navegación
        #endregion
        #region 2.7.2:Gestión Estado de Campos y Comandos IGU
        #endregion
        #region 2.7.3:Gestión de Campos IGU
        #endregion
        #region 2.7.4:Servición de Validación
        #endregion
        #region 2.7.5:Servicios de Mensajería
        #endregion
        #endregion
        #endregion
    }
}
