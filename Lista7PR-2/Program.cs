using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Lista7PR_2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            // exercicio1


//        {
//            int quantidadeTotal = 0;
//            decimal valorTotal = 0;

//            while (true)
//            {
//                Console.Write("Digite a quantidade de itens adquiridos (ou 0 para finalizar): ");
//                int quantidade = int.Parse(Console.ReadLine());

//                if (quantidade <= 0)
//                    break;

//                Console.Write("Digite o preço do produto: ");
//                decimal preco = decimal.Parse(Console.ReadLine());

//                quantidadeTotal += quantidade;
//                valorTotal += quantidade * preco;
//            }

//            Console.WriteLine("Quantidade total de itens adquiridos: " + quantidadeTotal);
//            Console.WriteLine("Valor total da compra: R$" + valorTotal.ToString("0.00"));
//            Console.ReadKey();
//        }
//    }
//}

//    }

//EXERCICIO2

//        string produtoMaisCaro = "";
//        decimal maiorInvestimento = 0;

//        string produtoMaisBarato = "";
//        decimal menorInvestimento = decimal.MaxValue;

//        while (true)
//        {
//            Console.Write("Digite o nome do produto (ou digite 'sair' para encerrar o cadastro): ");
//            string nomeProduto = Console.ReadLine();

//            if (nomeProduto.ToLower() == "sair")
//                break;

//            Console.Write("Digite o número de itens do produto: ");
//            int quantidade = int.Parse(Console.ReadLine());

//            Console.Write("Digite o preço de compra do produto: ");
//            decimal preco = decimal.Parse(Console.ReadLine());

//            decimal investimentoTotal = quantidade * preco;

//            if (investimentoTotal > maiorInvestimento)
//            {
//                maiorInvestimento = investimentoTotal;
//                produtoMaisCaro = nomeProduto;
//            }

//            if (investimentoTotal < menorInvestimento)
//            {
//                menorInvestimento = investimentoTotal;
//                produtoMaisBarato = nomeProduto;
//            }
//        }

//        Console.WriteLine("Produto com maior quantia total investida em estoque:");
//        Console.WriteLine("Nome do produto: " + produtoMaisCaro);
//        Console.WriteLine("Quantia total investida: R$" + maiorInvestimento.ToString("0.00"));

//        Console.WriteLine();

//        Console.WriteLine("Produto com menor quantia total investida em estoque:");
//        Console.WriteLine("Nome do produto: " + produtoMaisBarato);
//        Console.WriteLine("Quantia total investida: R$" + menorInvestimento.ToString("0.00"));
//        Console.ReadKey();
//    }
//}
//}

//EXERCICIO3

//        Console.Write("Digite o número de avaliações planejadas para o bimestre: ");
//        int numeroAvaliacoes = int.Parse(Console.ReadLine());

//        decimal somaPesos = 0;

//        for (int i = 1; i <= numeroAvaliacoes; i++)
//        {
//            Console.Write("Digite o peso da avaliação " + i + ": ");
//            decimal peso = decimal.Parse(Console.ReadLine());

//            somaPesos += peso;
//        }

//        Console.WriteLine();

//        if (somaPesos < 100)
//        {
//            Console.WriteLine("A soma total dos pesos é insuficiente.");
//        }
//        else if (somaPesos > 100)
//        {
//            Console.WriteLine("A soma total dos pesos é excedente.");
//        }
//        else
//        {
//            Console.WriteLine("A soma total dos pesos é adequada.");
//            Console.ReadKey();
//        }
//    }
//  }
//}

//EXERCICIO4

//           {
//               Console.WriteLine("Digite a sigla de um estado:");
//               int sigla = Console.ReadLine();

//               int estado = ObterEstado (sigla);

//               if (estado != null)
//               {
//                   Console.WriteLine($"O estado correspondente à sigla {sigla} é {estado}.");
//               }
//               else
//               {
//                   Console.WriteLine("Sigla de estado inválida.");
//               }
//           }

//            int ObterEstado(string sigla)
//           {
//               int estado;

//               switch (sigla.ToUpper())
//               {
//                   case "AC":
//                       estado = "Acre";
//                       break;
//                   case "AL":
//                       estado = "Alagoas";
//                       break;
//                   case "AP":
//                       estado = "Amapá";
//                       break;
//                   case "AM":
//                       estado = "Amazonas";
//                       break;
//                   case "BA":
//                       estado = "Bahia";
//                       break;
//                   case "CE":
//                       estado = "Ceará";
//                       break;
//                   case "DF":
//                       estado = "Distrito Federal";
//                       break;
//                   case "ES":
//                       estado = "Espírito Santo";
//                       break;
//                   case "GO":
//                       estado = "Goiás";
//                       break;
//                   case "MA":
//                       estado = "Maranhão";
//                       break;
//                   case "MT":
//                       estado = "Mato Grosso";
//                       break;
//                   case "MS":
//                       estado = "Mato Grosso do Sul";
//                       break;
//                   case "MG":
//                       estado = "Minas Gerais";
//                       break;
//                   case "PA":
//                       estado = "Pará";
//                       break;
//                   case "PB":
//                       estado = "Paraíba";
//                       break;
//                   case "PR":
//                       estado = "Paraná";
//                       break;
//                   case "PE":
//                       estado = "Pernambuco";
//                       break;
//                   case "PI":
//                       estado = "Piauí";
//                       break;
//                   case "RJ":
//                       estado = "Rio de Janeiro";
//                       break;
//                   case "RN":
//                       estado = "Rio Grande do Norte";
//                       break;
//                   case "RS":
//                       estado = "Rio Grande do Sul";
//                       break;
//                   case "RO":
//                       estado = "Rondônia";
//                       break;
//                   case "RR":
//                       estado = "Roraima";
//                       break;
//                   case "SC":
//                       estado = "Santa Catarina";
//                       break;
//                   case "SP":
//                       estado = "São Paulo";
//                       break;
//                   case "SE":
//                       estado = "Sergipe";
//                       break;
//                   case "TO":
//                       estado = "Tocantins";
//                       break;
//                   default:
//                       estado = null;
//                       break;
//               }

