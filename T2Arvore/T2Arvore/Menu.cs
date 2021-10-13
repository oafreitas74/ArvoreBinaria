/*
 * Created by SharpDevelop.
 * User: Orlando Freitas
 * Date: 2020/2021
 * 
 */
using System;

namespace T2Arvore
{
	/// <summary>
	/// Description of Menu.
	/// </summary>
	public class Menu
	{
		private static string retorno = "0123456789ABCDEFGHIJKLMNOPQRSTUVWYZ"; // os careteres autorizados 
		private string[] opcao;
		
		public Menu(params string[] lista)
		{
			opcao = new string[lista.Length];
		 for (int i=0;i<lista.Length;i++)
		 	opcao[i]=lista[i];
		}

		// mostra o menu em consola e devolve a opção escolhida (na forma de char)
		// só sai depois de digitada uma das opçoes
		public char MenuSimples(ConsoleColor corFundo, ConsoleColor corOpcoes)
		{ConsoleKeyInfo tecla;
		 string retornos = retorno.Substring(0,opcao.Length);
		 Console.BackgroundColor=corFundo;
		 Console.Clear();
		 Console.ForegroundColor=corOpcoes;
		 Console.WriteLine("\nOpções Disponíveis:\n");
		 for (int i=1;i<this.opcao.Length;i++)// O for começa no 1 para deixar o 0 para ultimo 
		 	Console.WriteLine(" {0}... {1}",retorno[i],opcao[i-1]);
		 Console.WriteLine(" {0}... {1}",0,opcao[opcao.Length-1]); //Colocar o 0 em ultimo lugar da lista menu
		 Console.Write("\nDigite a sua opção: ");
		 do // Enquanto não for inserido char que está definido na string retorno 
		   tecla=Console.ReadKey(true);
		 while (retornos.IndexOf(tecla.KeyChar)==-1);
		 Console.WriteLine();
		return tecla.KeyChar;
		}
		
		public static void TeclaParaContinuar()
		{
		 Console.Write("\nCarregue numa tecla para continuar. . . ");
		 Console.ReadKey(true);	
		}
	}
}
