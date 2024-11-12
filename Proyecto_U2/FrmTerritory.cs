using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto_U2
{
    public partial class FrmTerritory : Form
    {
        bool bandera = false;
        string id;
        Datos dt= new Datos();
        public FrmTerritory()
        {
            InitializeComponent();

        }

        public FrmTerritory(string territoryID, string TerritoryDescription, int Region)
        {
            InitializeComponent();

            this.id = territoryID;
            txtTerritory.Text = TerritoryDescription;
            cmbRegion.SelectedValue = Region;
            bandera = true;

        }

        public string nAleatorio()
        {
            Random rnd = new Random();
            int n = rnd.Next(10000,99999);
            return n.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
                if (MessageBox.Show("¿Los datos son correctos?", "Territories",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (bandera == true)
                    {
                        

                        bool j = dt.ejecutarABC("Update Territories Set TerritoryDescription = '" +
                            txtTerritory.Text + "', RegionID = " + cmbRegion.SelectedIndex +
                            " Where TerritoryID = '" + id + "'");

                        if (j == true)
                        {
                            MessageBox.Show("Datos Actualizados", "Territories",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Error", "Territories", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                    else  
                    {
                   
                        bool j = dt.ejecutarABC("Insert Into Territories (TerritoryID, TerritoryDescription, RegionID) " +
                            "Values ('" + nAleatorio() + "', '" + txtTerritory.Text + "', " + cmbRegion.SelectedIndex + ")");

                        if (j == true)
                        {
                            MessageBox.Show("Territorio añadido", "Territories",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtTerritory.Clear();
                            cmbRegion.Text = "";
                            cmbRegion.SelectedIndex = 0;    

                        }
                        else
                        {
                            MessageBox.Show("Error", "Territories", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }

