using Mevzuat6n._4Core.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mevzuat6n._1Entities.Entities
{
    public class Image: EntityBase
    {
        public Image()
        {
            Users = new HashSet<AppUser>();
        }
        public Image(string fileName, string fileType, string createdBy)
        {
            FileName = fileName;
            FileType = fileType;
            CreatedBy = createdBy;
        }
        public string? FileName { get; set; }
        public string? FileType { get; set; }

        public ICollection<Article>? Articles { get; set; }
        public ICollection<AppUser> Users { get; set; }
    }
}
