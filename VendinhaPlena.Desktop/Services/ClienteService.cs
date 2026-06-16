using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using VendinhaPlena.Desktop.Data;
using VendinhaPlena.Desktop.Models;
using VendinhaPlena.Desktop.Validations;

namespace VendinhaPlena.Desktop.Services
{
    public class ClienteService
    {
        private readonly AppDbContext _bancoDeDados;

        public ClienteService(AppDbContext bancoDeDados)
        {
            _bancoDeDados = bancoDeDados;
        }

        public string SalvarCliente(Cliente cliente)
        {
            var contexto = new ValidationContext(cliente);
            var errosDeValidacao = new List<ValidationResult>();
            bool clienteValido = Validator.TryValidateObject(cliente, contexto, errosDeValidacao, true);

            if (!clienteValido)
            {
                return string.Join("\n", errosDeValidacao.Select(erro => erro.ErrorMessage));
            }

            if (cliente.Idade < 18)
            {
                return "O cliente precisa ter pelo menos 18 anos para ser cadastrado.";
            }

            if (!ValidadorCpf.IsCpfValido(cliente.Cpf))
            {
                return "O CPF informado não é válido.";
            }

            bool cpfJaCadastrado = _bancoDeDados.Clientes.Any(c => c.Cpf == cliente.Cpf && c.Id != cliente.Id);
            if (cpfJaCadastrado)
            {
                return "Este CPF já está cadastrado em nosso sistema.";
            }

            try
            {
                if (cliente.Id == 0)
                {
                    _bancoDeDados.Clientes.Add(cliente);
                }
                else
                {
                    _bancoDeDados.Clientes.Update(cliente);
                }

                _bancoDeDados.SaveChanges();
                return "Sucesso";
            }
            catch (Exception ex)
            {
                return $"Ocorreu um problema ao salvar no banco de dados: {ex.Message}";
            }
        }

        public (object Lista, int TotalPaginas) ObterClientes(string nomeBuscado, int paginaAtual, int quantidadePorPagina = 10)
        {
            var clientes = _bancoDeDados.Clientes.Include(c => c.Dividas).AsQueryable();

            if (!string.IsNullOrWhiteSpace(nomeBuscado))
            {
                clientes = clientes.Where(c => c.NomeCompleto.ToLower().Contains(nomeBuscado.ToLower()));
            }

            int totalDeClientes = clientes.Count();
            int totalDePaginas = (int)Math.Ceiling(totalDeClientes / (double)quantidadePorPagina);

            if (totalDePaginas == 0)
            {
                totalDePaginas = 1;
            }

            var clientesFormatados = clientes
                .OrderByDescending(c => c.Dividas.Where(d => !d.Situacao).Sum(d => d.Valor))
                .Skip((paginaAtual - 1) * quantidadePorPagina)
                .Take(quantidadePorPagina)
                .Select(c => new
                {
                    c.Id,
                    Nome = c.NomeCompleto,
                    c.Cpf,
                    c.Idade,
                    Total_Devido = $"R$ {c.TotalDevido:F2}"
                })
                .ToList();

            return (clientesFormatados, totalDePaginas);
        }

        public Cliente? ObterClientePorId(int id)
        {
            return _bancoDeDados.Clientes.Find(id);
        }
    }
}