using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using UnitTestProject1.Page;

namespace Web_iCarros.Steps
{
    [Binding]
    class iCarrosSteps : iCarrosPage
    {

        [Given(@"que o usuario acessa a plataforma ""(.*)""")]
        public void DadoQueOUsuarioAcessaAPlataforma(string p0)
        {
            AbrirNavegador(p0);
        }


        [When(@"realizar a pesquisa de veiculos usados")]
        public void QuandoRealizarAPesquisaDeVeiculosUsados(Table table)
        {
            var dadosTabela = DicionarioTable(table);
            RealizarPesquisa(dadosTabela["Marca"], dadosTabela["Modelo"], 10);
        }

        [Then(@"armazenar dados da pesquisa")]
        public void EntaoArmazenarDadosDaPesquisa()
        {
            ArmazenarPesquisa(10);
        }

        [Then(@"validar os dados armazenados da pesquisa")]
        public void EntaoValidarOsDadosArmazenadosDaPesquisa()
        {
            ValidarPesquisa(10);
        }
    }
}
