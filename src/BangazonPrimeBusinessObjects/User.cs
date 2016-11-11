
using System;
using System.Text.RegularExpressions;

namespace BangazonPrimeBusinessObjects
{
    public class User
    {
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int UserId { get; set; }
        public bool IsPrimeUser { get; set; }

        public User()
        {
        }

        public User(DateTime startDate, DateTime? endDate, int userId)
        {
            this.EndDate = endDate;
            this.IsPrimeUser = this.EndDate == null ? true : false;
        }
       
        public int Add(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }
        public int Subtract(int firstNum, int secondNum)
        {
            return firstNum - secondNum;
        }

        public string FormatPhoneNumber(string phoneNum)
        {
            string _formattedPhoneNumber= Regex.Replace(phoneNum, @"(\d{3})(\d{3})(\d{4})", "$1-$2-$3");
            return _formattedPhoneNumber;
        }
    }
}