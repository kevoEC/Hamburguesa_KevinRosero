using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburguesa_KevinRosero.Models
{
    [Table("burger")]
    public class BurgerKR
    {
        [PrimaryKey, AutoIncrement]
        public int Id_KevinR { get; set; }
        [MaxLength(250), Unique]
        public string Name_KevinR { get; set; }
        public string Description_KevinR { get; set; }
        public bool WithExtraCheese_KevinR { get; set; }
    }
}
