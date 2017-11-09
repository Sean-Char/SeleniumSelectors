using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint
{
    static void Main()
    {
        // create driver instance
        IWebDriver driver = new ChromeDriver();

        // go to web page
        driver.Navigate().GoToUrl("http://testing.todvachev.com/selectors/name/");

        // select element on the page
        IWebElement element = driver.FindElement(By.Name("myName"));

        // verify if element is on the page
        if (element.Displayed)
            GreenMessage("Yes I can see the name element.");
        else
            RedMessage("Well something went wrong. Name element not found!");

        driver.Quit();
    }

    private static void RedMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }

    private static void GreenMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
}

