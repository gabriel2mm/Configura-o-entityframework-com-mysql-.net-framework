using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDao___escobar.Models
{
    [Table("Aluno")]
    class EntityAluno
    {
        [Key]
        [Column("ID")]
        public int EntityAlunoID { get; set; }
        [Column("Nome")]
        public string Nome { get; set; }
        [Column("Sobrenome")]
        public string Sobrenome { get; set; }
        [Column("Ativo")]
        public bool Ativo { get; set; }
    }
}
