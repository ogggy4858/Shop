namespace Data.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Menu")]
    public partial class Menu
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Link { get; set; }

        [StringLength(100)]
        public string Target { get; set; }

        public int? MenuTypeID { get; set; }

        public virtual MenuType MenuType { get; set; }
    }
}
