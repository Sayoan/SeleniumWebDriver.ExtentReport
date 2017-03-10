﻿using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumWebDriver.Basics
{
    //Modificar de acesso public
    public class Tests : WebDriver
    {



        /// <summary>
        /// Método de teste usa decoração [Test]: após build será exibido no menu "Test Explorer"
        /// Todo método de teste tem um assert para validar o resultado esperado
        /// </summary>
        [Test]
        public void acessarTestMoz()
        {
            Assert.AreEqual("Testmoz Test", driver.Title);
        }


        /// <summary>
        /// Método de teste que insere nome, clica no botão e acessa a página de Quiz
        /// Inclui métodos provenientes de classes PageObject com tratamento de exceções
        /// </summary>
        [Test]
        public void acessarQuizTestMoz()
        {
            StudentLoginPageObjects studentLogin = new StudentLoginPageObjects();

            //Inserir um valor em campo inpuut: limpe o campo e envie a string/valor
            studentLogin.preencherName("Nome teste quiz");

            //Após inserir as informações clicar no botão para continuar
            studentLogin.clicarContinue();

            //Validar que avançou para a próxima página
            //Utilize algum elemento ou frase da página
            Assert.AreEqual("This quiz determines if you know anything about Testmoz.", driver.FindElement(By.Id("introduction")).Text);
        }

    }
}