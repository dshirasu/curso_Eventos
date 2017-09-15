using System;

namespace Eventos.IO.Domain.Eventos.Events
{
    public class EventoRegistradoEvent : BaseEventoEvent
    {
        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="nome">nome</param>
        /// <param name="dataInicio">dataInicio</param>
        /// <param name="dataFim">dataFim</param>
        /// <param name="gratuito">gratuito</param>
        /// <param name="valor">valor</param>
        /// <param name="online">online</param>
        /// <param name="nomeEmpresa">nomeEmpresa</param>
        public EventoRegistradoEvent(Guid id, string nome, DateTime dataInicio, DateTime dataFim, bool gratuito, decimal valor, bool online, string nomeEmpresa)
        {
            Id = id;
            Nome = nome;
            DataInicio = dataInicio;
            DataFim = dataFim;
            Gratuito = gratuito;
            Valor = valor;
            Online = online;
            NomeEmpresa = nomeEmpresa;

            AggregateId = id;
        }
    }
}
