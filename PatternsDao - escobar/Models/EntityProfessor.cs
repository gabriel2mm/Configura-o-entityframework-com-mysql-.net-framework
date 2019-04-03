using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDao___escobar.Models
{
    [Table("Professor")]
    class EntityProfessor
    {
        [Key]
        [Column("ID")]
        public int ID { get; set; }

        [Column("Professor")]
        public string Nome { get; set; }
    }
}
