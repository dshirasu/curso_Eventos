using Eventos.IO.Domain.Core.Events.Interfaces;
using System;

namespace Eventos.IO.Domain.Eventos.Events
{
    public class EventoEventHandler : IHandler<EventoRegistradoEvent>, IHandler<EventoAtualizadoEvent>, IHandler<EventoExcluidoEvent>
    {
        public void Handle(EventoRegistradoEvent message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Evento Registrado com sucesso.");
            //Enviar e-mail ou log da informação ou notificação
        }

        public void Handle(EventoAtualizadoEvent message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Evento Atualizado com sucesso.");
            //Enviar e-mail ou log da informação ou notificação
        }

        public void Handle(EventoExcluidoEvent message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Evento excluído com sucesso.");
            //Enviar e-mail ou log da informação ou notificação
        }
    }
}
