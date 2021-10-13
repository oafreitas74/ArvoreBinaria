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
	/// Description of Nodo.
	/// </summary>
	public class Nodo
	{
		#region Atributos/campos da classe

		private Info info;  // apontador para a informação do Info
		private Nodo drt;	// apontador para o nodo direito
		private Nodo esq;	// apontador para o nodo esquerdo	
		#endregion

		#region Propriedades da Classe	

		public Info Info {
			get { return info; }
			set { info = value; }
		}
		
		public Nodo Drt {
			get { return drt; }
			set { drt = value; }
		}
		
		public Nodo Esq {
			get { return esq; }
			set { esq = value; }
		}
		#endregion
		
		#region Construtor
		public Nodo(double valor, string nome)
		{
			this.info= new Info(valor,nome);
			this.drt= null;
			this.esq= null;	
		}
		#endregion
	}// fim da classe...
}
