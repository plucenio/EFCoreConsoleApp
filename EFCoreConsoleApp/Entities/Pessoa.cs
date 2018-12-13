using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreConsoleApp.Entities
{
    [Table("Pessoas")]
    public class Pessoa : Entity
    {
        public string Nome { get; set; }

        [Column("Nascimento_nome_alterado")]
        public int AnoDeNascimento { get; set; }

        [NotMapped]
        public int Idade { get; set; }

        [ForeignKey("CidadeId")]
        public int CidadeId { get; set; }

        public Cidade Cidade { get; set; }
    }
}
