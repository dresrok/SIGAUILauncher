using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using SIGAUILauncher.Views;

namespace SIGAUILauncher
{
    static class Program
    {
        #region 1:Atributos
        #region 1.1:Propios y Derivables
        private static string atrRutaAbsoluta = "";
        private static string atrRutaProyecto = "";
        private static string atrRutaArchivoFaseI_II = "Cau\\SIGAUI_2014-2015\\SIGAUI_Fase_I-II.mxd";
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
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DirectoryInfo myDirectory = new DirectoryInfo(Environment.CurrentDirectory);
            Program.atrRutaProyecto = myDirectory.Parent.Parent.FullName;
            Program.atrRutaAbsoluta = Program.atrRutaProyecto + Path.DirectorySeparatorChar + Program.atrRutaArchivoFaseI_II;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new clsLauncher());
        }
        #endregion
        #region 2.2:Accesores
        #region 2.2.1:Accesores De Atributo Propio y Derivable
        public static string getRutaAbsoluta()
        {
            return Program.atrRutaAbsoluta;
        }
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
