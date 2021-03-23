using Almacen.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALMACEN.Win
{
    public partial class Form2 : Form
    {
        ReportedeVentasBL _reportedeventasBL;
        public Form2()
        {
            InitializeComponent();
            _reportedeventasBL = new ReportedeVentasBL();
            refrescardatos();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            refrescardatos();

        }
        private void refrescardatos()
        {
            var ListadeVentas = _reportedeventasBL.ObtenerVentas();
            listadeVentasBindingSource.DataSource = ListadeVentas;
            listadeVentasBindingSource.ResetBindings(false);
        }
    }
}
