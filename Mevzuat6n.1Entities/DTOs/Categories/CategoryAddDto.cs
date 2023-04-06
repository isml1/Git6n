using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mevzuat6n._1Entities.DTOs.Categories
{
    public class CategoryAddDto
    {
        public string Name { get; set; }
        public string? Subject { get; set; }
        public string? KeyWords { get; set; }
        public string? KeyStady { get; set; }
        public string? Description { get; set; } = null;
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
