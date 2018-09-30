using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using System;

namespace SeleniumIE.Demo
{
	class Program
	{
		static void Main(string[] args)
		{
			using (IWebDriver driver = new InternetExplorerDriver(@"Dependencies"))
			{
				driver.Navigate().GoToUrl("https://google.com");
			}
		}
	}
}
