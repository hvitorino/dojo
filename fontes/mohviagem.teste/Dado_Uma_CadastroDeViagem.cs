using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;
using mohviagem;

namespace mohviagem.teste
{
	[TestFixture]
	public class Dado_Uma_CadastroDeViagem
	{
		private CadastroDeViagens cadastroDeViagens;

		[SetUp]
		public void Inicia()
		{
			cadastroDeViagens = new CadastroDeViagens();
			
			var fortalezaJuazeiro = Trecho.Novo()
							.ComOrigemEm("fortaleza")
							.ComDestinoA("juazeiro do norte");
			
			var fortalezaCaninde = Trecho.Novo()
							.ComOrigemEm("fortaleza")
							.ComDestinoA("Canindé");

			cadastroDeViagens.adiciona(
				Viagem.Nova(fortalezaJuazeiro)
							.SaindoAs(new DateTime(2011, 05, 08, 09, 00, 00))
							.ChegandoAs(new DateTime(2011, 05, 08, 18, 00, 00)));
			
			cadastroDeViagens.adiciona(
				Viagem.Nova(fortalezaJuazeiro)
							.SaindoAs(new DateTime(2011, 05, 12, 09, 00, 00))
							.ChegandoAs(new DateTime(2011, 05, 12, 18, 00, 00)));

			cadastroDeViagens.adiciona(
				Viagem.Nova(fortalezaJuazeiro)
							.SaindoAs(new DateTime(2011, 05, 15, 09, 00, 00))
							.ChegandoAs(new DateTime(2011, 05, 15, 18, 00, 00)));
			
			cadastroDeViagens.adiciona(
							Viagem.Nova(fortalezaJuazeiro)
										.SaindoAs(new DateTime(2011, 05, 14, 09, 00, 00))
										.ChegandoAs(new DateTime(2011, 05, 14, 18, 00, 00)));
			
			cadastroDeViagens.adiciona(
				Viagem.Nova(fortalezaCaninde)
							.SaindoAs(new DateTime(2011, 05, 08, 09, 00, 00))
							.ChegandoAs(new DateTime(2011, 05, 08, 18, 00, 00)));
		}

		[TestCase]
		public void Posso_Cadastrar_Viagem()
		{
			var qtdEsperada = 1;
			var cadastroDeViagens = new CadastroDeViagens();

			var trecho = Trecho.Novo()
							.ComOrigemEm("fortaleza")
							.ComDestinoA("juazeiro do norte");

			var viagem = Viagem.Nova(trecho)
							.SaindoAs(new DateTime(2011, 05, 08, 09, 00, 00))
							.ChegandoAs(new DateTime(2011, 05, 08, 18, 00, 00));

			cadastroDeViagens.adiciona(viagem);

			Assert.AreEqual(qtdEsperada, cadastroDeViagens.Total);
		}

		[TestCase]
		public void Posso_Pesquisar_Viagens()
		{
			var cidadeOrigem = "fortaleza";
			var cidadeDestino = "juazeiro do norte";
			var partindoEm = new DateTime(2011, 05, 07);

			var trecho = Trecho.Novo()
							.ComOrigemEm(cidadeOrigem)
							.ComDestinoA(cidadeDestino);

			var juazeiroFortaleza = Viagem.Nova(trecho)
							.SaindoAs(new DateTime(2011, 05, 08, 09, 00, 00))
							.ChegandoAs(new DateTime(2011, 05, 08, 18, 00, 00));

			var viagensDisponiveis = cadastroDeViagens.pesquisa(cidadeOrigem, cidadeDestino, partindoEm);

			Assert.True(viagensDisponiveis.Select(a => a.Trecho).Contains(trecho));
		}
	}
}
