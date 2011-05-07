using System.Collections.Generic;

namespace mohviagem
{
	public class CadastroDeTrechos
	{
		private List<Trecho> listaTrechos = new List<Trecho>();

		public void adiciona(Trecho trecho)
		{
			listaTrechos.Add(trecho);
		}

		public int Total { get { return listaTrechos.Count; } }
	}
}
