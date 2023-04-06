using Mevzuat6n._1Entities.DTOs.Categories;
using Mevzuat6n._1Entities.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mevzuat6n._1Entities.DTOs.Articles
{
    public class ArticleUpdateDto
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public CategoryDto? Category { get; set; }
        public virtual DateTime CreatedDate { get; set; } 
        public AppUser? User { get; set; }
        public string? CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public int ViewCount { get; set; }
        public virtual string? ModifiedBy { get; set; }
        public virtual string? DeletedBy { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }
        public virtual DateTime? DeletedDate { get; set; }
        public int? MevzuatNo { get; set; }
        public string? MevzuatTipi { get; set; }
        public string? About { get; set; }
        public int? VersionNo { get; set; }
        public int? RgSayi { get; set; }
        public DateTime? RgTarihi { get; set; }
        public DateTime? YururlukTarihi { get; set; }
        public DateTime? SonlanmaTarihi { get; set; }

        public Guid CategoryId { get; set; }

        public Image? Image { get; set; }
        public IFormFile? Photo { get; set; }

        public IList<CategoryDto> Categories { get; set; }
    }
}
