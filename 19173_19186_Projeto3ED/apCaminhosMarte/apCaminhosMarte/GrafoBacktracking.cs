using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Threading;

namespace apCaminhosMarte
{
    class GrafoBacktracking
    {
        // atributos utilizada pela classe toda
        private CaminhoEntreCidades[,] matriz;
            // matriz de CaminhoEntreCidades em que, onde há caminho entre as cidades de id i e j (tomando matriz[i, j]) 
            //o objeto é settado com os dados fornecidos pelos txts e, caso contrário, os dados são settados como infinity
        private int qtasCidades;
        private int infinity = int.MaxValue; // maior int possível, valor tão grande que podemos considerar "inexistente"
        private int total; // valor total do criterio escolhido para efetuar o menor caminho

        // propriedade get e set
        public int Total { get => total; set => total = value; }

        // construtor completo que le os arquivos e setta os vetores e matriz
        public GrafoBacktracking(string arqCam, string arqCid)
        {
            qtasCidades = 23; // nº de cidades do arquivo
            // instancia-se leitor de arquivos com o nome do arquivo passado por parâmetro
            var arqCaminhos = new StreamReader(arqCam);
            var arqCidades = new StreamReader(arqCid);

            vertices = new Vertice[qtasCidades];
            percurso = new DadosOriginal[qtasCidades];
            matriz = new CaminhoEntreCidades[qtasCidades, qtasCidades]; // matriz [23,23]

            for(int l=0; l<qtasCidades; l++)
            { // setta todos os campos da matriz com CaminhoEntreCidades com infinity, isto é, "inexistentes"
                for (int c = 0; c < qtasCidades; c++)
                {
                    CaminhoEntreCidades caminho = new CaminhoEntreCidades(l, c, infinity, infinity, infinity);
                    matriz[caminho.IdCidadeOrigem, caminho.IdCidadeDestino] = caminho;
                }
            }

            while (!arqCaminhos.EndOfStream) // lê todo o arquivo de caminhos
            {
                string linha = arqCaminhos.ReadLine(); // lê uma linha por vez
                CaminhoEntreCidades caminho = new CaminhoEntreCidades(int.Parse(linha.Substring(0, 3)), int.Parse(linha.Substring(3, 3)), int.Parse(linha.Substring(6, 5)), int.Parse(linha.Substring(11, 4)), int.Parse(linha.Substring(15)));
                matriz[caminho.IdCidadeOrigem, caminho.IdCidadeDestino] = caminho; // add o caminho lido na matriz, com a linha = idCidadeOrigem e coluna = idCidadeDestino
            }
            arqCaminhos.Close();

            int i = 0;
            while (!arqCidades.EndOfStream)  // lê todo o arquivo de cidades
            {
                string linha = arqCidades.ReadLine(); // lê uma linha por vez
                vertices[i] = new Vertice(int.Parse(linha.Substring(0, 3))); // add o vertice com o id da cidade
                i++;
            }
            arqCidades.Close();
        }

        public void Exibir(DataGridView dgv)
        {
            // exibe em um DataGrid, settado com qtsCidades linhas e qtsCidades colunas, os possiveis caminhos entre 
            // as cidades, escrevendo os dados da ligação na célula de intersecção entre elas
            dgv.RowCount = dgv.ColumnCount = qtasCidades;
            for (int coluna = 0; coluna < qtasCidades; coluna++)
            {
                dgv.Columns[coluna].HeaderText = coluna.ToString();
                dgv.Rows[coluna].HeaderCell.Value = coluna.ToString();
                dgv.Columns[coluna].Width = 30;
            }
            for (int linha = 0; linha < qtasCidades; linha++)
                for (int coluna = 0; coluna < qtasCidades; coluna++)
                    if (matriz[linha, coluna] != null)
                        dgv[coluna, linha].Value = matriz[linha, coluna].ToString();
        }


        //---------------------
        // BACKTRACKING PILHAS
        //---------------------

