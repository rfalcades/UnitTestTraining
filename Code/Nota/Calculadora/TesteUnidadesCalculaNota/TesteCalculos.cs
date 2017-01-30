using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Calculadora;
using System.Collections.Generic;

namespace TesteUnidadesCalculaNota
{
    [TestClass]
    public class TesteCalculos
    {
        private Mock<InterfaceAluno> _mockAluno;
        [TestMethod]
        public void TestNotaAluno()
        {
            Int32 esperado = 16;
            ClasseAluno _aluno = new ClasseAluno()
            {
                cod_aluno = "1",
                nome = "Gorayb",
                pontos = 3
            };
            List<Int32> notas = new List<Int32>();
            notas.Add(6);
            notas.Add(7);
            _mockAluno = new Mock<InterfaceAluno>();
            ClasseCalculaNota _calculo = new ClasseCalculaNota(_mockAluno.Object);
            _mockAluno.Setup(x => x.GetAluno(It.IsAny<string>())).Returns(_aluno);
            Int32 obitido = _calculo.CalcularNota("Tanto Faz", notas);
            Assert.AreEqual(esperado, obitido);
        }


        //[TestMethod]
        //public void TestGetAluno()
        //{
            //ClasseAluno objTeste = new ClasseAluno();
            //var objT = objTeste.GetAluno("2");
            //Int32 obitido = objT.pontos;
            //Int32 esperado = 2;
            //Assert.AreEqual(esperado, obitido);
        //}
    }
}