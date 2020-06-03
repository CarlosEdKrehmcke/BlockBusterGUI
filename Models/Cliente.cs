using System;
using System.Collections.Generic;
using Repositories;
using Controllers;

namespace Models {
    public class Cliente {
        /* 
            Getters and Setters 
        */
        /// <value>Get and Set the value of idCliente</value>
        public int IdCliente { get; set; }
        /// <value>Get and Set the value of nome</value>
        public string Nome { get; set; }
        /// <value>Get and Set the value of dtNasc</value>
        public DateTime DtNasc { get; set; }
        /// <value>Get and Set the value of cpf</value>
        public string Cpf { get; set; }
        /// <value>Get and Set the value of dias</value>
        public int Dias { get; set; }
        /// <value>Get and Set the value of locacoes</value>
        public List<Locacao> Locacoes { get; set; }

        /// <summary>Constructor to Cliente object.</summary>
        public Cliente (string nome, DateTime dtNasc, string cpf, int dias) {
            IdCliente = RepositoryCliente.GetId();
            Nome = nome;
            DtNasc = dtNasc;
            Cpf = cpf;
            Dias = dias;
            Locacoes = new List<Locacao> ();

            RepositoryCliente.AddCliente(this);
        }
        
        /// <summary>This method insert a new movie rental for the customer.</summary>
        /// <param name="locacao">The rental object.</param>
        public void InserirLocacao (Locacao locacao) {
            Locacoes.Add (locacao);
        }

        /// <sumary>This method find a customer.</sumary>
        public static Cliente GetCliente(int idCliente){
            return RepositoryCliente.Clientes().Find (cliente => cliente.IdCliente == idCliente);
        }

        /// <sumary>This method find return all customers.</sumary>
        public static List<Cliente> GetClientes(){
            return RepositoryCliente.Clientes();
        }

        /// <sumary>This method determines the string convertion.</sumary>
        public string ToString (bool simple = false) {
            if (simple) {
                string retorno = $"Id: {IdCliente} - Nome: {Nome}\n" +
                    "   Locações: \n";
                if (Locacoes.Count > 0) {
                    Locacoes.ForEach (
                        locacao => retorno += $"    Id: {locacao.IdLocacao} - " +
                        $"Data: {locacao.DtLocacao} - " +
                        $"Data de Devolução: {LocacaoController.GetDataDevolucao(locacao)}\n"
                    );
                } else {
                    retorno += "    Não há locações";
                }

                return retorno;
            }

            string dtNasc = this.DtNasc.ToString("dd/MM/yyyy");

            return $"Nome: {Nome}\n" +
                $"Data de Nascimento: {dtNasc}\n" +
                $"Qtd de Filmes: {ClienteController.GetQtdFilmes(this)}";
        }

        /// <sumary>This method import customers and rental on the database.</sumary>
        public static void Importar(){
            Cliente cliente;
            Locacao locacao;

            /* Generate costumers*/
            cliente = new Cliente (
                "Adamastor",
                new DateTime (2001, 12, 27),
                "111.111.111-22",
                10
            );
            locacao = new Locacao (
                cliente,
                DateTime.Now.AddDays (-5)
            );
            locacao.InserirFilme (Filme.GetFilme(1));
            locacao.InserirFilme (Filme.GetFilme(6));
            
            cliente = new Cliente (
                "Adam",
                new DateTime (1993, 11, 11),
                "222.222.222-33",
                15
            );
            locacao = new Locacao (
                cliente,
                DateTime.Now.AddDays (-8)
            );
            locacao.InserirFilme (Filme.GetFilme(4));
            locacao.InserirFilme (Filme.GetFilme(2));
            
            cliente = new Cliente (
                "Mastor",
                new DateTime (2000, 8, 12),
                "333.333.333-44",
                20
            );
            locacao = new Locacao (
                cliente,
                DateTime.Now.AddDays (-2)
            );
            locacao.InserirFilme (Filme.GetFilme(8));
            
            cliente = new Cliente (
                "Damas",
                new DateTime (1999, 09, 16),
                "444.444.444-55",
                5
            );
            locacao = new Locacao (
                cliente,
                DateTime.Now.AddDays (-10)
            );
            locacao.InserirFilme (Filme.GetFilme(8));
            locacao.InserirFilme (Filme.GetFilme(7));

            locacao = new Locacao (
                cliente,
                DateTime.Now
            );
            locacao.InserirFilme (Filme.GetFilme(9));
            
            cliente = new Cliente (
                "Tor",
                new DateTime (1999, 03, 5),
                "555.555.555-00",
                10
            );
            locacao = new Locacao (
                cliente,
                DateTime.Now
            );
            locacao.InserirFilme (Filme.GetFilme(5));
            locacao.InserirFilme (Filme.GetFilme(1));
            locacao.InserirFilme (Filme.GetFilme(3));
        }

    }
}