using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TechTalk.SpecFlow;
using Web_iCarros.Driver;

namespace Web_iCarros.Utils
{
    class Util : Drivers
    {
        WebDriverWait wait = new WebDriverWait(AbrirChrome(), TimeSpan.FromSeconds(10));
        public static string path = Directory.GetParent(Directory.GetCurrentDirectory()) + "\\File\\iCarrosFoxUsados.txt";

        //Esperar Elemento Ser Visível
        public IWebElement EsperarElemento(string xpath)
        {
            IWebElement element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(xpath)));
            return element;
        }

        //Clicar no elemento
        public Boolean Clicar(string xpath, int timeout)
        {
            var element = EsperarElemento(xpath);
            element.Click();

            return false;
        }

        //Armazenar texto
        public string ArmazenarTexto(string xpath, int timeout)
        {
            var element = EsperarElemento(xpath);
            string texto = "";
            int contador = 0;

            do
            {
                try
                {
                    if (!element.Displayed)
                    {
                        return null;
                    }
                    else
                    {
                        texto = element.Text;
                        return texto;
                    }
                }
                catch
                {
                    contador++;
                }
            }while (contador <= timeout) ;
            return null;
        }

        //Preencher campos
        public Boolean Preencher(string xpath, string valor, int timeout)
        {
            var element = EsperarElemento(xpath);
            int contador = 0;
            do
            {
                try
                {
                    if (!element.Displayed)
                    {
                        return false;
                    }
                    else
                    {
                        element.Clear();
                        element.SendKeys(valor);
                        return true;
                    }

                }
                catch
                {
                    contador++;
                }
            } while (contador <= timeout);
            return false;
        }

        //Compara igualdade entre textos
        public Boolean Comparar(string xpath, string mensagem, int timeout)
        {
            var element = EsperarElemento(xpath);
            int contador = 0;
            do
            {
                try
                {
                    if (!element.Displayed)
                    {
                        return false;
                    }
                    else
                    {
                        string mensagemObtida = element.Text;
                        Assert.AreEqual(mensagemObtida, mensagem);
                        return true;
                    }
                }
                catch
                {
                    contador++;
                }
            } while (contador <= timeout);
            return false;
        }

        //Separa as informações da tabela da Feature
        public static Dictionary<string, string> DicionarioTable(Table table)
        {
            var dictionary = new Dictionary<string, string>();
            foreach (var row in table.Rows)
            {
                dictionary.Add(row[0], row[1]);
            }
            return dictionary;
        }

        //Criando o arquivo txt
        public static void CriarArquivo()
        {
            File.Create(@path);
        }

        //Armazenar texto no arquivo txt
        public static void ArmazenarArquivo(string[] valor)
        {
            File.WriteAllLines(@path, valor);
        }

        //Ler as linhas
        public static string[] LerArquivo()
        {
            string[] arquivo = File.ReadAllLines(@path);
            return arquivo;
        }

        //Deleta o arquivo
        public static void DeletarArquivo()
        {
            File.Delete(path);
        }
    }
}
