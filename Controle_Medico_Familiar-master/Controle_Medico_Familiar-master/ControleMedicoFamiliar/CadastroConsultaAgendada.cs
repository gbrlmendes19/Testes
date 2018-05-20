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
    public partial class CadastroConsultaAgendada : Form
    {
        ConsultaAgendada consulta = new ConsultaAgendada();
        Familiares familiar = new Familiares();
        Medicos medico = new Medicos();
        public CadastroConsultaAgendada()
        {
            InitializeComponent();
            List<Medicos> medicos = medico.Listar();

            foreach (var item in medicos)
            {
                cbMedicos.Items.Add(item.nome + " - " + item.especialidade);
            }

            List<Familiares> familiares = new List<Familiares>();
            familiares = familiar.Listar();
            foreach (var item in familiares)
            {
                cbFamiliar.Items.Add(item.Nome);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string Pessoa = cbFamiliar.SelectedItem.ToString();
            string Medico = cbMedicos.SelectedItem.ToString();
            DateTime Data = DateTime.Parse(txtData.Text);

            consulta.Adicionar(Pessoa, Medico, Data);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
