using AutomationTest.Core;

namespace Test
{
    // 1. Exemplo de abrir navegador.
    // 2. Olhar na pasta documentação Test/Documentacao/como_copiar_xpath_do_componente.png, como copiar o xpath de um determado campo
    // 3. Olhar na pasta documentação Test/Documentacao/deixar_chorme_atualizado_nessa_versao mais nova, no proprio link da imagem é possivel atualizar para versão 112.

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