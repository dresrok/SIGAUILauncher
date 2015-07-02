using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace SIGAUILauncher.Views
{
    public partial class clsLauncher : Form
    {
        #region 1:Atributos
        #region 1.1:Propios y Derivables
        private string atrRutaArchivoSigaui2014 = "D:\\LabSIG\\CAU\\Version_Organizada_Instalacion_Andres\\SIGAUI2014\\SIGAUI2014.mxd";
        private string atrRutaArchivoSigaui2015 = "D:\\LabSIG\\CAU\\Version_Organizada_Instalacion_Andres\\SIGAUI2014\\SIGAUI2014.mxd";
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
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
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
