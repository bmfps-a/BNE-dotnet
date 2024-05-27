using System.Collections;
using System.Security.Cryptography.X509Certificates;
using Xunit;

namespace Loja.Tests
{
    public class DescontoTests
    {
        [Fact]
        public void calculo_desconto()
        {
            
            var desconto = new Desconto();
            
            
            var valor = desconto.Calcule(Cor.Vermelho);
                   
               
            var valor2 = desconto.Calcule(Cor.Verde);
               
            var valor3 = desconto.Calcule(Cor.Azul);
           
                
                
            Assert.Equal(10, valor);
                   
            
            
        }
    }
}
