using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SynergiesAutomation
{
    public class JobsPage
    {
        public static void FillApplyNowForm(string first_name, string last_name, string middle_name, string email_address, string phonenumber, string street_address,string city_name,string zip)
        {
            var firstName = Driver.Instance.FindElement(By.Id("first_name"));
            Driver.ScrollToElement(firstName);
            firstName.SendKeys(first_name);

            var lastName = Driver.Instance.FindElement(By.Id("last_name"));
            Driver.ScrollToElement(lastName);
            lastName.SendKeys(last_name);

            var middleName = Driver.Instance.FindElement(By.Id("middle_name"));
            Driver.ScrollToElement(middleName);
            middleName.SendKeys(middle_name);

            var email = Driver.Instance.FindElement(By.Id("email"));
            var email_confirm = Driver.Instance.FindElement(By.Id("email_confirm"));
            Driver.ScrollToElement(email);
            email.SendKeys(email_address);
            email_confirm.SendKeys(email_address);

            var phoneNumber = Driver.Instance.FindElement(By.Id("contact_number"));
            Driver.ScrollToElement(phoneNumber);
            phoneNumber.SendKeys(phonenumber);

            var address = Driver.Instance.FindElement(By.Id("street1"));
            var address2 = Driver.Instance.FindElement(By.Name("street2"));
            Driver.ScrollToElement(address);
            address.SendKeys(street_address);
            address2.SendKeys(street_address);

            var countrySelect = Driver.Instance.FindElement(By.Name("country_id"));
            SelectElement country = new SelectElement(countrySelect);
            country.SelectByText("Dominican Republic");

            Thread.Sleep(2000);
            var citySelect = Driver.Instance.FindElement(By.Name("state_id"));
            SelectElement city = new SelectElement(citySelect);
            city.SelectByText("Santiago");

            var cityName = Driver.Instance.FindElement(By.Id("city"));
            Driver.ScrollToElement(cityName);
            cityName.SendKeys(city_name);

            var zipCode = Driver.Instance.FindElement(By.Id("zip"));
            Driver.ScrollToElement(zipCode);
            zipCode.SendKeys(zip);



        }
    }
}
