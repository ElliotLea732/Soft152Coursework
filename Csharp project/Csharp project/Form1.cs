using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Csharp_project
{
    public partial class frmMenu : Form
    {

        Location[] AllLocations;

        public frmMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            readData();
        }

        private void readData()
        {
            string filename, inName, inStreetNameAndNo, inCounty, inPostcode;
            int NoOfYears;
            double inLat, inLong;

            openFileDialog1.ShowDialog();
            filename = openFileDialog1.FileName;

            StreamReader input = new StreamReader(filename);

            input.ReadLine();

            while (!input.EndOfStream)
            {
                inName = input.ReadLine();
                inStreetNameAndNo = input.ReadLine();
                inCounty = input.ReadLine();
                inPostcode = input.ReadLine();
                inLat = Convert.ToDouble(input.ReadLine());
                inLong = Convert.ToDouble(input.ReadLine());
                NoOfYears = Convert.ToInt32(input.ReadLine());

                Location TempLoc = new Location(inName, inStreetNameAndNo, inCounty, inPostcode, inLat, inLong);

                TempLoc.setYears(getNextYearArray(input, TempLoc.getAllYears(), NoOfYears));

                growArray(ref AllLocations);

                AllLocations[AllLocations.Length - 1] = TempLoc;
            
            }
            input.Close();
        }

        private void growArray(ref Location[] currentArray)
        {
            int ArraySize;

            if (currentArray == null)
                ArraySize = 0;
            else
                ArraySize = currentArray.Length;
            Array.Resize(ref currentArray, ArraySize + 1);
        }



        private Year[] getNextYearArray(StreamReader input, Year[] NewYears, int NoOfYears)
        {
            string inYearDescription;
            int inYear, ArraySize;

            for (int i = 0; i < NoOfYears; i++)
            {
                inYearDescription = input.ReadLine();
                inYear = Convert.ToInt32(input.ReadLine());

                Year TempYear = new Year(inYear, inYearDescription);

                TempYear.setMontlyObservations(getNextMonthlyObservationsArray(input, TempYear.getMonthlyObservations()));


                if (NewYears == null)
                    ArraySize = 0;
                else
                    ArraySize = NewYears.Length;
                Array.Resize(ref NewYears, ArraySize + 1);

                NewYears[ArraySize] = TempYear;

            }
            return NewYears;
        }

        private Monthly_Observations[] getNextMonthlyObservationsArray(StreamReader input, Monthly_Observations[] NewMonths)
        {
            double MaxTemp, MinTemp, NoAirFrost, MilimetresRainfall, HoursSunshine;
            int MonthID, ArraySize;


            for (int i = 1; i < 13; i++)
            {
                MonthID = Convert.ToInt32(input.ReadLine());
                MaxTemp = Convert.ToDouble(input.ReadLine());
                MinTemp = Convert.ToDouble(input.ReadLine());
                NoAirFrost = Convert.ToDouble(input.ReadLine());
                MilimetresRainfall = Convert.ToDouble(input.ReadLine());
                HoursSunshine = Convert.ToDouble(input.ReadLine());

                if (i < 12)
                    input.ReadLine();

                Monthly_Observations TempMonth = new Monthly_Observations(MonthID, MaxTemp, MinTemp, NoAirFrost, MilimetresRainfall, HoursSunshine);

                if (NewMonths == null)
                    ArraySize = 0;
                else
                    ArraySize = NewMonths.Length;
                Array.Resize(ref NewMonths, ArraySize + 1);

                NewMonths[ArraySize] = TempMonth;
            }
            return NewMonths;
        }


    }
}
