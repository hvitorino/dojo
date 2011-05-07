using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;
using mohviagem;

namespace mohviagem.teste
{
	[TestFixture]
	public class Dado_Um_CadastroDeTrecho
	{
		[TestCase]
		public void Posso_Cadastralo()
		{
			var quantidadeEsperada = 1;
			var todosOsTrechos = new CadastroDeTrechos();

			var trecho = Trecho.Novo()
							.ComOrigemEm("fortaleza")
							.ComDestinoA("juazeiro do norte")
							.ComPreco(70m);

			todosOsTrechos.adiciona(trecho);

			Assert.AreEqual(quantidadeEsperada, todosOsTrechos.Total);
		}

		
	}
}
