using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace mohviagem.teste
{
	[TestFixture]
	public class Dado_Uma_Viagem
	{
		[TestCase]
		public void Tenho_Somente_40_Passagens_Disponiveis_Inicialmente()
		{
			var viagem = Viagem.Nova()
				.NoTrecho(new Trecho().ComOrigemEm("juazeiro").ComDestinoA("forteleza"));

			Assert.AreEqual(40, viagem.Passagens.Count);
		}
	}
}
