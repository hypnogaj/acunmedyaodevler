using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Core.Entities
{
    internal class ProductImage
    {
        public int Id { get; set; }
        [Display(Name = "Resim Adı"),StringLength(240)]
        public int Name { get; set; }
        [Display(Name = "Resim Açıklaması"), StringLength(240)]
        public int Alt { get; set; }
        [Display(Name = "Ürün")]
        public int? ProductId { get; set; }
        public Product? Product { get; set; }
     
        
    }
}
