using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mohviagem
{
	public class Trecho
	{
		public static Trecho Novo()
		{
			return new Trecho();
		}

		public Trecho PartindoDe(string origem)
		{
			this.Origem = origem;

			return this;
		}

		public Trecho IndoPara(string destino)
		{
			this.Destino = destino;

			return this;
		}

		public Trecho ComPreco(decimal preco)
		{
			this.Preco = preco;

			return this;
		}

		public string Origem { get; set; }

		public string Destino { get; set; }

		public decimal Preco { get; set; }

		public override bool Equals(object obj)
		{
			if (obj == null)
				return false;
			else if (!(obj is Trecho))
				return false;
			else
				return this.GetHashCode() == obj.GetHashCode();
		}

		public override int GetHashCode()
		{
			string stringHash = Origem + "." + Destino;

			return stringHash.GetHashCode();
		}
	}
}
