using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleMedicoFamiliar
{
    public partial class ListarMedicos : Form
    {
        Medicos medicos = new Medicos();
        public ListarMedicos()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListarMedicos_Load(object sender, EventArgs e)
        {
            List<Medicos> list = new List<Medicos>();
            list = medicos.Listar();
            dataGridView1.DataSource = list;
        }
    }
}
