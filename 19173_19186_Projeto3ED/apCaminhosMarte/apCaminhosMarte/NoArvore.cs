using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apCaminhosMarte
{
    class NoArvore<Dado> : IComparable<NoArvore<Dado>> where Dado : IComparable<Dado>, ICloneable
    {
        private Dado info;
        private NoArvore<Dado> esq;
        private NoArvore<Dado> dir;
        private int altura;
       // private bool estaMarcadoParaMorrer;
        public NoArvore(Dado Informação)
        {
            this.Info = Informação;
            this.esq = null;
            this.dir = null;
            this.Altura = 0;
        }
        public NoArvore()
        {
            this.Info = default(Dado);
            this.esq = null;
            this.dir = null;
            this.Altura = 0;
        }
        public NoArvore(Dado dados, NoArvore<Dado> esquerdo, NoArvore<Dado> direito)
        {
            this.Info = dados;
            this.Esq = esquerdo;
            this.Dir = direito;
            this.Altura = altura;
        }
        public Dado Info { get => info; set => info = value; }
        public NoArvore<Dado> Esq { get => esq; set => esq = value; }
        public NoArvore<Dado> Dir { get => dir; set => dir = value; }
        public int Altura { get => altura; set => altura = value; }
       // public bool EstaMarcadoParaMorrer { get => estaMarcadoParaMorrer; set => estaMarcadoParaMorrer = value; }

        public Object Clone()
        {
            NoArvore<Dado> ret = null;
            try
            {
                ret = new NoArvore<Dado>(this);
            }
            catch (Exception ex) { }
            return ret;
        }

        public NoArvore(NoArvore<Dado> no)
        {
            if (no == null)
                throw new Exception("modelo null");

            this.Info = no.Info;
            this.esq = no.esq;
            this.dir = no.dir;
            this.Altura = no.Altura;

        }

        public int CompareTo(NoArvore<Dado> o)
        {
            return info.CompareTo(o.info);
        }
        public bool Equals(NoArvore<Dado> o)
        {
            return this.info.Equals(o.info);
        }
    }
}
