using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WebCoreApp.Data.Enums;
using WebCoreApp.Data.Interfaces;
using WebCoreApp.Infrastucture.SharedKernel;

namespace WebCoreApp.Data.Entities
{
    [Table("Pages")]
    public class Page : DomainEntity<int>, ISwitchable
    {
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        
        [MaxLength(256)]
        [Required]
        public string Alias { get; set; }

        public string Content { get; set; }

        public Status Status { get; set; }
    }
}
