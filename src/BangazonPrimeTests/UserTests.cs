using Xunit;
using BangazonPrimeBusinessObjects;
using System;

namespace BangazonPrimeTests
{
    public class UserTests
    {
        [Fact]
        public void PassingTest()
        {
            //Simple passing test
            var user = new User();
            var result = user.Add(2, 4);
            Assert.Equal(6, result);
        }

        [Fact]
        public void FailingTest()
        {
            //Example of a failing test, fix it
            var user = new User();
            var result = user.Add(2, 4);
            Assert.Equal(333, result); 
        }
        [Fact]
        public void UserHasBangazonPrime()
        {
            //No end date means the customer has an active Bangazon Prime membership, they
            //have not cancelled or let membership lapse past the 3 month trial period. 
            User bangazonUser = new User(DateTime.Now.AddMonths(-1), null, 123);
            bool actual = bangazonUser.IsPrimeUser;
            Assert.Equal(true, actual);
        }

        [Fact]
        public void UserIsNotBangazonPrimeUser()
        {
            //End Date in the past means no Bangazon prime membership, the user cancelled it on the end data
            User bangazonUser = new User(DateTime.Now.AddMonths(-11), DateTime.Now.AddMonths(-1), 344); 
            bool actual = bangazonUser.IsPrimeUser;
            Assert.Equal(false, actual);
        }

        [Fact]
        public void UserPhoneNumberisFormattedCorrectly()
        {
            //Format the phone number to a common format
            var user = new User();
            string phoneNum = "3143334089";
            string result = user.FormatPhoneNumber(phoneNum);
            Assert.Equal("314-333-4089", result );
        }
        [Fact]
        public void SubtractionFailingTest()
        {
            //This test is broken so you can see how a failed test looks and how to troubleshoot.
            var user = new User();
            var result = user.Subtract(5, 4);
            Assert.Equal(111, result);
        }

    }
}