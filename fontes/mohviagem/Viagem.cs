using System;

namespace mohviagem
{
	public class Viagem
	{
		private	Viagem(Trecho trecho)
		{
			this.Trecho = trecho;
		}

		public static Viagem Nova(Trecho trecho) 
		{
			return new Viagem(trecho);
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

		public Trecho Trecho { get; set; }

		public DateTime HoraSaida { get; set; }

		public DateTime HoraChegada { get; set; }
	}
}
