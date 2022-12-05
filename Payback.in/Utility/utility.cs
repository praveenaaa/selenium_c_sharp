using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payback_Po.Utility
{
    public class utility : ConfigClass
    {
        public void LaunchBrowser(string browser)
        {

            driver = new ChromeDriver(chromeDriverPath);
        }
        public void browserMaximize()
        {
            driver.Manage().Window.Maximize();
        }

        public void PageLoad()
        {
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(PAGE_LOAD_TIMEOUT);
        }

        public void ImplicitWait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(IMPLICIT_WAIT);
        }

        public void LaunchApp(string url)
        {
            driver.Url = url;
        }

        public void CloseBrowser()
        {
            driver.Quit();
        }
        public void CaptureScreenshot()
        {

            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;

            Screenshot screenshot = screenshotDriver.GetScreenshot();

            screenshot.SaveAsFile(filePath + "/screenshot.png", ScreenshotImageFormat.Png);


        }
        public string ValidatePageTitle()
        {
            return driver.Title;
        }

        public void Hover(IWebElement element)
        {
            action = new Actions(driver);
            action.MoveToElement(element).Perform();
        }

    }
}
