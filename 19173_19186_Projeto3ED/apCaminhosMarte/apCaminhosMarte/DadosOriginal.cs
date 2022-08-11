using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apCaminhosMarte
{
    public class DadosOriginal
    {
        // atributos 
        
        private int custo, 
                    distancia, //para valorar cada peso
                    tempo; 
        private int criterio;  //para guardar um dos valores das variaveis acima (visando generalização)
        private int verticePai;

        // construtor completo com todos os pesos e o verticePai
        public DadosOriginal(int vp, CaminhoEntreCidades dados, string criterio)
        {
            this.Custo = dados.Custo;
            this.Distancia = dados.Distancia;
            this.Tempo = dados.Tempo;
            this.VerticePai = vp;
            this.setCriterio(criterio);
        }
        // construtor apenas com o valor do criterio e o verticePai
        public DadosOriginal(int vp, int dado, string criterio)
        {
            this.Custo = dado;
            this.Distancia = dado;
            this.Tempo = dado;
            this.VerticePai = vp;
            this.setCriterio(criterio);
        }

        // propriedades get e set dos atributos
        public int Custo { get => custo; set => custo = value; }
        public int Distancia { get => distancia; set => distancia = value; }
        public int Tempo { get => tempo; set => tempo = value; }
        public int Criterio { get => criterio; set => criterio = value; }
        public int VerticePai { get => verticePai; set => verticePai = value; }

        public void setCriterio(String criterio)
        {
            // setta o valor da propriedade Criterio com o valor de um dos 3 pesos, 
            //de acordo com a String criterio passada por parâmetro
            switch(criterio)
            {
                case "Custo":this.Criterio = Custo;
                    break;
                case "Distancia": this.Criterio = Distancia;
                    break;
                case "Tempo": this.Criterio = Tempo;
                    break;
            }
            
        }
    }
}
