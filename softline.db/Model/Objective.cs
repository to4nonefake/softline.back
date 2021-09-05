using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace softline.db.Model {
    public class Objective {

        [Key]
        [Required]
        public int id { get; set; }

        [Column(TypeName = "nvarchar(75)")]
        public string name { get; set; }

        [Column(TypeName = "nvarchar(1024)")]
        public string description { get; set; }

        [Required]
        public int status_id { get; set; }

    }
}