using System;
using System.Collections.Generic;

namespace mohviagem
{
	public class Viagem
	{
		public Viagem()
		{
			Passagens = new List<Passagem>();

			for (int i = 0; i < 40; i++)
			{
				Passagens.Add(new Passagem());
			}
		}

		private	Viagem(Trecho trecho)
		{
			this.Trecho = trecho;
		}

		public static Viagem Nova(Trecho trecho) 
		{
			return new Viagem(trecho);
		}

		public static Viagem Nova() 
		{
			return new Viagem();
		}

		public Viagem SaindoAs(DateTime horaSaida)
		{
			this.HoraSaida = horaSaida;
			
			return this;
		}

		public Viagem ChegandoAs(DateTime horaChegada)
		{
			this.HoraChegada = horaChegada;

			return this;
		}

		public Viagem NoTrecho(Trecho trecho){
			this.Trecho = trecho;
			return this;
		}

		public Trecho Trecho { get; set; }

		public DateTime HoraSaida { get; set; }

		public DateTime HoraChegada { get; set; }

		public List<Passagem> PassagensDisponiveis { get; private set; }

		public List<Passagem> Passagens { get; private set; }

	}
}
