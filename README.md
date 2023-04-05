# automate.test
Selenium Web Automation Tool 

1. Exemplo de navegação em paginas 

using AutomationTest.Core;

namespace Test
{
    public class Program
    {
        private static SeleniumHelper Selenium = new SeleniumHelper(new ConfigurationHelper());

        static void Main(string[] args)
        {
            Console.WriteLine(".:: 1. Exemplo de Abrir Navegador");
        
            Selenium.GoToUrl("https://www.google.com");

            Console.WriteLine(".:: 2. Exemplo de setar valor no campo");
            Selenium.FillTextBoxByXPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/input", "xjur"); 
           

            Console.WriteLine(".:: 3. Exemplo de cliques");
            Selenium.ClickByXPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[4]/center/input[1]"); 
            Selenium.ClickByXPath("/html/body/div[7]/div/div[11]/div/div[2]/div[2]/div/div/div[1]/div/div/div/div/div/div/div[1]/a/h3");


            Console.WriteLine(".:: 4. Exemplo de obter valor");
            var valor = Selenium.GetTextByXPath("/html/body/div[1]/div/div/div/div/article/div/div/section[1]/div[3]/div[1]/div/div[1]/div/div/div[1]/h4");
            Console.WriteLine(".:: 5. Valor obtido: " + valor);

            Selenium.Delay(10000);
            Selenium.Dispose();

            Console.WriteLine(".:: Fim do exemplo");
        }
    }
} 


2. Como copiar o XPath dos componentes em HTML
![COMO_COPIAR_XPATH](https://user-images.githubusercontent.com/21311134/229977288-136b401b-9300-4418-809a-d7527ea9d31e.png)

3. Atualizar versão do chorme
![deixar_chorme_atualizado_nessa_versao](https://user-images.githubusercontent.com/21311134/229977274-9398d263-e849-425f-a6f1-eb09c36ecd2b.PNG)