using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apCaminhosMarte
{
	public class Vertice
	{
        //atributos
		private int rotulo;// alteramos a variavel rotulo para int, assim, esta pode ser valorada com o id da cidade
        private bool foiVisitado;
        private bool estaAtivo;

        // construtor completo (e único)
		public Vertice(int idVertice)
		{
			Rotulo = idVertice;
			FoiVisitado = false;
			EstaAtivo = true;
		}

        // propriedades get e set de todos os atributos
        public int Rotulo { get => rotulo; set => rotulo = value; }
        public bool FoiVisitado { get => foiVisitado; set => foiVisitado = value; }
        public bool EstaAtivo { get => estaAtivo; set => estaAtivo = value; }
    }
}

