using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreConsoleApp.Entities
{
    public class Pessoa : Entity
    {
        public string Nome { get; set; }

        [ForeignKey("CidadeId")]
        public int CidadeId { get; set; }

        public Cidade Cidade { get; set; }
    }
}
