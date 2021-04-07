using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace AtlanticBankDomain.ViewModels
{
    public class SaqueViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [JsonProperty("IdCashMachine")]
        public Guid IdCashMachine { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [Range(1, 1000, ErrorMessage = "O valor do saque deve ser maior que 0 e menor ou igual a 1000 reais.")]
        [JsonProperty("Value")]
        public decimal Value { get; set; }

        [JsonProperty("ClientId")]
        public string ClientId { get; set; }
    }
}
