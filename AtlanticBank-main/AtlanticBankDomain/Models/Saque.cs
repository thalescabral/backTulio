using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AtlanticBankDomain.Models
{
    public class Saque : Entity
    {
        [Key]
        [Required]
        public Guid IdCashMachine { get; set; }

        [Required]
        [Range(1, 1000)]
        [Column(TypeName = "decimal(4,2)")]
        public decimal Value { get; set; }

    }
}
