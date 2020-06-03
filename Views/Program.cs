/*using System;
using View;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Locadora
{
    public class Principal
    {
        public static void  Main(String[] args)
        
        {
            Console.WriteLine("\n BlockBuster ~ Carlos E. Krehmcke \n");

            int menu = 0;
            do
            {
                                //Cliente
                Console.WriteLine(" ~~~~~~~~~~~~~~~~~~~~~~~~ ");
                Console.WriteLine(" 1 ~ Cadastrar Cliente ");
                Console.WriteLine(" 2 ~ Consultar Cliente ");
                Console.WriteLine(" 3 ~ Listar Clientes \n");

                                //Filme
                Console.WriteLine(" 4 ~ Cadastrar Filme ");
                Console.WriteLine(" 5 ~ Consultar Filme ");
                Console.WriteLine(" 6 ~ Listar Filmes \n");

                                //Locação
                Console.WriteLine(" 7 ~ Cadastrar Locação ");
                Console.WriteLine(" 8 ~ Consultar Locação ");
                Console.WriteLine(" 9 ~ Listar Locações \n");
                Console.WriteLine(" 0 ~ SAIR ");
                Console.WriteLine("\n Digite a Opção: ");
                menu = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine(" ~~~~~~~~~~~~~~~~~~~~~~~~ ");
                 switch (menu)
                {
                    //Cliente
                    case 1: 
                    Console.WriteLine("\n ~ Cadastre o Cliente ");
                        ClienteView.CadastrarCliente();
                        break;
                    case 2: 
                    Console.WriteLine("\n ~ Consulte o Cliente ");
                        ClienteView.ConsultarCliente();
                        break;
                    case 3: 
                    Console.WriteLine("\n ~ Lista de Clientes \n");
                        ClienteView.ListarClientes();
                        break;

                    //Locação
                    case 4:
                    Console.WriteLine("\n 4 ~ Cadastre Filme ");
                        FilmeView.CadastrarFilme();
                        break;
                    case 5:
                    Console.WriteLine("\n 5 ~ Consulte o Filme ");
                        FilmeView.ConsultarFilme();
                        break;
                    case 6:
                    Console.WriteLine("\n 6 ~ Lista de Filmes \n");
                        FilmeView.ListarFilmes();
                        break;
                    
                    //Locação
                    case 7:
                    Console.WriteLine("\n 7 ~ Cadastre a Locação ");
                        LocacaoView.CadastrarLocacao();
                        break;
                    case 8:
                    Console.WriteLine("\n 8 ~ Consulte a Locação ");
                        LocacaoView.ConsultarLocacao();
                        break;
                    case 9:
                    Console.WriteLine("\n 9 ~ Lista de Locações \n");
                        LocacaoView.ListarLocacao();
                        break;
                }
            } while (menu != 0);
        }
    }
}
*/