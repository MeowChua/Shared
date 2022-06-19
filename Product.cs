using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoMinhCanh_NashTech.Shared
{
    public class Product
    {
        // id san pham
        public int Id { get; set; }
        // tieu de
        [Required]
        public string Title { get; set; } = string.Empty;

        // mo ta
        public string Description { get; set; } = string.Empty;
        // link hinh
        public string ImageUrl { get; set; } = string.Empty;
        // danh sach hinh
        public List<Image> Images { get; set; } = new List<Image>();
        // chi muc
        public Category? Category { get; set; }
        // lay id cua clss chi muc
        public int CategoryId { get; set; }
        public bool Featured { get; set; } = false;
        // tao ds bien thee san pham
        public List<ProductVariant> Variants { get; set; } = new List<ProductVariant>();
        public bool Visible { get; set; } = true;
        public int Ranking { get; set; }
        public bool Deleted { get; set; } = false;
        [NotMapped]
        public bool Editing { get; set; } = false;
        [NotMapped]
        public bool IsNew { get; set; } = false;
        
    }
}
