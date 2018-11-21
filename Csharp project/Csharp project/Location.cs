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
        int StreetNumber;
        string StreetName;
        string County;
        string Postcode;
        int Latitude;
        int Longtitude;
        Year[] AllYears;

        public Location(string inName, int inStreetNo, string inStreetName, string inCounty, string inPostcode, int inLat, int inLong)
        {
            LocationName = inName;
            StreetNumber = inStreetNo;
            StreetName = inStreetName;
            County = inCounty;
            Postcode = inPostcode;
            Latitude = inLat;
            Longtitude = inLong;
            AllYears = null;
        }
        public Location(string inName, int inStreetNo, string inStreetName, string inCounty, string inPostcode, int inLat, int inLong, Year[] inAllYears)
        {
            LocationName = inName;
            StreetNumber = inStreetNo;
            StreetName = inStreetName;
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
        public void setStreetNumber(int inStreetNo)
        {
            StreetNumber = inStreetNo;
        }
        public void setStreetName(string inStreetName)
        {
            StreetName = inStreetName;
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
        public int getStreetNumber()
        {
            return StreetNumber;
        }
        public string getStreetName()
        {
            return StreetName;
        }
        public string getCounty()
        {
            return County;
        }
        public string getPostcode()
        {
            return Postcode;
        }
        public int getLatitude()
        {
            return Latitude;
        }
        public int getLongtitude()
        {
            return Longtitude;
        }
        public Year[] getAllYears()
        {
            return AllYears;
        }
    }
}
