﻿using System;
using OpenQA.Selenium;

namespace Framework.Pages
{
        public class RegistrationPage
        {
            private IWebDriver driver;

            public RegistrationPage(IWebDriver driver)
            {
                this.driver = driver;
            }

            public void FillRegistrationForm(string name, string lastName, string email, string phoneNumber, string password)
            {
            
            By nameInputLocator = By.XPath("//*[@id=\"root\"]/main/div[2]/form/fieldset[1]/div[1]/div[1]/input");
            By lastNameInputLocator = By.XPath("//*[@id=\"root\"]/main/div[2]/form/fieldset[1]/div[1]/div[2]/input");
            By emailInputLocator = By.XPath("//*[@id=\"root\"]/main/div[2]/form/fieldset[1]/div[2]/div[1]/input");
            By phoneNumberInputLocator = By.XPath("//*[@id=\"root\"]/main/div[2]/form/fieldset[1]/div[2]/div[2]/input");
            By passwordInputLocator = By.XPath("//*[@id=\"root\"]/main/div[2]/form/fieldset[2]/div/div[1]/div/input");

            Common.SetText(nameInputLocator, name);
            Common.SetText(lastNameInputLocator, lastName);
            Common.SetText(emailInputLocator, email);
            Common.SetText(phoneNumberInputLocator, phoneNumber);
            Common.SetText(passwordInputLocator, password);
        }
    }

            public void AcceptTermsAndConditions()
            {
        
        By termsCheckboxLocator = By.XPath("//*[@id=\"agreement\"]");
        Common.ClickElement(termsCheckboxLocator);
    }

            public void ClickRegistrationButton()
            {

        By registrationButtonLocator = By.XPath("//*[@id=\"root\"]/main/div[2]/form/div/div/div/button");
        Common.ClickElement(registrationButtonLocator);
    }

            public bool IsRegistrationSuccessful()
            {
                
                return true;
            }

            
        }

    }
}

