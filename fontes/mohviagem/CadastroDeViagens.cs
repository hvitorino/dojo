using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mohviagem
{
	public class CadastroDeViagens
	{
		private List<Viagem> listaDeViagens = new List<Viagem>();

		public void adiciona(Viagem viagem)
		{
			listaDeViagens.Add(viagem);
		}

		public int Total { get { return listaDeViagens.Count; } }

		public List<Viagem> pesquisa(string cidadeOrigem, string cidadeDestino, DateTime partindoEm)
		{
			return (
					from viagem in listaDeViagens
					where viagem.Trecho.Origem.Equals(cidadeOrigem) 
					   && viagem.Trecho.Destino.Equals(cidadeDestino)
					select viagem
				).ToList();
		}
	}
}
