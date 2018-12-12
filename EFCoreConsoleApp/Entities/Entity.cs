using System.ComponentModel.DataAnnotations;

namespace EFCoreConsoleApp.Entities
{
    public abstract class Entity
    {
        [Key]
        public int Id { get; set; }
    }
}
