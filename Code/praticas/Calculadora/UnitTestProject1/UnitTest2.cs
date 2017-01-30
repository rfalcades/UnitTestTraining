using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools;
using Calculadora;
using System.Data;

namespace UnitTestProject1
{
    [TestClass()]
    public class UnitTest2
    {
        private TestContext _testContext;
        public TestContext TestContext
        {
            get { return _testContext; }
            set { _testContext = value; }
        }

        
        [AssemblyInitialize]
        public static void TestPreAssembly(TestContext objContext)
        {
            objContext.WriteLine("Executei antes, teste de ambiente");
        }


        [ClassInitialize]
        public static void TestPreClasse(TestContext objContext)
        {
            objContext.WriteLine("Hora de inicio " + DateTime.Now.ToString());
        }


        [TestInitialize]
        public void TestPreMetodo()
        {
            op = new Operacoes();
            TestContext.WriteLine("Executei antes do " + TestContext.TestName);
        }

        [TestCleanup]
        public void TestPosMetodo()
        {
            
            TestContext.WriteLine("Executei depois do " + TestContext.TestName);
        }

        //CSV
        //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data.csv", "data#csv", DataAccessMethod.Sequential), DeploymentItem("data.csv"), TestMethod]
        //Excel
        //DataSource("System.Data.Odbc", "Dsn=ExcelFiles;Driver={Microsoft Excel Driver (*.xls)};dbq=|DataDirectory|\\Data.xls;defaultdir=.;driverid=790;maxbuffersize=2048;pagetimeout=5;readonly=true", "Sheet1$", DataAccessMethod.Sequential), DeploymentItem("Sheet1.xls"), TestMethod]
        //Caso de teste no Team Foundation Server
        //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.TestCase", "http://vlm13261329:8080/tfs/DefaultCollection;Agile", "30", DataAccessMethod.Sequential), TestMethod]
        //XML
        //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\data.xml", "Iterations", DataAccessMethod.Sequential), DeploymentItem("data.xml"), TestMethod]
        //SQL Express
        //[DataSource("System.Data.SqlClient", "Data Source=.\\sqlexpress;Initial Catalog=tempdb;Integrated Security=True", "Data", DataAccessMethod.Sequential), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\somar.csv", "somar#csv",
            DataAccessMethod.Sequential),
        DeploymentItem("somar.csv"),
        TestMethod]
        public void TestSomarCarga()
        {
            Operacoes op = new Operacoes();
            double x = Convert.ToDouble(_testContext.DataRow[0]);//"ValorX"
            double y = Convert.ToDouble(TestContext.DataRow[1]);//"ValorY"
            double esperado = Convert.ToDouble(_testContext.DataRow["Resultado"]);
            double obtido = op.somar(x, y);
            Assert.AreEqual(esperado, obtido);
        }
        //TDD
        //Crio meu teste.
        //Com Refatoração começo a criar meu teste.
        //Crio novo teste.
        // Refatoro meu código
        // Sempre melhorando meu código
        [TestMethod]
        public void TestTDD01Fatorial()
        {
            Operacoes op = new Operacoes();
            double esperado = 2;
            double x = 2;
            double obtido = op.fatorial(x);
            Assert.AreEqual(esperado, obtido);  
        }
        [TestMethod]
        public void TestTDD02Fatorial()
        {
            Operacoes op = new Operacoes();
            double esperado = 6;
            double x = 3;
            double obtido = op.fatorial(x);
            Assert.AreEqual(esperado, obtido);
        }
        [TestMethod]
        public void TestTDD03Fatorial()
        {
            Operacoes op = new Operacoes();
            double esperado = 24;
            double x = 4;
            double obtido = op.fatorial(x);
            Assert.AreEqual(esperado, obtido);
        }
        [TestMethod]
        public void TestTDD04Fatorial()
        {
            Operacoes op = new Operacoes();
            double esperado = 3628800;
            double x = 10;
            double obtido = op.fatorial(x);
            Assert.AreEqual(esperado, obtido);
        }
    }
}