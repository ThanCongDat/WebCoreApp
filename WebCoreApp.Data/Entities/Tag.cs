using System.ComponentModel.DataAnnotations;
using WebCoreApp.Infrastucture.SharedKernel;

namespace WebCoreApp.Data.Entities
{
    public class Tag : DomainEntity<string>
    {
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        [MaxLength(50)]
        [Required]
        public string Type { get; set; }
    }
}