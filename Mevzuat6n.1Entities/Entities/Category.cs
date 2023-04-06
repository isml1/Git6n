using Mevzuat6n._4Core.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mevzuat6n._1Entities.Entities
{
    public class Category: EntityBase
    {
        public Category()
        {

        }
        public Category(string name, string createdBy)
        {
            Name = name;
            CreatedBy = createdBy;
        }
        public string? Name { get; set; }
        public string? Subject { get; set; }
        public string? KeyWords { get; set; }
        public string? KeyStady { get; set; }
        public string? Description { get; set; } = null;
        public ICollection<Article>? Articles { get; set; }
    }
}
