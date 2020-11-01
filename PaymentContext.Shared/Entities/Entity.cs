using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Shared.Entities
{
    public abstract class Entity : Notifiable
    {

        public Guid Id { get; set; }

        protected Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}
