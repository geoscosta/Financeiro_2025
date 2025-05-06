using Domain.Interfaces.IDespesa;
using Domain.Interfaces.IServices;
using Domain.Interfaces.ISistemaFinanceiro;
using Entities.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Servicos
{
    public class SistemaFinanceiroServico : ISistemaFinanceiroService
    {
        private readonly InterfaceSistemaFinanceiro _InterfaceSistemaFinanceiro;

        public SistemaFinanceiroServico(InterfaceSistemaFinanceiro interfaceSistemaFinanceiro)
        {
            _InterfaceSistemaFinanceiro = interfaceSistemaFinanceiro;
        }

        public async Task AdicionarSistemaFinanceiro(SistemaFinanceiro sistemaFinanceiro)
        {
            var isValido = sistemaFinanceiro.ValidarPropriedadeString(sistemaFinanceiro.Name, "Nome");
            if (isValido)
            {
                var data = DateTime.Now;

                sistemaFinanceiro.DiaFechamento = 1;
                sistemaFinanceiro.Ano = data.Year;
                sistemaFinanceiro.Mes = data.Month;
                sistemaFinanceiro.AnoCopia = data.Year;
                sistemaFinanceiro.MesCopia = data.Month;
                sistemaFinanceiro.GerarCopiaDespesa = true;

                await _InterfaceSistemaFinanceiro.Add(sistemaFinanceiro);
            }
        }

        public async Task AtualizarSistemaFinanceiro(SistemaFinanceiro sistemaFinanceiro)
        {
            var isValido = sistemaFinanceiro.ValidarPropriedadeString(sistemaFinanceiro.Name, "Nome");
            if (isValido)
            {
                sistemaFinanceiro.DiaFechamento = 1;
                await _InterfaceSistemaFinanceiro.Update(sistemaFinanceiro);
            }
        }
    }
}
