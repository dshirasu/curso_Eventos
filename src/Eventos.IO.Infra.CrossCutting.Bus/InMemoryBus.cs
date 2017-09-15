using Eventos.IO.Domain.Core.Bus;
using Eventos.IO.Domain.Core.Commands;
using Eventos.IO.Domain.Core.Events;
using Eventos.IO.Domain.Core.Events.Interfaces;
using Eventos.IO.Domain.Core.Notifications.Interfaces;
using Eventos.IO.Domain.Eventos.Events;
using System;

namespace Eventos.IO.Infra.CrossCutting.Bus
{
    public sealed class InMemoryBus : IBus
    {
        //Método de acesso ao contaner de injeção e dependencia
        public static Func<IServiceProvider> ContainerAcessor { get; set; }

        //
        private static IServiceProvider Container => ContainerAcessor();

        public void RaiseEvent<T>(T theEvent) where T : Event
        {
            Publish(theEvent);
        }

        public void SendCommand<T>(T theCommand) where T : Command
        {
            Publish(theCommand);
        }

        private static void Publish<T>(T message) where T : Message
        {
            if (Container == null) return;

            var obj = Container.GetService(message.MessageType.Equals("DomainNotification")
                ? typeof(IDomainNotificationHandler<T>)
                : typeof(IDomainNotificationHandler<T>));

            ((IHandler<T>)obj).Handle(message);
        }

    }
}
