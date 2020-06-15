using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_iCarros.Maps;

namespace UnitTestProject1.Page
{
    class iCarrosPage : iCarrosMaps
    {
        public void AbrirNavegador(string url)
        {
            GoToUrl(url);
        }

        public void RealizarPesquisa(string marca, string modelo, int timeout)
        {
            Clicar(inputAnunciosNovos, timeout);
            Clicar(btnMarca, timeout);
            Preencher(inputMarca, marca, timeout);
            Clicar(spanVolkswagen, timeout);
            Preencher(inputModelo, modelo, timeout);
            Clicar(spanFox, timeout);
            Clicar(btnBuscar, timeout);
        }

        public void ArmazenarPesquisa(int timeout)
        {
            CriarArquivo();
            int contador = 1;
            int indice = 0;
            string[] dados = new string[18] ;
            char[] trim = { '\r', '\n','p','r','e','ç','o',' ','à','v','i','s','t','a' };

            do
            {
                string titulo = ArmazenarTexto(basepath + contador + h2Titulo, timeout);
                dados[indice] = titulo;
                indice++;
                string valor = ArmazenarTexto(basepath + contador + h3PrecoAVista, timeout).Trim(trim);
                dados[indice] = valor;
                indice++;
                string ano = ArmazenarTexto(basepath + contador + ano_veiculo, timeout);
                dados[indice] = ano;
                indice++;
                string km = ArmazenarTexto(basepath + contador + km_veiculo, timeout);
                dados[indice] = km;
                indice++;
                string cor = ArmazenarTexto(basepath + contador + cor_veiculo, timeout);
                dados[indice] = cor;
                indice++;
                string cambio = ArmazenarTexto(basepath + contador + cambio_veiculo, timeout);
                dados[indice] = cambio;
                indice++;

                contador++;
                
            } while (contador <= 3);
            ArmazenarArquivo(dados);
            FecharNavegador();
        }

        public void ValidarPesquisa(int timeout)
        {
            int contador = 1;
            int indice = 0;
            string[] dados = LerArquivo();

            do
            {
                string titulo = dados[indice];
                Comparar(basepath + contador + h2Titulo, titulo,  timeout);
                indice++;
                string valor = dados[indice];
                Comparar(basepath + contador + h3PrecoAVista, valor, timeout);
                indice++;
                string ano = dados[indice];
                Comparar(basepath + contador + ano_veiculo, ano, timeout);
                indice++;
                string km = dados[indice];
                Comparar(basepath + contador + km_veiculo, km, timeout);
                indice++;
                string cor = dados[indice];
                Comparar(basepath + contador + cor_veiculo, cor, timeout);
                indice++;
                string cambio = dados[indice];
                Comparar(basepath + contador + cambio_veiculo, cambio, timeout);
                indice++;
                contador++;
            } while (contador <= 3);
            DeletarArquivo();
            FecharNavegador();
        }
    }
}
