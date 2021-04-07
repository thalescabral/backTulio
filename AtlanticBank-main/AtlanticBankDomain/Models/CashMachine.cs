using AtlanticBankDomain.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace AtlanticBankDomain.Models
{
    public class CashMachine : Entity
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        public long Balance { get; set; }

        public int Status { get; set; }

        public int Two { get; set; }

        public int Five { get; set; }

        public int Ten { get; set; }

        public int Twenty { get; set; }

        public int Fifty { get; set; }
    }
}
