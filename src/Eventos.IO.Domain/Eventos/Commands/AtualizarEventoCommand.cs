using System;

namespace Eventos.IO.Domain.Eventos.Commands
{
    public class AtualizarEventoCommand : BaseEventoCommand
    {
        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="nome">nome</param>
        /// <param name="descricaoCurta">descricaoCurta</param>
        /// <param name="descricaoLonga">descricaoLonga</param>
        /// <param name="dataInicio">dataInicio</param>
        /// <param name="dataFim">dataFim</param>
        /// <param name="gratuito">gratuito</param>
        /// <param name="valor">valor</param>
        /// <param name="online">online</param>
        /// <param name="nomeEmpresa">nomeEmpresa</param>
        public AtualizarEventoCommand(Guid id, string nome, string descricaoCurta, string descricaoLonga, DateTime dataInicio, DateTime dataFim, bool gratuito, decimal valor, bool online, string nomeEmpresa, Guid organizadorId, Guid categoriaId)
        {
            Id = id;
            Nome = nome;
            DescricaoCurta = descricaoCurta;
            DescricaoLonga = descricaoLonga;
            DataInicio = dataInicio;
            DataFim = dataFim;
            Gratuito = gratuito;
            Valor = valor;
            Online = online;
            NomeEmpresa = nomeEmpresa;
            OrganizadorId = organizadorId;
            CategoriaId = categoriaId;
        }
    }
}
