using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Common
{
    public class NamedEntity:UserAuditedEntity
    {
        public string Name { get; set; }
    }
}
