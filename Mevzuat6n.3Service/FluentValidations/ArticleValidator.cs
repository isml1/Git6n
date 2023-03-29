using FluentValidation;
using Mevzuat6n._1Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mevzuat6n._3Service.FluentValidations
{
    public class ArticleValidator : AbstractValidator<Article>
    {
        public ArticleValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty() 
                .NotNull()
                //.MinimumLength(3)
                //.MaximumLength(550)
                .WithName("Başlık");

            RuleFor(x => x.Content)
                .NotEmpty()
                .NotNull()
                //.MinimumLength(3)
                //.MaximumLength(550)
                .WithName("İçerik");
        }
    }
}
