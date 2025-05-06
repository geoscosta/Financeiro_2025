using Domain.Interfaces.ICategoria;
using Domain.Interfaces.IServices;
using Entities.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Servicos
{
    public class CategoriaServico : ICategoriaService
    {
        private readonly InterfaceCategoria _interfaceCategoria;

        public CategoriaServico(InterfaceCategoria interfaceCategoria)
        {
            _interfaceCategoria = interfaceCategoria;
        }

        public async Task AdicionarCategoria(Categoria categoria)
        {
            var isValido = categoria.ValidarPropriedadeString(categoria.Name, "Nome");
            if (isValido)
            {
                await _interfaceCategoria.Add(categoria);
            }
        }

        public async Task AtualizarCategoria(Categoria categoria)
        {
            var isValido = categoria.ValidarPropriedadeString(categoria.Name, "Nome");
            if (isValido)
            {
                await _interfaceCategoria.Update(categoria);
            }
        }
    }
}
