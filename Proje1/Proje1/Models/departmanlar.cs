using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Proje1.Models
{
    public class departmanlar
    {
        [Key]

        public int ID { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [StringLength(50)]

        public string DepartmanAd { get; set; }

        [Column(TypeName = "VARCHAR(250)")]
        [StringLength(250)]

        public string Detay { get; set; }
        
        public IList<personel> _Personels { get; set; }
    }
}
