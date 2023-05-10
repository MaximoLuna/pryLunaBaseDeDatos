using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;

namespace pryLunaBaseDeDatos
{


    public partial class frmPrincipal : Form
    {
        OleDbConnection miConexion;
        OleDbCommand miComando;
        OleDbDataReader Reader;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
             miConexion = new OleDbConnection();
             miConexion.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\mydatabase.mdb;";
             miConexion.Open();

             label1.Text = "Conexion Segura";
             label1.BackColor = Color.Green;
            }
           
            catch(Exception ex)
            {
                label1.Text = "Hubo un error: " + ex.Message + ex.Source;
                label1.BackColor = Color.Red;
            }



        }

        private void btnComando_Click(object sender, EventArgs e)
        {
            try
            {
                miComando = new OleDbCommand();
                miComando.Connection
            }
        }
    }

}
