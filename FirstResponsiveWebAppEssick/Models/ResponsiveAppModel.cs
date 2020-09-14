using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstResponsiveWebAppEssick.Models
{
    public class ResponsiveAppModel
    {
        public string UserName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string AgeThisYear()
        {
            
            if (DateOfBirth > DateTime.Now)
                return UserName + ", you entered a date in the future. Program will now terminate.";

            int years = DateTime.Now.Year - DateOfBirth.Year;

            if (DateTime.Now.Month < DateOfBirth.Month || DateTime.Now.Month == DateOfBirth.Month && DateTime.Now.Day < DateOfBirth.Day)
            { years--; }

            if (years >= 0)
            {
                return "Hello " + UserName+ ". You are " + years + " years old.";
            }
            else
            { return "Hello " + UserName + ". You are zero years old."; }
        }
    }
}
