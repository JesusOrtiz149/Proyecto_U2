using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_U2
{
    public partial class FrmAddShippers : Form
    {
        Datos dt = new Datos();
        bool bandera;
        int id;
        FrmEmbarcaderos embarcadero = new FrmEmbarcaderos();
        public FrmAddShippers()
        {
            InitializeComponent();
        }

        public FrmAddShippers(string suppID, string CompanyName, string Phone)
        {
            id = Convert.ToInt32(suppID);
            txtCompanyName.Text = CompanyName;  
            mtbPhone.Text = Phone;
        }

        private void FrmAddShippers_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Los datos son correctos?", "Shippers",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Dictionary<string, object> parametros = new Dictionary<string, object>();

                if (bandera == true)
                {
                    //Dictionary<string, object> parametros = new Dictionary<string, object>();
                    string consultaUpdate= "Update Shippers Set " +
                                            "CompanyName = @CompanyName," +
                                            "Phone = @Phone," + 
                                            " Where ShipperID = @ShipperID ";

                    parametros.Add("@CompanyName", txtCompanyName.Text);
                    parametros.Add("@Phone", mtbPhone);

                    bool j = dt.ejecutarABCModificado(consultaUpdate, parametros);
                    

                    if (j == true)
                    {
                        MessageBox.Show("Datos Actualizados", "Shippers",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Error", "Shippers", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    string consultaInsert= "Insert Into Shippers (CompanyName, Phone)" +
                                           "Values (@CompanyName, @Phone)";

                    parametros.Add("@CompanyName", txtCompanyName.Text);
                    parametros.Add("@Phone", mtbPhone.Text);

                    bool j = dt.ejecutarABCModificado(consultaInsert,parametros);

                    if (j == true)
                    {
                        MessageBox.Show("Embarcadero añadido", "Shippers",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        embarcadero.cargarDatosShippers();
                        mtbPhone.Clear();
                        txtCompanyName.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Error", "Shippers", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
