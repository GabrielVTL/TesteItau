using System;
using System.Collections.Generic;
using System.Text;
using Web_iCarros.Utils;

namespace Web_iCarros.Maps
{
    class iCarrosMaps : Util
    {
        //Pesquisa
        public string inputAnunciosNovos = "//input[@name='anunciosNovos']";
        public string btnMarca = "//button[@data-id = 'sltMake']";
        public string inputMarca = "//button[@data-id = 'sltMake']/../div//input";
        public string spanVolkswagen = "//div[@class='btn-group bootstrap-select open']//li//span[text()='Volkswagen']";
        public string btnModelo = "//button[@data-id = 'sltModel']";
        public string inputModelo = "//button[@data-id = 'sltModel']/../div//input";
        public string spanFox = "//div[@class='btn-group bootstrap-select open']//li//span[text()='Fox']";
        public string btnBuscar = "//button[text()='Buscar']";

        //Listagem da Pesquisa
        public string basepath = "//ul[@class='listavertical']//li[";
        public string h2Titulo = "]//h2";
        public string h3PrecoAVista = "]//h3";
        public string ano_veiculo = "]//div[@class='dados_veiculo']//ul[@class='listahorizontal'][1]/li[1]/p";
        public string km_veiculo = "]//div[@class='dados_veiculo']//ul[@class='listahorizontal'][1]/li[2]/p";
        public string cor_veiculo = "]//div[@class='dados_veiculo']//ul[@class='listahorizontal'][1]/li[3]/p";
        public string cambio_veiculo = "]//div[@class='dados_veiculo']//ul[@class='listahorizontal'][1]/li[4]/p";
    }
}
