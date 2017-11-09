using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint
{
    static void Main()
    {
        string url = "http://testing.todvachev.com/selectors/id/";
        string ID = "testImage";

        // create driver instance
        IWebDriver driver = new ChromeDriver();

        // go to web page
        driver.Navigate().GoToUrl(url);

        // select element on the page
        IWebElement element = driver.FindElement(By.Id(ID));

        // verify if element is on the page
        if (element.Displayed)
            GreenMessage("Yes I can see the id element.");
        else
            RedMessage("Well something went wrong. Id element not found!");

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

