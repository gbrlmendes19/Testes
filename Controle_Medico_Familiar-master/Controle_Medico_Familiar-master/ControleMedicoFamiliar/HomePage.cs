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
    public partial class HomePage : Form
    {
        #region Instancias
        RegistroVacina regVacina = new RegistroVacina();
        RegistroConsulta regConsulta = new RegistroConsulta();
        ConsultaAgendada regConsultaAgendada = new ConsultaAgendada();

        #endregion

        public HomePage()
        {
            InitializeComponent();

        }

        private void HomePage_Load(object sender, EventArgs e)
        {

            List<RegistroVacina> listvacinas = new List<RegistroVacina>();
            listvacinas = regVacina.Listar();
            dtgVacinas.DataSource = listvacinas;

            List<RegistroConsulta> listconsultas = new List<RegistroConsulta>();
            listconsultas = regConsulta.Listar();
            dtgConsultas.DataSource = listconsultas;

            List<ConsultaAgendada> listConsultaAgendada = new List<ConsultaAgendada>();
            listConsultaAgendada = regConsultaAgendada.Listar();
            dtgConsultasAgendadas.DataSource = listConsultaAgendada;
        }

        #region Não usados
        private void btnCadastrarFamiliar_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrarMedico_Click(object sender, EventArgs e)
        {

        }



        private void btnCadatrarVacina_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Botões
        //Botão para fechar o form
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Opções do Menu
        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajuda form = new Ajuda();
            form.Show();
        }

        private void vacinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroVacinas cadastroVacinas = new CadastroVacinas();
            cadastroVacinas.ShowDialog();
        }

        private void médicosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void familiaresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroConsultas view = new RegistroConsultas();
            this.Hide();
            view.Show();
        }

        private void vacinasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroVacinas view = new RegistroVacinas();
            view.Show();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgConsultas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroFamiliares cadastroFamiliares = new CadastroFamiliares();
            cadastroFamiliares.ShowDialog();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarFamiliares listar = new ListarFamiliares();
            listar.Show();
        }

        private void vacinasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastroVacinas form = new CadastroVacinas();
            form.Show();
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListarVacinas form = new ListarVacinas();
            form.Show();
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CadastroMedicos form = new CadastroMedicos();
            form.Show();
        }

        private void listarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ListarMedicos form = new ListarMedicos();
            form.Show();
        }

        private void consultasAgendadasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            CadastroConsultaAgendada form = new CadastroConsultaAgendada();
            form.Show();
        }
        #endregion

        private void dtgConsultasAgendadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
