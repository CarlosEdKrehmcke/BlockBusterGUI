using System;
using System.Collections.Generic;
using Controllers;
using Repositories;

namespace Models {
    public class Filme {
        /* 
            Getters and Setters 
        */
        /// <value>Get and Set the value of idFilme</value>
        public int IdFilme { get; set; }
        /// <value>Get and Set the value of nomeFilme</value>
        public string NomeFilme { get; set; }
        /// <value>Get and Set the value of dtLancamento</value>
        public DateTime DtLancamento { get; set; }
        /// <value>Get and Set the value of sinopse</value>
        public string Sinopse { get; set; }
        /// <value>Get and Set the value of valor</value>
        public double Valor { get; set; }
        /// <value>Get and Set the value of qtdEstoque</value>
        public int QtdEstoque { get; set; }
        /// <value>Get and Set the value of locacoes</value>
        public List<Locacao> Locacoes { get; set; }

        /// <summary>Constructor to Filme object.</summary>
        public Filme (string nomeFilme, DateTime dtLancamento, string sinopse, double valor, int qtdEstoque) {
            IdFilme = RepositoryFilme.GetId();
            NomeFilme = nomeFilme;
            DtLancamento = dtLancamento;
            Sinopse = sinopse;
            Valor = valor;
            QtdEstoque = qtdEstoque;
            Locacoes = new List<Locacao> ();

            RepositoryFilme.AddFilme(this);
        }

        /// <summary>This method insert a movie into a customer rental.</summary>
        /// <param name="filme">The rental object.</param>
        public void SetarLocacao (Locacao locacao) {
            Locacoes.Add (locacao);
        }

        /// <sumary>This method find a movie.</sumary>
        public static Filme GetFilme(int idFilme){
            return RepositoryFilme.Filmes().Find (filme => filme.IdFilme == idFilme);
        }

        /// <sumary>This method return all movies.</sumary>
        public static List<Filme> GetFilmes(){
            return RepositoryFilme.Filmes();
        }

        /// <sumary>This method determines the string convertion.</sumary>
        public string ToString (bool simple = false) {
            if (simple) {
                return $"Id: {IdFilme} - Nome: {NomeFilme}";
            }

            string valor = Valor.ToString("C2");

            return $"Nome: {NomeFilme}\n" +
                $"Valor: {valor}\n" +
                $"Qtd de Locacoes: {FilmeController.GetQtdLocacoes(this)}";
        }

        /// <sumary>This method import movies on the database.</sumary>
        public static void ListarFilmes(){
            /* Generate movies*/
            new Filme (
                "Coringa", new DateTime (2019, 12, 1), "Matar o Batman.", 10, 2
            );
            new Filme (
                "Rei Leão", new DateTime (2019, 11, 1), "Simba.", 15, 1
            );
            new Filme (
                "Parasita", new DateTime (2020, 10, 1), "Familia extorque outra.", 25, 1
            );
            new Filme (
                "1917", new DateTime (2020, 11, 1), "Guerra tatatá ~explosão~.", 30, 2
            );
            new Filme (
                "Sonic", new DateTime (2019, 9, 1), "Ouriço que corre.", 25, 2
            );
            new Filme (
                "Avez de rapina", new DateTime (2020, 8, 1), "Fracasso de bilheteria.", 10, 2
            );
            new Filme (
                "Married history", new DateTime (2019, 7, 1), "Casal briga.", 15, 1
            );
            new Filme (
                "Aladin", new DateTime (2019, 6, 1), "Indiano com tapete que voa e macaco que fala.", 20, 1
            );
            new Filme (
                "AD Astra", new DateTime (2019, 5, 1), "Astronauta sem pai.", 10, 2
            );
            new Filme (
                "Frizen 2", new DateTime (2019, 4, 1), "Menina com poderes de gelo.", 15, 1
            );
        }
    }
}