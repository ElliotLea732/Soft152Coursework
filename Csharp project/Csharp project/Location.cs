using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_project
{
    class Location
    {
        string LocationName;
        string StreetNameAndNumber;
        string County;
        string Postcode;
        double Latitude;
        double Longtitude;
        Year[] AllYears;

        public Location(string inName, string inStreetNameAndNo, string inCounty, string inPostcode, double inLat, double inLong)
        {
            LocationName = inName;
            StreetNameAndNumber = inStreetNameAndNo;
            County = inCounty;
            Postcode = inPostcode;
            Latitude = inLat;
            Longtitude = inLong;
            AllYears = null;
        }
        public Location(string inName, string inStreetNameAndNo, string inCounty, string inPostcode, double inLat, double inLong, Year[] inAllYears)
        {
            LocationName = inName;
            StreetNameAndNumber = inStreetNameAndNo;
            County = inCounty;
            Postcode = inPostcode;
            Latitude = inLat;
            Longtitude = inLong;
            AllYears = inAllYears;
        }

        public void setName(string inName)
        {
            LocationName = inName;
        }
        public void setStreetName(string inStreetNameAndNo)
        {
            StreetNameAndNumber = inStreetNameAndNo;
        }
        public void setCounty(string inCounty)
        {
            County = inCounty; 
        }
        public void setPostcode(string inPostcode)
        {
            Postcode = inPostcode;
        }
        public void setLat(int inLat)
        {
            Latitude = inLat;
        }
        public void setLong(int inLong)
        {
            Longtitude = inLong;
        }
        public void setYears(Year[] inAllYears)
        {
            AllYears = inAllYears;
        }

        public string getLocationName()
        {
            return LocationName;
        }
        public string getStreetNameAndNumber()
        {
            return StreetNameAndNumber;
        }
        public string getCounty()
        {
            return County;
        }
        public string getPostcode()
        {
            return Postcode;
        }
        public double getLatitude()
        {
            return Latitude;
        }
        public double getLongtitude()
        {
            return Longtitude;
        }
        public Year[] getAllYears()
        {
            return AllYears;
        }
    }
}
