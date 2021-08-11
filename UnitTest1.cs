using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Threading;

namespace DesktopAppAutomation
{
    public class Tests
    {
        public const string DriverUrl = "http://127.0.0.1:4723/";
        public WindowsDriver<WindowsElement> DesktopSession;
        [SetUp]
        public void Setup()
        {
            AppiumOptions Options = new AppiumOptions();
            Options.AddAdditionalCapability("app", "C:\\Windows\\explorer.exe");
            Options.AddAdditionalCapability("deviceName", "WindowsPC");
            DesktopSession = new WindowsDriver<WindowsElement>(new Uri(DriverUrl), Options);
            Assert.IsNotNull(DesktopSession);
            
          }
        [Test]
        public void Hello()

        {
            Thread.Sleep(5000);
            WindowsElement search = DesktopSession.FindElementByXPath("//*[@LocalizedControlType='edit']");
            Thread.Sleep(8000);
            search.SendKeys("     Search me");
        }
        [TearDown]
        public void Close()
        {
            //DesktopSession.CloseApp();
        }
    }
}
