using System;
using System.ComponentModel.DataAnnotations;

namespace VendinhaPlena.Desktop.Models
{
    public class Divida
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "O valor da dívida é obrigatório.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O valor da dívida deve ser maior que zero.")]
        public decimal Valor { get; set; }

        public bool Situacao { get; set; } = false;
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public DateTime? DataPagamento { get; set; }

        public Cliente Cliente { get; set; } = null!;
    }
}