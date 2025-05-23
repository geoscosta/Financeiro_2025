﻿using Entities.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.IServices
{
    public interface IDespesaService
    {
        Task AdicionarDespesa(Despesa despesa);
        Task AtualizarDespesa(Despesa despesa);
        Task<object> CarregaGraficos(string emailUsuario);
    }
}
