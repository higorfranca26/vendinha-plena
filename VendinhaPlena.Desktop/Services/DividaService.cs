using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using VendinhaPlena.Desktop.Data;
using VendinhaPlena.Desktop.Models;

namespace VendinhaPlena.Desktop.Services
{
    public class DividaService
    {
        private readonly AppDbContext _bancoDeDados;

        public DividaService(AppDbContext bancoDeDados)
        {
            _bancoDeDados = bancoDeDados;
        }

        public string PendurarDivida(int idDoCliente, decimal valorDaDivida)
        {
            if (valorDaDivida <= 0)
            {
                return "O valor da dívida precisa ser maior que zero.";
            }

            bool clienteExiste = _bancoDeDados.Clientes.Any(c => c.Id == idDoCliente);
            if (!clienteExiste)
            {
                return "Não encontramos nenhum cliente com este ID no sistema.";
            }

            bool clientePossuiDividaAtiva = _bancoDeDados.Dividas.Any(d => d.ClienteId == idDoCliente && !d.Situacao);
            if (clientePossuiDividaAtiva)
            {
                return "Este cliente já possui uma dívida em aberto. É necessário quitá-la antes de pendurar uma nova.";
            }

            var novaDivida = new Divida
            {
                ClienteId = idDoCliente,
                Valor = valorDaDivida,
                Situacao = false
            };

            _bancoDeDados.Dividas.Add(novaDivida);
            _bancoDeDados.SaveChanges();

            return "Sucesso";
        }

        public string PagarDivida(int idDaDivida)
        {
            var divida = _bancoDeDados.Dividas.Find(idDaDivida);

            if (divida == null)
            {
                return "Não conseguimos localizar esta dívida no sistema.";
            }

            divida.Situacao = true;
            divida.DataPagamento = DateTime.Now;
            _bancoDeDados.SaveChanges();

            return "Sucesso";
        }

        public object ObterDividasDoCliente(int idDoCliente, out int? idDaDividaPendente)
        {
            idDaDividaPendente = null;

            var cliente = _bancoDeDados.Clientes
                .Include(c => c.Dividas)
                .FirstOrDefault(c => c.Id == idDoCliente);

            if (cliente == null)
            {
                return null;
            }

            var dividaAtiva = cliente.Dividas.FirstOrDefault(d => !d.Situacao);

            if (dividaAtiva != null)
            {
                idDaDividaPendente = dividaAtiva.Id;
            }

            var historicoDeDividas = cliente.Dividas
                .OrderByDescending(d => d.DataCriacao)
                .Select(d => new
                {
                    Código = d.Id,
                    Valor = $"R$ {d.Valor:F2}",
                    Situação = d.Situacao ? "Paga" : "Em Aberto",
                    Criada_Em = d.DataCriacao.ToString("dd/MM/yyyy"),
                    Paga_Em = d.DataPagamento?.ToString("dd/MM/yyyy") ?? "-"
                })
                .ToList();

            return historicoDeDividas;
        }
    }
}