        public PilhaLista<CaminhoEntreCidades> BuscarCaminhoPil(int origem, int destino)
        {
            int cidadeAtual, saidaAtual;
            bool achouCaminho = false, naoTemSaida = false;

            bool[] passou = new bool[qtasCidades];

            for (int indice = 0; indice < qtasCidades; indice++)    // inicia os valores de “passou” 
                passou[indice] = false;                             // pois ainda não foi em nenhuma cidade

            cidadeAtual = origem;
            saidaAtual = 0;

            var pilha = new PilhaLista<CaminhoEntreCidades>();

            while (!achouCaminho && !naoTemSaida)
            {
                naoTemSaida = (cidadeAtual == origem && saidaAtual == qtasCidades && pilha.EstaVazia);
                if (!naoTemSaida)
                {
                    while ((saidaAtual < qtasCidades) && !achouCaminho)
                    {
                        if (matriz[cidadeAtual, saidaAtual] == null)
                            saidaAtual++;
                        else // há caminho da atual pra saida
                            if (passou[saidaAtual])
                            saidaAtual++;
                        else // há caminho e ainda n passou por ela
                        {
                            pilha.Empilhar(matriz[cidadeAtual, saidaAtual]);

                            if (saidaAtual == destino)
                                achouCaminho = true;
                            else
                            {
                                passou[cidadeAtual] = true;
                                cidadeAtual = saidaAtual;   // muda para a nova cidade 
                                saidaAtual = 0;            // reinicia busca de saídas da nova cidade 
                            }
                        }
                    }
                }
                if (!achouCaminho)
                    if (!pilha.EstaVazia)
                    {
                        var movim = pilha.Desempilhar();
                        saidaAtual = movim.IdCidadeDestino + 1; // a cidade destino anterior não presta, ent vamos para a próxima
                        cidadeAtual = movim.IdCidadeOrigem;
                        passou[movim.IdCidadeDestino] = false;
                        saidaAtual++;
                    }
            }

            return pilha.CopiaInvertida();
        }

        public List<PilhaLista<CaminhoEntreCidades>> BuscarCaminhosPil(int origem, int destino)
        {
            var ret = new List<PilhaLista<CaminhoEntreCidades>>(); // lista de todos os caminhos possíveis
            var pilha = new PilhaLista<CaminhoEntreCidades>(); //  caminho atual

            // variáveis auxiliares e suas inicializações
            int cidadeAtual = origem, saidaAtual = 0;
            bool achouCaminho, naoTemSaida = false;

            bool[] passou = new bool[qtasCidades];
            for (int indice = 0; indice < qtasCidades; indice++)   // inicia os valores de “passou” como false 
                passou[indice] = false;                            // pois ainda não foi em nenhuma cidade

            while (!naoTemSaida) //  enquanto houver saída
            {
                achouCaminho = false;

                while (!achouCaminho && !naoTemSaida) // enquanto não acharmos o destino
                {
                    // guarda em boolean se já passamos por todas as cidades do mapa e a pilha está vazia, isto é, não há saída
                    naoTemSaida = (cidadeAtual == origem && saidaAtual == qtasCidades && pilha.EstaVazia);
                    if (!naoTemSaida)
                    {
                        while ((saidaAtual < qtasCidades) && !achouCaminho)
                        {
                            // se não há saída pela cidade testada, verifica a próxima
                            if (matriz[cidadeAtual, saidaAtual].Custo == infinity)
                                saidaAtual++;
                            else // há caminho da cidade atual pra saida
                                if (passou[saidaAtual])
                                saidaAtual++;
                            else // há caminho e ainda não passou por ela
                            {
                                pilha.Empilhar(matriz[cidadeAtual, saidaAtual]);

                                if (saidaAtual == destino) // achamos a cidade destino
                                    achouCaminho = true;
                                else
                                {
                                    passou[cidadeAtual] = true; // marca a passagem pela cidade atual
                                    cidadeAtual = saidaAtual;   // muda para a nova cidade 
                                    saidaAtual = 0;            // reinicia busca de saídas da nova cidade 
                                }
                            }
                        }
                    }
                    if (!achouCaminho)
                        if (!pilha.EstaVazia)
                        {   // desempilha a configuração atual da pilha
                            // para a pilha da lista de parâmetros
                            var movim = pilha.Desempilhar();
                            saidaAtual = movim.IdCidadeDestino + 1; // a cidade destino anterior não presta, ent vamos para a próxima
                            cidadeAtual = movim.IdCidadeOrigem;
                            passou[movim.IdCidadeDestino] = false;
                            saidaAtual++;
                        }
                }
                if (pilha == null || pilha.EstaVazia)// escolher 1 dos 2
                    break;
                ret.Add(pilha.CopiaInvertida()); // adiciona o caminho encontrado na lista de caminhos possíveis
                saidaAtual++; // setta a nova cidade a ser testada atual+1
                pilha.Desempilhar();
            }
            return ret;
        }


        //-----------------------
        // BACKTRACKING RECURSÃO
        //-----------------------

        // variáveis utilizadas nos métodos de backtracking por recursão
        private List<PilhaLista<CaminhoEntreCidades>> listaCaminhos;  // lista de todos os caminhos possíveis
        private PilhaLista<CaminhoEntreCidades> caminho; // caminho atual
        private int cidadeAtual, saidaAtual;
        private bool achouCaminho, naoTemSaida;
        private bool[] passou;

