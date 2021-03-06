﻿using Stove.Domain.Entities.Auditing;

namespace Stove.Demo.ConsoleApp.Nh.Entities
{
    public class Product : FullAuditedEntity
    {
        protected Product()
        {
        }

        public Product(string name) : this()
        {
            Name = name;
        }

        public virtual string Name { get; set; }
    }
}
