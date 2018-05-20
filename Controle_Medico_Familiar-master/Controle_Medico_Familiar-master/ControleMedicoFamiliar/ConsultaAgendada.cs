using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicoFamiliar
{
    class ConsultaAgendada
    {
        public string Pessoa { get; set; }
        public string Medico { get; set; }

        public DateTime Data { get; set; }

        public List<ConsultaAgendada> listConsultasAgendadas = new List<ConsultaAgendada>();

        public void Adicionar(string familiar, string medico, DateTime data)
        {
            listConsultasAgendadas.Add(new ConsultaAgendada() { Medico = medico, Pessoa = familiar, Data =  data});
        }

        public List<ConsultaAgendada> Listar() => listConsultasAgendadas;
    }
}