        public List<PilhaLista<CaminhoEntreCidades>> BuscarCaminhosRec(int origem, int destino)
        {
            // (re)inicia as variáveis
            listaCaminhos = new List<PilhaLista<CaminhoEntreCidades>>();
            caminho = new PilhaLista<CaminhoEntreCidades>();
            cidadeAtual = origem;
            saidaAtual = 0;
            achouCaminho = naoTemSaida = false;
            passou = new bool[qtasCidades];
            for (int indice = 0; indice < qtasCidades; indice++)   // inicia os valores de “passou” como false 
                passou[indice] = false;

            // chama o método recursivo
            BuscarCaminhos(origem, destino);

            return listaCaminhos;
        }

        public void BuscarCaminhos(int origem, int destino)
        {
            if (naoTemSaida) // achou todos os caminhos
                return;

            if (!achouCaminho)
            {
                // guarda em boolean se já passamos por todas as cidades do mapa e a pilha está vazia, isto é, não há saída
                naoTemSaida = (cidadeAtual == origem && saidaAtual == qtasCidades && caminho.EstaVazia);
                if (!naoTemSaida)
                {
                    while ((saidaAtual < qtasCidades) && !achouCaminho)
                    {
                        // se não há saída pela cidade testada, verifica a próxima
                        if (matriz[cidadeAtual, saidaAtual].Custo == infinity)
                            saidaAtual++;
                        else // há caminho da cidade atual pra saida
                            if (passou[saidaAtual])
                            saidaAtual++;
                        else // há caminho e ainda não passou por ela
                        {
                            caminho.Empilhar(matriz[cidadeAtual, saidaAtual]);

                            if (saidaAtual == destino) // achamos a cidade destino
                                achouCaminho = true;
                            else
                            {
                                passou[cidadeAtual] = true; // marca a passagem pela cidade atual
                                cidadeAtual = saidaAtual;
                                saidaAtual = 0;
                            }
                        }
                    }

                    if (!achouCaminho)
                    {
                        if (!caminho.EstaVazia)
                        {   // desempilha a configuração atual da pilha
                            // para a pilha da lista de parâmetros
                            var movim = caminho.Desempilhar();
                            saidaAtual = movim.IdCidadeDestino + 1; // a cidade destino anterior não presta, ent vamos para a próxima
                            cidadeAtual = movim.IdCidadeOrigem;
                            passou[movim.IdCidadeDestino] = false;
                            saidaAtual++;
                        }
                        else
                            naoTemSaida = true;
                    }
                    else
                    {
                        listaCaminhos.Add(caminho.CopiaInvertida());
                        achouCaminho = false;
                        saidaAtual++;
                        caminho.Desempilhar();
                    }
                }
            }
            // após achar o caminho reinicia e procura outro
            BuscarCaminhos(origem, destino);
        }


        public PilhaLista<CaminhoEntreCidades> MenorCaminhoBacktracking(int linhas, ref List<PilhaLista<CaminhoEntreCidades>> cListaCaminhos, String criterio)
        {
            int menorDado = 0;
            PilhaLista<CaminhoEntreCidades> menorCaminho = null;

            for (int lin = 0; lin < linhas; lin++) // percorre a lista de caminhos
            {
                PilhaLista<CaminhoEntreCidades> pilhaCam = cListaCaminhos[lin]; // pega o lin-ésimo caminho
                PilhaLista<CaminhoEntreCidades> copia = pilhaCam.Copia(); // faz-se cópia para não entragar os dados que serão utilizados posteriormente

                int dado = 0;
                while (!copia.EstaVazia) // soma a distancia total do caminho atual
                {
                    switch (criterio)
                    {
                        case "Custo":
                            dado += copia.OTopo().Custo;
                            break;
                        case "Distancia":
                            dado += copia.OTopo().Distancia;
                            break;
                        case "Tempo":
                            dado += copia.OTopo().Tempo;
                            break;
                    }
                    copia.Desempilhar();
                }

                if (menorDado == 0 || dado < menorDado) // verifica se este é o menor caminho até então
                {
                    menorDado = dado;
                    menorCaminho = pilhaCam.Copia();
                }
            }

            total = menorDado;
            return menorCaminho;
        }



        //------------
        //  DIJKSTRA
        //------------

        private DadosOriginal[] percurso;
        private Vertice[] vertices;
        private int verticeAtual; // global usada para indicar o vértice atualmente sendo visitado
        private int doInicioAteAtual; // global usada para ajustar menor caminho com Djikstra

