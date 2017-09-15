using System;

namespace Eventos.IO.Domain.Eventos.Commands
{
    public class RegistrarEventoCommand : BaseEventoCommand
    {
        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="nome">nome</param>
        /// <param name="dataInicio">dataInicio</param>
        /// <param name="dataFim">dataFim</param>
        /// <param name="gratuito">gratuito</param>
        /// <param name="valor">valor</param>
        /// <param name="online">online</param>
        /// <param name="nomeEmpresa">nomeEmpresa</param>
        /// <param name="organizadorId"></param>
        /// <param name="endereco"></param>
        /// <param name="categoria"></param>
        public RegistrarEventoCommand(string nome, string descricaoCurta, string descricaoLonga, DateTime dataInicio, DateTime dataFim, bool gratuito, decimal valor, bool online, string nomeEmpresa, Guid organizadorId, Guid categoriaId, IncluirEnderecoEventoCommand endereco)
        {
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
            Endereco = endereco;
        }

        public IncluirEnderecoEventoCommand Endereco { get; private set; }
    }
}
