using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace mohviagem.teste
{
	[TestFixture]
	public class Dado_Um_Trecho
	{
		[TestCase]
		public void Sao_Iguais_Se_Origem_E_Destino_Forem_Iguais()
		{
			var primeiro = Trecho.Novo().IndoPara("juazeiro")
				.PartindoDe("fortaleza");

			var segundo = Trecho.Novo().IndoPara("juazeiro")
				.PartindoDe("fortaleza");

			Assert.True(primeiro.Equals(segundo));
		}

		[TestCase]
		public void Deve_Ter_O_Mesmo_Hashcode_Se_Comparado_A_Outro_Igual()
		{
			var primeiro = Trecho.Novo().IndoPara("juazeiro")
				.PartindoDe("fortaleza");

			var segundo = Trecho.Novo().IndoPara("juazeiro")
				.PartindoDe("fortaleza");

			Assert.AreEqual(primeiro.GetHashCode(), segundo.GetHashCode());
		}
	}
}
