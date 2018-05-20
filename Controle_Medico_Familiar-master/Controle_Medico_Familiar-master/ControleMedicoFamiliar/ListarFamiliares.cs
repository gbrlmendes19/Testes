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
    public partial class ListarFamiliares : Form
    {
        Familiares familiares = new Familiares();

        public ListarFamiliares()
        {
            InitializeComponent();

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ListarFamiliares_Load(object sender, EventArgs e)
        {
            List<Familiares> list = new List<Familiares>();
            list = familiares.Listar();
            dataGridView1.DataSource = list;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