        public PilhaLista<CaminhoEntreCidades> MenorCaminhoDijkstra(int inicioDoPercurso, int finalDoPercurso, String criterio)
        {
            for (int j = 0; j < qtasCidades; j++) // setamos o vetor de vertices com o foiVisitado=false
                vertices[j].FoiVisitado = false;

            vertices[inicioDoPercurso].FoiVisitado = true; // visitamos a inicioDoPercurso

            for (int j = 0; j < qtasCidades; j++)
            {
                // anotamos no vetor percurso o valor do criterio entre o inicioDoPercurso e cada vértice
                // se não há ligação direta, o valor da distância será infinity
                int dado = 0;
                switch(criterio) // settamos a variável dado com o valor do criterio escolhido
                {
                    case "Custo":
                        dado = matriz[inicioDoPercurso, j].Custo;
                        break;
                    case "Distancia":
                        dado = matriz[inicioDoPercurso, j].Distancia;
                        break;
                    case "Tempo":
                        dado = matriz[inicioDoPercurso, j].Tempo;
                        break;
                }
                
                percurso[j] = new DadosOriginal(inicioDoPercurso, dado, criterio);
            }

            for (int nTree = 0; nTree < qtasCidades; nTree++)
            {
                // Procuramos a saída não visitada do vértice inicioDoPercurso com o menor dado
                int indiceDoMenor = ObterMenor();
                if (indiceDoMenor < 0)
                    break;
                // o vértice com o menor dado passa a ser o vértice atual
                // para compararmos com o dado calculado em AjustarMenorCaminho()
                verticeAtual = indiceDoMenor;
                doInicioAteAtual = percurso[indiceDoMenor].Criterio;
                // visitamos o vértice com o menor dado desde o inicioDoPercurso
                vertices[verticeAtual].FoiVisitado = true;

                AjustarMenorCaminho(criterio);
            }

            return MenorCaminho(inicioDoPercurso, finalDoPercurso); 
            // após encontrarmos os caminhos no vetor, chamamos o método MenorCaminho para colocá-lo em uma pilha
        }

        private int ObterMenor()
        {
            // retorna o indice da cidade com o menor valor do criterio escolhido entre todas as cidades ainda não visitadas
            int dadoMinimo = infinity;
            int indiceDaMinima = -1;

            for (int j = 0; j < qtasCidades; j++)
            {
                if (!(vertices[j].FoiVisitado) && (percurso[j].Criterio < dadoMinimo))
                {
                    dadoMinimo = percurso[j].Criterio;
                    indiceDaMinima = j;
                }
            }

            return indiceDaMinima;
        }

        private void AjustarMenorCaminho(String criterio)
        {
            // percorre todas as cidades ainda não visitadas e ajusta o melhor caminho desde a cidadeOrigem até cada uma delas,
            // alterando seus respectivos dados no vetor percurso
            for (int coluna = 0; coluna < qtasCidades; coluna++)
            {
                if (!vertices[coluna].FoiVisitado) // para cada vértice ainda não visitado
                {
                    // acessamos o valor do criterio desde o vértice atual (pode ser infinity)
                    int atualAteMargem = 0;
                    switch (criterio)
                    {
                        case "Custo":
                           atualAteMargem = matriz[verticeAtual, coluna].Custo;
                            break;
                        case "Distancia":
                            atualAteMargem = matriz[verticeAtual, coluna].Distancia;
                            break;
                        case "Tempo":
                           atualAteMargem = matriz[verticeAtual, coluna].Tempo;
                            break;
                    }
                    // calculamos o valor do criterio desde inicioDoPercurso passando por vertice atual até esta saída
                    int doInicioAteMargem = doInicioAteAtual + atualAteMargem;
                    // quando encontra um dado menor, marca o vértice a partir do
                    // qual chegamos no vértice de índice coluna, e a soma do valor
                    // do caminho até ele
                    int dadoDoCaminho = percurso[coluna].Criterio;
                    if (doInicioAteMargem < dadoDoCaminho && doInicioAteMargem>0)
                    {
                        percurso[coluna].VerticePai = verticeAtual;
                        percurso[coluna].Criterio = doInicioAteMargem;
                    }
                }
            }
        }

        private PilhaLista<CaminhoEntreCidades> MenorCaminho(int inicioDoPercurso, int finalDoPercurso)
        {
            // coleta os dados no vetor percurso do melhor caminho encontrado, do fim para o começo 
            // e o colocá em uma PilhaLista de CaminhoEntreCidades, retornando
            int onde = finalDoPercurso;
            PilhaLista<CaminhoEntreCidades> pilha = new PilhaLista<CaminhoEntreCidades>();

            //pega o total ate o id da cidadeDestino
            int idDestino = vertices[onde].Rotulo;
            total = percurso[idDestino].Criterio;

            while (onde != inicioDoPercurso)
            {
                idDestino = vertices[onde].Rotulo;
                int idOrigem = percurso[idDestino].VerticePai;
                onde = idOrigem;
                pilha.Empilhar(new CaminhoEntreCidades(idOrigem, idDestino));
            }
           
            return pilha; 
        }
    }
}

