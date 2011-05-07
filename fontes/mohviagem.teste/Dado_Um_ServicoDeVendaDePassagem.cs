using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;
using mohviagem;

namespace mohviagem.teste
{
	[TestFixture]
	public class Dado_Um_ServicoDeVendaDePassagem
	{
		[TestCase]
		public void Posso_Vender_Passagem()
		{
			var servicoDeVenda = new ServicoDeVendaDePassagens();

			var passagemEsperada = new Passagem();

			var cliente = new Cliente();
			
			var viagem = Viagem
				.Nova(Trecho.Novo()
					.ComOrigemEm("fortaleza")
					.ComOrigemEm("juazeiro"))
				.SaindoAs(new DateTime())
				.ChegandoAs(new DateTime());


			var passagemVendida = servicoDeVenda.VendePassagem(cliente, viagem);
	
			Assert.AreEqual(passagemEsperada.Cliente, passagemVendida.Cliente);
		}

		[TestCase]
		public void So_Posso_Vender_Passagens_Disponiveis()
		{ 
		
		}
	}
}
