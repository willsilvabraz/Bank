using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Program
    {
       private static List<Conta> listContas = new List<Conta>(){
        };

        static void Main(string[] args)
        {
          
            string OpcaoUsuario = ObterOpcaoUsuario();

            while (OpcaoUsuario.ToUpper() != "X") 
            {
                switch (OpcaoUsuario)
                {
                    
                    case "1":
                        ListarContas();
                        break;
                    case "2":      
                        InserirConta();     
                        break;
                    case "3":
                        Transferir();
                        break;
                    case "4":
                        Sacar();
                        break;
                    case "5":
                        Depositar();
                        break;
                    case "6":
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        break;

                         
                }
                OpcaoUsuario = ObterOpcaoUsuario();
                
            }
            Console.Clear();
            Console.WriteLine("Obrigado Por Usar Nossos Serviços... ");
        }

        private static void Transferir()
        {
            Console.Clear();
            Console.WriteLine("Digite O Numero Da Conta De Origem:  ");
            int indiceContaOrigem = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Digite O Numero Da Conta Distino:  ");
            int indiceContaDestino = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Digite O Valor Da Transferencia:  ");
            double valorTransferencia = double.Parse(Console.ReadLine());

            listContas[indiceContaOrigem].Transferir(valorTransferencia, listContas[indiceContaDestino]);
        } 

        private static void Depositar()
        {
            Console.Clear();
            Console.WriteLine("Digite O Numero Da Conta ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Digite O Valor Do Deposito");
            double valorDeposito = double.Parse(Console.ReadLine());

            listContas[indiceConta].Depositar(valorDeposito);
        }        

        private static void Sacar()
        {
            Console.Clear();
            Console.WriteLine("Digite O Numero Da Conta ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Digite O Valor A Ser Sacado");
            double valorSaque = double.Parse(Console.ReadLine());

            listContas[indiceConta].Sacar(valorSaque);        }

        private static void InserirConta()
        {
            Console.Clear();
            Console.WriteLine("Inserir Nova Conta*");
            Console.WriteLine("Digite 1 para conta fisica ou 2 para conta juridica:");
            int EntradaTipoConta = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Digite O Nome Do Cliente: ");
            string EntradaNome = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Digite O Saldo Inicial ");
            double EntradaSaldo = double.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Digite o Crédito");
            double EntradaCredito = double.Parse(Console.ReadLine());

            Console.Clear();
            Conta NovaConta = new Conta(tipoConta: (TipoConta)EntradaTipoConta,
                                        saldo: EntradaSaldo,
                                        credito: EntradaCredito,
                                        nome: EntradaNome);
            listContas.Add(NovaConta);
        }
        
        private static void ListarContas()
        {
            Console.Clear();
            Console.WriteLine("Listar Contas");

            if ( listContas.Count == 0)
            {
                Console.WriteLine("Nenuma Conta Cadastrada");
                
                return;
            }
            Console.Clear();
            for (int i = 0; i < listContas.Count; i++)
            {
                Conta conta = listContas[i];
               
                Console.WriteLine(conta);
                
            }
            
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("Pressione Enter");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Informe a opção desejada");

            Console.WriteLine("1- listar conta");
            Console.WriteLine("2- Inserir nova conta");
            Console.WriteLine("3- Transferir");
            Console.WriteLine("4- Sacar");
            Console.WriteLine("5- Depositar");
            Console.WriteLine("6- Limpar tela");
            Console.WriteLine("x- Sair");
            Console.WriteLine("");

            string OpcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine("");
            return OpcaoUsuario;
            
        }
        
    }
}
