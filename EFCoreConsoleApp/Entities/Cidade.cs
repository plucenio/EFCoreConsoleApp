using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreConsoleApp.Entities
{
    [Table("Cidades")]
    public class Cidade : Entity
    {
        public string Nome { get; set; }
    }
}
