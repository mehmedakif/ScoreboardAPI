namespace ScoreboardAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class usersDB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string userID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int score { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short difficulty { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime date { get; set; }
    }
}
