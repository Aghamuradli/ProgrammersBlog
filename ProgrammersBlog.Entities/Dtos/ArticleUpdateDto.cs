using ProgrammersBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Entities.Dtos
{
    public class ArticleUpdateDto
    {
        [Required]
        public int Id { get; set; }
        [DisplayName("Başlıq")]
        [Required(ErrorMessage = "{0} alanı boş keçilməməlidir.")]
        [MaxLength(100, ErrorMessage = "{0} alanı {1} karakterdən böyük olmamalıdır.")]
        [MinLength(5, ErrorMessage = "{0} alanı {1} karakterdən küçük olmamalıdır.")]
        public string Title { get; set; }
        [DisplayName("Məzmun")]
        [Required(ErrorMessage = "{0} alanı boş keçilməməlidir.")]
        [MinLength(20, ErrorMessage = "{0} alanı {1} karakterdən küçük olmamalıdır.")]
        public string Content { get; set; }
        [DisplayName("Məzmun")]
        [Required(ErrorMessage = "{0} alanı boş keçilməməlidir.")]
        [MaxLength(250, ErrorMessage = "{0} alanı {1} karakterdən böyük olmamalıdır.")]
        [MinLength(5, ErrorMessage = "{0} alanı {1} karakterdən küçük olmamalıdır.")]
        public string Thumbnail { get; set; }
        [DisplayName("Tarix")]
        [Required(ErrorMessage = "{0} alanı boş keçilməməlidir.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{O:dd/MM/yyyy}")]
        public DateTime Date { get; set; }
        [DisplayName("Sea Yazıçı")]
        [Required(ErrorMessage = "{0} alanı boş keçilməməlidir.")]
        [MaxLength(50, ErrorMessage = "{0} alanı {1} karakterdən böyük olmamalıdır.")]
        [MinLength(0, ErrorMessage = "{0} alanı {1} karakterdən küçük olmamalıdır.")]
        public string SeoAuthor { get; set; }
        [DisplayName("Sea Açıqlama")]
        [Required(ErrorMessage = "{0} alanı boş keçilməməlidir.")]
        [MaxLength(150, ErrorMessage = "{0} alanı {1} karakterdən böyük olmamalıdır.")]
        [MinLength(0, ErrorMessage = "{0} alanı {1} karakterdən küçük olmamalıdır.")]
        public string SeoDescription { get; set; }
        [DisplayName("Sea Etiketlər")]
        [Required(ErrorMessage = "{0} alanı boş keçilməməlidir.")]
        [MaxLength(150, ErrorMessage = "{0} alanı {1} karakterdən böyük olmamalıdır.")]
        [MinLength(0, ErrorMessage = "{0} alanı {1} karakterdən küçük olmamalıdır.")]
        public string SeoTags { get; set; }
        [DisplayName("Kategoriya")]
        [Required(ErrorMessage = "{0} alanı boş keçilməməlidir.")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [DisplayName("Aktivdirmi?")]
        [Required(ErrorMessage = "{0} alanı boş keçilməməlidir.")]
        public bool IsActive { get; set; }
        [DisplayName("Silinsinmi?")]
        [Required(ErrorMessage = "{0} alanı boş keçilməməlidir.")]
        public bool IsDeleted { get; set; }
    }
}
