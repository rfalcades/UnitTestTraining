using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using UnitTest;

namespace UtilityLibtesting
{
    [TestFixture]
    public class TestCase
    {
        // __________ Teste para Resultados Esperados__________

        // Caso de teste # 1: o valor de vendas é maior ou igual a 1000: Verificação
        [Test] 
        public void OneThousand_G_E()
        {
            UtilityLib obj =new UtilityLib();
            Assert.AreEqual(950,obj.calculateDiscount(1000));
        }
        // Caso de teste # 2: o valor de vendas é maior ou igual a 2000: Verificação
        [Test] 
        public void TwoThousand_G_E()
        {
            UtilityLib obj =new UtilityLib();
            Assert.AreEqual(1800, obj.calculateDiscount(2000));
        }
        // Caso de teste # 3: o valor de vendas é maior ou igual a 5000: Verificação
        [Test] 
        public void FiveThousand_G_E()
        {
            UtilityLib obj =new UtilityLib();
 
            Assert.AreEqual(2500, obj.calculateDiscount(5000));
        }
        // Caso de Teste # 4: O Valor de Vendas é 0: Verificação
        [Test] 
        public void ZeroAmount()
        {
            UtilityLib obj =new UtilityLib();
            try
            {
                obj.calculateDiscount(0);
            }
            catch (Exception e) { }
        }
        // Caso de Teste # 5: Valor de Vendas abaixo de 1000: Verificação
        [Test]
        public void OneThousand_Below()
        {
            UtilityLib obj =new UtilityLib();
            Assert.AreEqual(999, obj.calculateDiscount(999));
        }

        // __________ Teste dos Resultados Reais __________
        // Caso de Teste # 6: O Valor das Vendas não produz resultados esperados: Verificação
        [Test] 
        public void OneThousand()
        {
            UtilityLib obj =new UtilityLib();
             Assert.AreNotEqual(930, obj.calculateDiscount(1000));
        }

        // Caso de Teste # 7: O Valor das Vendas não produz resultados esperados: Verificação
        [Test] 
        public void TwoThousand()
        {
            UtilityLib obj =new UtilityLib();
            Assert.AreNotEqual(1900, obj.calculateDiscount(2000));
        }
    }
}