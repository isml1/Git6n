using Mevzuat6n._4Core.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mevzuat6n._1Entities.Entities
{
    public class Article: EntityBase
    {
        public Article()
        {

        }
        public Article(int mevzuatno, string mevzuattipi, string about, int versionno, int rgsayi, DateTime rgtarihi, DateTime yururluktarihi, DateTime sonlanmatarihi, string title, string content, Guid userId, string createdBy, Guid categoryId, Guid imageId)
        {
            MevzuatNo = mevzuatno;
            MevzuatTipi = mevzuattipi;
            About = about;
            VersionNo = versionno;
            RgSayi = rgsayi;
            RgTarihi = rgtarihi;
            YururlukTarihi = yururluktarihi;
            SonlanmaTarihi = sonlanmatarihi;
            Title = title;
            Content = content;
            UserId = userId;
            CategoryId = categoryId;
            ImageId = imageId;
            CreatedBy = createdBy;
        }
        public int? MevzuatNo { get; set; }
        public string? MevzuatTipi { get; set; }
        public string? About { get; set; }
        public int? VersionNo { get; set; }
        public int? RgSayi { get; set; }
        public DateTime? RgTarihi { get; set; }
        public DateTime? YururlukTarihi { get; set; }
        public DateTime? SonlanmaTarihi { get; set; } 
        public string? Title { get; set; }
        public string? Content { get; set; }
        public int ViewCount { get; set; } = 0;
        public Guid CategoryId { get; set; }
        public Category? Category { get; set; }
        public Guid? ImageId { get; set; }
        public Image? Image { get; set; }
        public Guid UserId { get; set; }
        public AppUser User { get; set; }
        public ICollection<ArticleVisitor> ArticleVisitors { get; set; }
    }
}
