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
	/// Description of JogarJogo.
	/// </summary>
	public class JogarJogo
	{
		private static string opcoes = "SsNn";
		
		// Metodo que copia o Nodo raiz para um auxiliar, assim podemos comecçar sempre no inicio a arvore
		// porque o Nodo raiz não será alterado
		public void Jogar(Nodo raiz)
		{
			Nodo aux= raiz;
			this.IniciarJogo(aux,raiz);
		}
		
		// Iniciar o jogo 
		public void IniciarJogo(Nodo no, Nodo raiz)
		{
			if(no == null)
				return;
			string opcao ="";
			string op= "";
			string op2= "";
			if(no.Esq == null && no.Drt == null) //Quando encontra um objeto 
			{
				Console.WriteLine("O objeto é {0} ?",no.Info.Nome);
				do //Verificar se é inserido a tecla permitida
		   			 op=Console.ReadLine();
				 while (opcoes.IndexOf(op)==-1);
				
				if(op == "S" || op == "s")
				{
					Console.WriteLine("Obrigado, viu como eu acertei :)\n Quer jogar novamente ?");
//					do //Verificar se é inserido a tecla permitida
//		   			 	op2=Console.ReadLine();
//				 	while (opcoes.IndexOf(op2)==-1);
//					if(op2 == "S" || op2 == "s")
//						this.Jogar(raiz); //Reeniciar o jogo
//					else if(op2 == "N" || op2 == "n")
						return; // Acabar o jogo
						
				}
				else if(op == "N" || op == "n")
					this.InserirObjeto(no,raiz);
				return;
			}

			else// Se não é um objeto é uma pregunta 
			{
				Console.WriteLine("{0}",no.Info.Nome);
				opcao = Console.ReadLine();
				// Mediante a opçao vai para a direito ou para a esquerda da arvore.
				if(opcao == "S" || opcao == "s")
				{
					this.IniciarJogo(no.Esq,raiz);// Reeniciar a funçao com o Nodo na posiçao guardada á esquerda
				}
				else if(opcao == "N" || opcao == "n")
				{
					this.IniciarJogo(no.Drt,raiz);// Reeniciar a funçao com o Nodo na posiçao guardada á direita
				}
				else //Avisar se é inserido uma tecla que não é permitida
				{
					Console.WriteLine("Inserir o valores corretos S(sim) ou N(não)");
					this.IniciarJogo(no,raiz); // Reeniciar a funçao com o Nodo no mesmo lugar
				}
			}	
			
		}
		
		public void InserirObjeto(Nodo no, Nodo raiz)
		{
			string nomeaux = no.Info.Nome; // copiar o nome do objeto para uma string.
			Console.WriteLine("Então qual era o objecto ?");
			string objeto = Console.ReadLine();
			Console.WriteLine("Digite então uma pergunta que diferencie a "+ nomeaux +" da "+ objeto +" (a resposta deverá ser S/N,sendo a resposta S indicadora de "+ objeto +")");
			string pregunta = Console.ReadLine();
			// Copiar as variaveis do Nodo e substituir pelo novo nome 
			double valoraux = no.Info.Valor;
			no.Info.Nome = pregunta;
			// Acresentar ou diminuir ao Valor com uma decimas
			// essas decimas são calculadas multiplicando o valor do Nodo incial, assim e´ uma maneira de 
			// quando foi inserido um novo objeto o valor sobrepor aos existentes(acho eu :) ).
			Nodo aux1= new Nodo(valoraux-valoraux*0.049,objeto);
			no.Esq = aux1;
			Nodo aux2= new Nodo(valoraux+valoraux*0.049,nomeaux);
			no.Drt = aux2;
			Console.WriteLine("Obrigado, estou sempre a aprender. Quer jogar novamente ?");
			string op = Console.ReadLine();
			if(op == "S"|| op == "s")
				this.Jogar(raiz);//Reeniciar o jogo
			else
				return;// Acabar o jogo
		}
		
	}
}
