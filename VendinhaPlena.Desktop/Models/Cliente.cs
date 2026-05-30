using System;
using System.Collections.Generic;
using System.Linq;

namespace VendinhaPlena.Desktop.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;
        public DateTime DataNascimento { get; set; }
        public string? Email { get; set; }

        public int Idade
        {
            get
            {
                var idade = DateTime.Today.Year - DataNascimento.Year;

                if (DataNascimento.Date > DateTime.Today.AddYears(-idade))
                {
                    idade--;
                }

                return idade;
            }
        }

        public ICollection<Divida> Dividas { get; set; } = new List<Divida>();

        public decimal TotalDevido => Dividas.Where(d => !d.Situacao).Sum(d => d.Valor);
    }
}