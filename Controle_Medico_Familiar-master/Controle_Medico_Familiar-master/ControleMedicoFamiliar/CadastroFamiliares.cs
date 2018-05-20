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
    public partial class CadastroFamiliares : Form
    {
        static string nome;
        static string parentesco;

        Familiares familiares = new Familiares();
        public CadastroFamiliares()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {


        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            if(txtNome.Text == "")
            {
                MessageBox.Show("Digite o nome do familiar a ser registrado.");
            }
            else if (cbParentesco.Text == "")
            {
                MessageBox.Show("Selecione um parentesco!");
            }
            else
            {
                nome = txtNome.Text;
                parentesco = cbParentesco.SelectedItem.ToString();

                familiares.Adicionar(nome, parentesco);
                MessageBox.Show("Familiar salvo com sucesso!");
            }
            txtNome.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CadastroFamiliares_Load(object sender, EventArgs e)
        {
            cbParentesco.SelectedIndex = 0;
        }
    }
}
