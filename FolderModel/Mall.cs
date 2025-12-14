namespace KR.FolderModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Mall")]
    public partial class Mall
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        public int? Amount_P { get; set; }

        [StringLength(50)]
        public string Town { get; set; }

        [Column(TypeName = "money")]
        public decimal? Cost { get; set; }

        public double? Coeff_cost { get; set; }

        public int? Floor { get; set; }

        [StringLength(150)]
        public string Image { get; set; }
    }
}
