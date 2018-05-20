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
    public partial class CadastroMedicos : Form
    {
        Medicos medicos = new Medicos();
        public CadastroMedicos()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            if (this.txtNome.Text == "")
            {
                MessageBox.Show("Digite o nome do médico.");
            }
            else if (this.txtEspecialidade.Text == "")
            {
                MessageBox.Show("Digite a especialização do médico.");
            }
            else
            {
                string nome = txtNome.Text;
                string especialidade = txtEspecialidade.Text;

                medicos.Adicionar(nome, especialidade);
                MessageBox.Show("Médico adicionado com sucesso!");
            }
            this.txtNome.Text = "";
            this.txtEspecialidade.Text = "";
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
