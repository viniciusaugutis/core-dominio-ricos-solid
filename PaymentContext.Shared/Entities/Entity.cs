﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Shared.Entities
{
    public abstract class Entity
    {
        public Guid Id { get; set; }

        protected Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}
