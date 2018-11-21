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
        int MaximumTemperature;
        int MinimumTemperature;
        int NumberofDaysofAirFrost;
        int MillimetresofRainfall;
        int HoursofSunshine;

        public Monthly_Observations(int MonthID, int MaxTemp, int MinTemp, int NoAirFrost, int MilimetresRainfall, int HoursSunshine)
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
        public int getMaxTemp()
        {
            return MaximumTemperature;
        }
        public int getMinTemp()
        {
            return MinimumTemperature;
        }
        public int getNumAirFrost()
        {
            return NumberofDaysofAirFrost;
        }
        public int getRainfall()
        {
            return MillimetresofRainfall;
        }
        public int getHoursSunshine()
        {
            return HoursofSunshine;
        }

    }
}
