#I "/Library/Frameworks/Mono.framework/Versions/Current/lib/mono/4.0"
#I "./Selenium.WebDriver.2.39.0/lib/net40/"
#I "./Selenium.Support.2.39.0/lib/net40/"
#I "./SizSelCsZzz.0.3.35.0/lib/"
#I "./Newtonsoft.Json.5.0.8/lib/net40"

#r "WebDriver.Support.dll"
#r "WebDriver.dll"

#load "helloworld.fsx"

open OpenQA.Selenium.Support.UI
open OpenQA.Selenium.Chrome

let browser = new ChromeDriver("./")

browser.Navigate().GoToUrl("http://google.com")
browser.Quit()

