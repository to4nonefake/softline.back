using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace softline.db.Model {
    public class Status {
        [Key]
        [Required]
        public int status_id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(75)")]
        public string status_name { get; set; }

    }
}