//               Console.ReadKey();
//           }
//       }
//   }
//}

//exercicio 5

//           while (true)
//           {
//               Console.WriteLine("Digite um número inteiro entre 1 e 12 para representar um mês do ano:");
//               int mes = Convert.ToInt32(Console.ReadLine());

//               string estacao;

//               switch (mes)
//               {
//                   case 12:
//                   case 1:
//                   case 2:
//                       estacao = "Inverno";
//                       break;
//                   case 3:
//                   case 4:
//                   case 5:
//                       estacao = "Primavera";
//                       break;
//                   case 6:
//                   case 7:
//                   case 8:
//                       estacao = "Verão";
//                       break;
//                   case 9:
//                   case 10:
//                   case 11:
//                       estacao = "Outono";
//                       break;
//                   default:
//                       Console.WriteLine("Mês inválido. Digite um número entre 1 e 12.");
//                       continue;
//               }

//               if ((mes == 3 || mes == 9) && SolicitarInformacaoExtra("O mês digitado pode pertencer tanto à Primavera quanto ao Outono. Digite '1' para Primavera ou '2' para Outono:") == 2)
//               {
//                   estacao = "Outono";
//               }
//               else if ((mes == 6 || mes == 12) && SolicitarInformacaoExtra("O mês digitado pode pertencer tanto ao Verão quanto ao Inverno. Digite '1' para Verão ou '2' para Inverno:") == 2)
//               {
//                   estacao = "Inverno";
//               }

//               Console.WriteLine("Estação do ano: " + estacao);
//               Console.WriteLine();
//           }
//       }

//       static int SolicitarInformacaoExtra(string mensagem)
//       {
//           while (true)
//           {
//               Console.WriteLine(mensagem);
//               int escolha = Convert.ToInt32(Console.ReadLine());
//               if (escolha == 1 || escolha == 2)
//               {
//                   return escolha;
//               }
//               else
//               {
//                   Console.WriteLine("Escolha inválida. Digite '1' ou '2'.");

//               }
//               Console.ReadKey();
//           }
//       }
//   }
//}

//exercicio6

//           while (true)
//           {
//               Console.WriteLine("Digite seu peso em kg (ou pressione 'Q' para sair):");
//               string inputPeso = Console.ReadLine();

//               if (inputPeso.ToUpper() == "Q")
//                   break;

//               Console.WriteLine("Digite sua altura em metros:");
//               string inputAltura = Console.ReadLine();

//               double peso, altura;
//               if (!double.TryParse(inputPeso, out peso) || !double.TryParse(inputAltura, out altura))
//               {
//                   Console.WriteLine("Entrada inválida. Certifique-se de digitar números válidos para peso e altura.");
//                   continue;
//               }

//               double imc = CalcularIMC(peso, altura);
//               string faixaPeso = ObterFaixaPeso(imc);

//               Console.WriteLine("Seu IMC é: " + imc.ToString("0.00"));
//               Console.WriteLine("Faixa de peso: " + faixaPeso);
//               Console.WriteLine();
//           }
//       }

//       static double CalcularIMC(double peso, double altura)
//       {
//           return peso / (altura * altura);
//       }

//       static string ObterFaixaPeso(double imc)
//       {
//           if (imc < 18.5)
//               return "Abaixo do peso";
//           else if (imc < 25.0)
//               return "Peso normal";
//           else if (imc < 30.0)
//               return "Sobrepeso";
//           else if (imc < 35.0)
//               return "Obesidade grau 1";
//           else if (imc < 40.0)
//               return "Obesidade grau 2";
//           else
//               return "Obesidade grau 3 (mórbida)";
//           Console.ReadKey();
//       }

//   }
//}


//exercicio7

 // class Program
 //{
 //   static void Main(string[] args)
 //   {
 //       Console.WriteLine("Digite um número inteiro positivo:");
 //       int numero = Convert.ToInt32(Console.ReadLine());

 //       if (numero <= 0)
 //       {
 //           Console.WriteLine("O número deve ser maior que 0.");
 //       }
 //       else
 //       {
 //           Console.WriteLine("Divisores de " + numero + ":");

 //           for (int i = 1; i <= numero; i++)
 //           {
 //               if (numero % i == 0)
 //               {
 //                   Console.WriteLine(i);
 //               }
 //           }
 //       }
 //   }
 //}
