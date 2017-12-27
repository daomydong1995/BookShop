namespace BookShop.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHUDE")]
    public partial class CHUDE
    {
        [Key]
        public int MaCD { get; set; }

        [StringLength(50)]
        public string Tenchude { get; set; }
    }
}
