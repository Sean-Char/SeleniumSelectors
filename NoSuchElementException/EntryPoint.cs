using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

class EntryPoint
{
    static void Main()
    {
        string url = "http://testing.todvachev.com/selectors/css-path/";
        string cssPath = "#post-108 > div > fig img"; // break css path selector will cause crash
        string xPath = "//*[@id=\"post-108\"]/div/figure/img"; 

        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl(url);


        // use try / catch to solve crash 
        try
        {
            IWebElement cssPathElement = driver.FindElement(By.CssSelector(cssPath));

            if (cssPathElement.Displayed)
                GreenMessage("I can see the Css Path Element!");
            
        }
        catch (NoSuchElementException)
        {
            RedMessage("Something went wrong. Css Path Element not found!");
        }

        try
        {
            IWebElement xPathElement = driver.FindElement(By.XPath(xPath));

            if (xPathElement.Displayed)
                GreenMessage("I can see the X Path Element!");

        }
        catch (NoSuchElementException)
        {
            RedMessage("Something went wrong. X Path Element not found!");
        }

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

