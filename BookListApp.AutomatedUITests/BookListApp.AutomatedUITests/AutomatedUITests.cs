using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Xunit;

namespace BookListApp.AutomatedUITests
{
    public class AutomatedUITests: IDisposable  
    {
        public readonly IWebDriver _driver;

        public AutomatedUITests()
        {
            _driver = new ChromeDriver();
        }

        public void Dispose()
        {
            _driver.Quit();
            _driver.Dispose();
        }

        [Fact]
        public void Create_WhenExecuted_ReturnsHome()
        {
            _driver.Navigate().GoToUrl("https://localhost:44308/");

            Assert.Equal("Home page - BookListRazor", _driver.Title);
            Assert.Contains("Welcome, Utsab", _driver.PageSource);

        }
        [Fact]
        public void Create_WhenExecuted_ReturnsBookList()
        {
            _driver.Navigate().GoToUrl("https://localhost:44308/BookList");
            Assert.Contains("Book List", _driver.PageSource);
        }

        [Fact]
        public void Create_WhenExecuted_Returns_Error()
        {
            _driver.Navigate().GoToUrl("https://localhost:44308/BookList/Create");
            _driver.FindElement(By.Name("Name")).SendKeys("");
            _driver.FindElement(By.Name("Author")).SendKeys("Tom");
            _driver.FindElement(By.Name("ISBN")).SendKeys("1234");
            _driver.FindElement(By.Name("Create")).Click();

            var errorMessage = _driver.FindElement(By.Name("Error")).Text;

            Assert.Contains("The Name field is required.", _driver.PageSource);

        }
        
    }
}
