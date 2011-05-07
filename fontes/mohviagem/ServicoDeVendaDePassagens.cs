using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mohviagem
{
	public class ServicoDeVendaDePassagens
	{
		public Passagem VendePassagem(Cliente cliente, Viagem viagem)
		{
			//registrar a venda e as passagens disponiveis na viagem 
			
			return new Passagem() { Cliente = cliente };
		}
	}
}
