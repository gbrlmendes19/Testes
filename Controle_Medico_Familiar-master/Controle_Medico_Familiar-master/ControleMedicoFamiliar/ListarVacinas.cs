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
    public partial class ListarVacinas : Form
    {
        Vacinas vacinas = new Vacinas();
        public ListarVacinas()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListarVacinas_Load(object sender, EventArgs e)
        {
            List<Vacinas> list = new List<Vacinas>();
            list = vacinas.Listar();
            dataGridView1.DataSource = list;
        }
    }
}
