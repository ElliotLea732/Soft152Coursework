using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_project
{
    class Monthly_Observations
    {
        int MonthIDNumber;
        double MaximumTemperature;
        double MinimumTemperature;
        double NumberofDaysofAirFrost;
        double MillimetresofRainfall;
        double HoursofSunshine;

        public Monthly_Observations(int MonthID, double MaxTemp, double MinTemp, double NoAirFrost, double MilimetresRainfall, double HoursSunshine)
        {
            MonthIDNumber = MonthID;
            MaximumTemperature = MaxTemp;
            MinimumTemperature = MinTemp;
            NumberofDaysofAirFrost = NoAirFrost;
            MillimetresofRainfall = MilimetresRainfall;
            HoursofSunshine = HoursSunshine;
        }

        public void setID(int inID)
        {
            MonthIDNumber = inID;
        }
        public void setMaxTemp(int inMaxTemp)
        {
            MaximumTemperature = inMaxTemp;
        }
        public void setMinTemp(int inMinTemp)
        {
            MinimumTemperature = inMinTemp;
        }
        public void setNumAirFrost(int inNumAirFrost)
        {
            NumberofDaysofAirFrost = inNumAirFrost;
        }
        public void setMilimetresRainfall(int inRainfall)
        {
            MillimetresofRainfall = inRainfall;
        }
        public void setHoursSunshine(int inSunshine)
        {
            HoursofSunshine = inSunshine;
        }

        public int getID()
        {
            return MonthIDNumber;
        }
        public double getMaxTemp()
        {
            return MaximumTemperature;
        }
        public double getMinTemp()
        {
            return MinimumTemperature;
        }
        public double getNumAirFrost()
        {
            return NumberofDaysofAirFrost;
        }
        public double getRainfall()
        {
            return MillimetresofRainfall;
        }
        public double getHoursSunshine()
        {
            return HoursofSunshine;
        }

    }
}
