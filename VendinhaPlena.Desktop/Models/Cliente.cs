using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace VendinhaPlena.Desktop.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O Nome Completo é obrigatório.")]
        [StringLength(150, ErrorMessage = "O nome deve ter no máximo 150 caracteres.")]
        public string NomeCompleto { get; set; } = string.Empty;

        [Required(ErrorMessage = "O CPF é obrigatório.")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "O CPF deve conter exatamente 11 números.")]
        public string Cpf { get; set; } = string.Empty;

        [Required(ErrorMessage = "A Data de Nascimento é obrigatória.")]
        public DateTime DataNascimento { get; set; }

        [EmailAddress(ErrorMessage = "O formato do e-mail é inválido.")]
        public string? Email { get; set; }

        public int Idade
        {
            get
            {
                var idade = DateTime.Today.Year - DataNascimento.Year;
                if (DataNascimento.Date > DateTime.Today.AddYears(-idade)) idade--;
                return idade;
            }
        }

        public ICollection<Divida> Dividas { get; set; } = new List<Divida>();
        public decimal TotalDevido => Dividas.Where(d => !d.Situacao).Sum(d => d.Valor);
    }
}