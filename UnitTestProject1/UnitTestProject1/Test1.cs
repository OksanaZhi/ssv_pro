using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using Docker.DotNet.Models;
using NUnit.Framework;
using NUnit.Framework.Internal;

public class UntitledTestCase
{
    private WebDriver driver;
    private String baseUrl;
    private boolean acceptNextAlert = true;
    private StringBuffer verificationErrors = new StringBuffer();
    JavascriptExecutor js;
  }

@Test
  public void testUntitledTestCase() Throws Exception
{
    driver.get("http://localhost/addressbook/");
    driver.findElement(By.id("logo")).click();
    acceptNextAlert = true;
    driver.findElement(By.id("4")).click();
    driver.findElement(By.xpath("//input[@value='Delete']")).click();
    assertTrue(closeAlertAndGetItsText().matches("^Delete 1 addresses[\\s\\S]$"));
    driver.findElement(By.id("logo")).click();
    driver.findElement(By.name("username")).click();
    driver.findElement(By.name("password")).click();
    driver.findElement(By.name("password")).clear();
    driver.findElement(By.name("password")).sendKeys("postgres");
    driver.findElement(By.id("f12d670948")).click();
    }

    
}

