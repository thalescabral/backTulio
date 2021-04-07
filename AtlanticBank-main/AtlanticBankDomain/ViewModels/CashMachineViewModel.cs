using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace AtlanticBankDomain.ViewModels
{
    public class CashMachineViewModel
    {
        [Key]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [JsonProperty("Id")]
        public Guid Id { get; set; }

        [JsonProperty("Balance")]
        public long Balance { get; set; }

        [JsonProperty("Status")]
        public int Status { get; set; }

        [JsonProperty("Notas de dois reais")]
        public int Two { get; set; }

        [JsonProperty("Notas de cincro reais")]
        public int Five { get; set; }

        [JsonProperty("Notas de dez reais")]
        public int Ten { get; set; }

        [JsonProperty("Notas de vinte reais")]
        public int Twenty { get; set; }

        [JsonProperty("Notas de cinquenta reais")]
        public int Fifty { get; set; }
    }
}
