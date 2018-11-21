using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_project
{
    class Year
    {
        int theYear;
        string YearDescription;
        Monthly_Observations[] theMonthlyObservations;

        public Year(int inYear, string inYearDescription)
        {
            theYear = inYear;
            YearDescription = inYearDescription;
            theMonthlyObservations = null;
        }
        public Year(int inYear, string inYearDescription, Monthly_Observations[] inMonthlyObservations)
        {
            theYear = inYear;
            YearDescription = inYearDescription;
            theMonthlyObservations = inMonthlyObservations;
        }

        public void setMontlyObservations (Monthly_Observations[] inMonthlyObservations)
        {
            theMonthlyObservations = inMonthlyObservations;
        }

        public int getYear()
        {
            return theYear;
        }
        public string getYearDescription()
        {
            return YearDescription;
        }
        public Monthly_Observations[] getMonthlyObservations()
        {
            return theMonthlyObservations;
        }
    }
}
