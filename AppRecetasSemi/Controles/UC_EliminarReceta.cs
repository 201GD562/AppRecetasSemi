using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppRecetas.Modelos;
namespace AppRecetas.Controles
{
    public partial class UC_EliminarReceta : UserControl
    {
        public Recetario Recetario { get; set; }
        public Receta Receta { get; set; }

        public UC_EliminarReceta()
        {
            InitializeComponent();
        }

        private void UC_EliminarReceta_Load_1(object sender, EventArgs e)
        {
            if (Recetario != null)
            {
                lstRecetas.DataSource = Recetario.MisRecetas;
                lstRecetas.DisplayMember = "Nombre";
            }
        }

        public void btnconfirmar_Click(object sender, EventArgs e)
        {
            Receta r = (Receta)lstRecetas.SelectedItem;
            lstRecetas.DataSource = null;
            Recetario.Eliminar(r);
            lstRecetas.DataSource = Recetario.MisRecetas;
            lstRecetas.DisplayMember = "Nombre";

        }
    }
}
