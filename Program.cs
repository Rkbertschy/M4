using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace CapstoneProject
{

    //
    // Application:    Capstone Project Final
    // Writer:         Ryan Bertschy
    // Description:    An appilcation to estimate the cost for road construction
    // Date Edited:    4/18/2021
    //


    class Program
    {
        #region MAIN

        static void Main(string[] args)
        {
            bool validResponse;
            string userResponse;

            validResponse = false;

            do
            {
                DisplayScreenHeader("\t\tRoad Construction Calculator");

                Console.WriteLine();
                Console.WriteLine("\tThis Program is for calcualting the cost of excavating a basement. Do you wish to continue? (YES or NO)");
                userResponse = Console.ReadLine();

                if (userResponse == "yes")
                {
                    validResponse = true;

                }
                else if (userResponse == "no")
                {
                    validResponse = true;

                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("\tPlease enter Yes or No.");

                }
            } while (!validResponse);

            if (userResponse == "yes")
            {
                DisplaySetTheme();
                DisplayWelcomeScreen();
                DisplayMenuScreen();
                DisplayClosingScreen();

            }

        }

        #endregion

        #region Menu

        /// <summary>
        /// Home Screen  
        /// </summary>
        static void DisplayMenuScreen()
        {
            Console.CursorVisible = true;

            bool quitApplication = false;
            string menuChoice;


            do
            {
                DisplayScreenHeader("Main Menu");

                //
                // home screen menu
                //
                Console.WriteLine("\ta) New Road");
                Console.WriteLine("\tb) Existing Road");
                Console.WriteLine("\tq) Quit");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                //
                // Home Screen choice
                //
                switch (menuChoice)
                {
                    case "a":
                        DisplayNewRoad();
                        break;

                    case "b":
                        DisplayExistingRoad();
                        break;

                    case "q":

                        quitApplication = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!quitApplication);

        }

        #endregion  

        #region Existing Road

        /// <summary>
        /// existing Road
        /// </summary>
        static void DisplayExistingRoad()
        {

            #region Variables

            string jobDetails;
            string userResponse;

            bool validResponse;

            #endregion



            DisplayScreenHeader("\t\tNew Road");

            Console.WriteLine();
            Console.WriteLine("\tPlease enter the Job Name and date");
            jobDetails = Console.ReadLine();
            Console.WriteLine();

            validResponse = false;
            do
            {
                Console.WriteLine();
                Console.WriteLine("\tWhat type of road is this?");
                userResponse = Console.ReadLine().ToLower();

                if (userResponse == "highway")
                {
                    validResponse = true;
                }
                else if (userResponse == "residentail")
                {
                    validResponse = true;
                }
                else if (userResponse == "commercial")
                {
                    validResponse = true;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("\t\tPlease enter a road type [Highway, Residentail, or Commercial]");
                }


            } while (!validResponse);

            #region Highway
            if (userResponse == "highway")
            {
                DisplayScreenHeader("\t\tHighway");

                validResponse = false;
                do
                {

                    Console.WriteLine();
                    Console.WriteLine("\t\t What Material will be used?");
                    userResponse = Console.ReadLine().ToLower();

                    if (userResponse == "ashpalt")
                    {
                        validResponse = true;
                    }
                    else if (userResponse == "concrete")
                    {
                        validResponse = true;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("\t\tPlease enter a road material [Ashpalt or Concrete]");

                    }


                } while (!validResponse);


                if (userResponse == "ashpalt")
                {
                    DisplayAshpaltHighwayCalculation();
                }
                else if (userResponse == "concrete")
                {
                    DisplayConcreteHighwayCalculation();
                }


                if (userResponse == "highway")
                {
                    DisplayScreenHeader("\t\tHighway");

                    validResponse = false;
                    do
                    {

                        Console.WriteLine();
                        Console.WriteLine("\t\t What Material will be used?");
                        userResponse = Console.ReadLine().ToLower();

                        if (userResponse == "ashpalt")
                        {
                            validResponse = true;
                        }
                        else if (userResponse == "concrete")
                        {
                            validResponse = true;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("\t\tPlease enter a road material [Ashpalt or Concrete]");

                        }


                    } while (!validResponse);


                    if (userResponse == "ashpalt")
                    {
                        DisplayAshpaltHighwayCalculation();
                    }
                    else if (userResponse == "concrete")
                    {
                        DisplayConcreteHighwayCalculation();
                    }



                }

            }
            #endregion

            #region Residentail

            if (userResponse == "residential")
            {
                DisplayScreenHeader("\t\tResidential");

                validResponse = false;
                do
                {

                    Console.WriteLine();
                    Console.WriteLine("\t\t What Material will be used?");
                    userResponse = Console.ReadLine().ToLower();

                    if (userResponse == "ashpalt")
                    {
                        validResponse = true;
                    }
                    else if (userResponse == "Chip Seal")
                    {
                        validResponse = true;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("\t\tPlease enter a road material [Ashpalt or Chip Seal]");

                    }


                } while (!validResponse);


                if (userResponse == "ashpalt")
                {
                    DisplayAshpaltResidentialCalculation();
                }
                else if (userResponse == "chip seal")
                {
                    DisplayChipSealResidentialCalculation();
                }


                if (userResponse == "residential")
                {
                    DisplayScreenHeader("\t\tResidential");

                    validResponse = false;
                    do
                    {

                        Console.WriteLine();
                        Console.WriteLine("\t\t What Material will be used?");
                        userResponse = Console.ReadLine().ToLower();

                        if (userResponse == "ashpalt")
                        {
                            validResponse = true;
                        }
                        else if (userResponse == "chip seal")
                        {
                            validResponse = true;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("\t\tPlease enter a road material [Ashpalt or Chip Seal]");

                        }


                    } while (!validResponse);


                    if (userResponse == "ashpalt")
                    {
                        DisplayAshpaltResidentialCalculation();
                    }
                    else if (userResponse == "chip seal")
                    {
                        DisplayChipSealResidentialCalculation();
                    }

                }

            }

            #endregion

            #region Commercial

            if (userResponse == "commercial")
            {
                DisplayScreenHeader("\t\tCommercial");

                validResponse = false;
                do
                {

                    Console.WriteLine();
                    Console.WriteLine("\t\t What Material will be used?");
                    userResponse = Console.ReadLine().ToLower();

                    if (userResponse == "ashpalt")
                    {
                        validResponse = true;
                    }
                    else if (userResponse == "Chip Seal")
                    {
                        validResponse = true;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("\t\tPlease enter a road material [Ashpalt or Chip Seal]");

                    }


                } while (!validResponse);


                if (userResponse == "ashpalt")
                {
                    DisplayAshpaltResidentialCalculation();
                }
                else if (userResponse == "chip seal")
                {
                    DisplayChipSealResidentialCalculation();
                }


                if (userResponse == "residential")
                {
                    DisplayScreenHeader("\t\tResidential");

                    validResponse = false;
                    do
                    {

                        Console.WriteLine();
                        Console.WriteLine("\t\t What Material will be used?");
                        userResponse = Console.ReadLine().ToLower();

                        if (userResponse == "ashpalt")
                        {
                            validResponse = true;
                        }
                        else if (userResponse == "chip seal")
                        {
                            validResponse = true;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("\t\tPlease enter a road material [Ashpalt or Chip Seal]");

                        }


                    } while (!validResponse);


                    if (userResponse == "ashpalt")
                    {
                        DisplayAshpaltResidentialCalculation();
                    }
                    else if (userResponse == "chip seal")
                    {
                        DisplayChipSealResidentialCalculation();
                    }

                }

            }

            #endregion
        }

        #endregion

        #region New Road

        /// <summary>
        /// New Road
        /// </summary>
        static void DisplayNewRoad()
        {

            #region Variables

            string jobDetails;
            string userResponse;

            bool validResponse;

            #endregion



            DisplayScreenHeader("\t\tNew Road");

            Console.WriteLine();
            Console.WriteLine("\tPlease enter the Job Name and date");
            jobDetails = Console.ReadLine();
            Console.WriteLine();

            validResponse = false;
            do
            {
                Console.WriteLine();
                Console.WriteLine("\tWhat type of road is this?");
                userResponse = Console.ReadLine().ToLower();

                if (userResponse == "highway")
                {
                    validResponse = true;
                }
                else if (userResponse == "residentail")
                {
                    validResponse = true;
                }
                else if (userResponse == "commercial")
                {
                    validResponse = true;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("\t\tPlease enter a road type [Highway, Residentail, or Commercial]");
                }


            } while (!validResponse);

            #region Highway
            if (userResponse == "highway")
            {
                DisplayScreenHeader("\t\tHighway");

                validResponse = false;
                do
                {

                    Console.WriteLine();
                    Console.WriteLine("\t\t What Material will be used?");
                    userResponse = Console.ReadLine().ToLower();

                    if (userResponse == "ashpalt")
                    {
                        validResponse = true;
                    }
                    else if (userResponse == "concrete")
                    {
                        validResponse = true;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("\t\tPlease enter a road material [Ashpalt or Concrete]");

                    }


                } while (!validResponse);


                if (userResponse == "ashpalt")
                {
                    DisplayAshpaltHighwayCalculation();
                }
                else if (userResponse == "concrete")
                {
                    DisplayConcreteHighwayCalculation();
                }


                if (userResponse == "highway")
                {
                    DisplayScreenHeader("\t\tHighway");

                    validResponse = false;
                    do
                    {

                        Console.WriteLine();
                        Console.WriteLine("\t\t What Material will be used?");
                        userResponse = Console.ReadLine().ToLower();

                        if (userResponse == "ashpalt")
                        {
                            validResponse = true;
                        }
                        else if (userResponse == "concrete")
                        {
                            validResponse = true;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("\t\tPlease enter a road material [Ashpalt or Concrete]");

                        }


                    } while (!validResponse);


                    if (userResponse == "ashpalt")
                    {
                        DisplayAshpaltHighwayCalculation();
                    }
                    else if (userResponse == "concrete")
                    {
                        DisplayConcreteHighwayCalculation();
                    }



                }

            }
            #endregion

            #region Residentail

            if (userResponse == "residential")
            {
                DisplayScreenHeader("\t\tResidential");

                validResponse = false;
                do
                {

                    Console.WriteLine();
                    Console.WriteLine("\t\t What Material will be used?");
                    userResponse = Console.ReadLine().ToLower();

                    if (userResponse == "ashpalt")
                    {
                        validResponse = true;
                    }
                    else if (userResponse == "Chip Seal")
                    {
                        validResponse = true;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("\t\tPlease enter a road material [Ashpalt or Chip Seal]");

                    }


                } while (!validResponse);


                if (userResponse == "ashpalt")
                {
                    DisplayAshpaltResidentialCalculation();
                }
                else if (userResponse == "chip seal")
                {
                    DisplayChipSealResidentialCalculation();
                }


                if (userResponse == "residential")
                {
                    DisplayScreenHeader("\t\tResidential");

                    validResponse = false;
                    do
                    {

                        Console.WriteLine();
                        Console.WriteLine("\t\t What Material will be used?");
                        userResponse = Console.ReadLine().ToLower();

                        if (userResponse == "ashpalt")
                        {
                            validResponse = true;
                        }
                        else if (userResponse == "chip seal")
                        {
                            validResponse = true;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("\t\tPlease enter a road material [Ashpalt or Chip Seal]");

                        }


                    } while (!validResponse);


                    if (userResponse == "ashpalt")
                    {
                        DisplayAshpaltResidentialCalculation();
                    }
                    else if (userResponse == "chip seal")
                    {
                        DisplayChipSealResidentialCalculation();
                    }

                }

            }

            #endregion

            #region Commercial

            if (userResponse == "commercial")
            {
                DisplayScreenHeader("\t\tCommercial");

                validResponse = false;
                do
                {

                    Console.WriteLine();
                    Console.WriteLine("\t\t What Material will be used?");
                    userResponse = Console.ReadLine().ToLower();

                    if (userResponse == "ashpalt")
                    {
                        validResponse = true;
                    }
                    else if (userResponse == "Chip Seal")
                    {
                        validResponse = true;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("\t\tPlease enter a road material [Ashpalt or Chip Seal]");

                    }


                } while (!validResponse);


                if (userResponse == "ashpalt")
                {
                    DisplayAshpaltResidentialCalculation();
                }
                else if (userResponse == "chip seal")
                {
                    DisplayChipSealResidentialCalculation();
                }


                if (userResponse == "residential")
                {
                    DisplayScreenHeader("\t\tResidential");

                    validResponse = false;
                    do
                    {

                        Console.WriteLine();
                        Console.WriteLine("\t\t What Material will be used?");
                        userResponse = Console.ReadLine().ToLower();

                        if (userResponse == "ashpalt")
                        {
                            validResponse = true;
                        }
                        else if (userResponse == "chip seal")
                        {
                            validResponse = true;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("\t\tPlease enter a road material [Ashpalt or Chip Seal]");

                        }


                    } while (!validResponse);


                    if (userResponse == "ashpalt")
                    {
                        DisplayAshpaltResidentialCalculation();
                    }
                    else if (userResponse == "chip seal")
                    {
                        DisplayChipSealResidentialCalculation();
                    }

                }

            }

            #endregion


        }
        #endregion

        /// <summary>
        /// Ashpalt Commercial Calculation
        /// </summary>
        static void DisplayAshpaltCommercialCalculation()
        {
            string userResponse;

            int numberOfLanes;
            int lengthOfRoad;
            int numberOfCorners;
            int ashpaltVolume;
            int roadWidth;
            int cornerArea = 0;
            int yrdsOfAshpalt;
            int roadVolume;
            int cornerVolume = 0;
            int roadVolumeFt;
            int cornerVolumeFt = 0;
            int cornerTotal;
            int roadTotal;

            double roadCost;
            double inch;


            bool validResponse;

            validResponse = false;
            do
            {
                DisplayScreenHeader("\t\tAshpalt Information");

                Console.WriteLine();
                Console.WriteLine("\t\tHow many lanes will there be?");
                userResponse = Console.ReadLine();
                int.TryParse(userResponse, out numberOfLanes);
                Console.WriteLine("\t\tWhat is the length of the road (ft). " +
                    "(REMINDER! only give the distance along straight aways " +
                    "(any bend less then 130 Degrees) will be counted as a corner)");
                userResponse = Console.ReadLine();
                int.TryParse(userResponse, out lengthOfRoad);
                double feet = Convert.ToDouble(userResponse);
                inch = feet * 12;
                Console.WriteLine("\t\tHow many corners?");
                userResponse = Console.ReadLine();
                int.TryParse(userResponse, out numberOfCorners);
                if (numberOfLanes <= 0)
                {
                    Console.WriteLine("\t\tPlease enter a positive number [1, 2, 3,...]");
                }
                else if (lengthOfRoad <= 0)
                {
                    Console.WriteLine("\t\tPlease enter a positive number [1, 2, 3,...]");
                }
                else if (numberOfCorners < 0)
                {
                    Console.WriteLine("\t\tPlease enter a positive number [0, 1, 2, 3,...]");
                }
                else
                {
                    validResponse = true;
                }


            } while (!validResponse);



            #region Calculations

            roadWidth = 144 * numberOfLanes + 144;
            roadVolume = roadWidth * 8;
            cornerArea = numberOfLanes * 144 - 250;
            cornerVolume = cornerArea * 8;

            roadVolumeFt = roadVolume / 1728;
            roadTotal = roadVolumeFt * lengthOfRoad;
            cornerVolumeFt = cornerVolume / 1728;
            cornerTotal = cornerVolumeFt * numberOfCorners;


            ashpaltVolume = cornerTotal + roadTotal;
            yrdsOfAshpalt = ashpaltVolume / 27;

            roadCost = yrdsOfAshpalt * 90;



            #endregion


            #region ECO

            DisplayScreenHeader("\t\tData");

            Console.Clear();
            Console.CursorVisible = false;
            Console.WriteLine();
            Console.WriteLine($"\tLength of Road:       {lengthOfRoad}");
            Console.WriteLine($"\tNumber of lanes:      {numberOfLanes}");
            Console.WriteLine($"\tNumber of Corners:    {numberOfCorners}");

            Console.WriteLine($"\tVolume of New Road:   {ashpaltVolume}");
            Console.WriteLine($"\tYards of Ashpalt:     {yrdsOfAshpalt}");

            Console.WriteLine($"\tEstimated Coast:      {roadCost:C}");

            DisplayContinuePrompt();



            #endregion
        }


        /// <summary>
        /// Chip Seal residential Calculation
        /// </summary>
        static void DisplayChipSealResidentialCalculation()
        {
            string userResponse;

            int numberOfLanes;
            int lengthOfRoad;
            int numberOfCorners;
            int chipSealVolume;
            int roadWidth;
            int cornerArea = 0;
            int yrdsOfChipSeal;
            int roadVolume;
            int cornerVolume = 0;
            int roadVolumeFt;
            int cornerVolumeFt = 0;
            int cornerTotal;
            int roadTotal;

            double roadCost;
            double inch;


            bool validResponse;

            validResponse = false;
            do
            {
                DisplayScreenHeader("\t\tChip Seal Information");

                Console.WriteLine();
                Console.WriteLine("\t\tHow many lanes will there be?");
                userResponse = Console.ReadLine();
                int.TryParse(userResponse, out numberOfLanes);
                Console.WriteLine("\t\tWhat is the length of the road (ft). " +
                    "(REMINDER! only give the distance along straight aways " +
                    "(any bend less then 130 Degrees) will be counted as a corner)");
                userResponse = Console.ReadLine();
                int.TryParse(userResponse, out lengthOfRoad);
                double feet = Convert.ToDouble(userResponse);
                inch = feet * 12;
                Console.WriteLine("\t\tHow many corners?");
                userResponse = Console.ReadLine();
                int.TryParse(userResponse, out numberOfCorners);
                if (numberOfLanes <= 0)
                {
                    Console.WriteLine("\t\tPlease enter a positive number [1, 2, 3,...]");
                }
                else if (lengthOfRoad <= 0)
                {
                    Console.WriteLine("\t\tPlease enter a positive number [1, 2, 3,...]");
                }
                else if (numberOfCorners < 0)
                {
                    Console.WriteLine("\t\tPlease enter a positive number [0, 1, 2, 3,...]");
                }
                else
                {
                    validResponse = true;
                }


            } while (!validResponse);



            #region Calculations

            roadWidth = 144 * numberOfLanes + 144;
            roadVolume = roadWidth * 2;
            cornerArea = numberOfLanes * 144 - 250;
            cornerVolume = cornerArea * 2;

            roadVolumeFt = roadVolume / 1728;
            roadTotal = roadVolumeFt * lengthOfRoad;
            cornerVolumeFt = cornerVolume / 1728;
            cornerTotal = cornerVolumeFt * numberOfCorners;


            chipSealVolume = cornerTotal + roadTotal;
            yrdsOfChipSeal = chipSealVolume / 27;

            roadCost = yrdsOfChipSeal * 5;



            #endregion


            #region ECO

            DisplayScreenHeader("\t\tData");

            Console.Clear();
            Console.CursorVisible = false;
            Console.WriteLine();
            Console.WriteLine($"\tLength of Road:       {lengthOfRoad}");
            Console.WriteLine($"\tNumber of lanes:      {numberOfLanes}");
            Console.WriteLine($"\tNumber of Corners:    {numberOfCorners}");

            Console.WriteLine($"\tVolume of New Road:   {chipSealVolume}");
            Console.WriteLine($"\tYards of Ashpalt:     {yrdsOfChipSeal}");

            Console.WriteLine($"\tEstimated Coast:      {roadCost:C}");

            DisplayContinuePrompt();



            #endregion
        }

        /// <summary>
        /// Ashpalt Residential Calculation
        /// </summary>
        static void DisplayAshpaltResidentialCalculation()
        {
            string userResponse;

            int numberOfLanes;
            int lengthOfRoad;
            int numberOfCorners;
            int ashpaltVolume;
            int roadWidth;
            int cornerArea = 0;
            int yrdsOfAshpalt;
            int roadVolume;
            int cornerVolume = 0;
            int roadVolumeFt;
            int cornerVolumeFt = 0;
            int cornerTotal;
            int roadTotal;

            double roadCost;
            double inch;


            bool validResponse;

            validResponse = false;
            do
            {
                DisplayScreenHeader("\t\tAshpalt Information");

                Console.WriteLine();
                Console.WriteLine("\t\tHow many lanes will there be?");
                userResponse = Console.ReadLine();
                int.TryParse(userResponse, out numberOfLanes);
                Console.WriteLine("\t\tWhat is the length of the road (ft). " +
                    "(REMINDER! only give the distance along straight aways " +
                    "(any bend less then 130 Degrees) will be counted as a corner)");
                userResponse = Console.ReadLine();
                int.TryParse(userResponse, out lengthOfRoad);
                double feet = Convert.ToDouble(userResponse);
                inch = feet * 12;
                Console.WriteLine("\t\tHow many corners?");
                userResponse = Console.ReadLine();
                int.TryParse(userResponse, out numberOfCorners);
                if (numberOfLanes <= 0)
                {
                    Console.WriteLine("\t\tPlease enter a positive number [1, 2, 3,...]");
                }
                else if (lengthOfRoad <= 0)
                {
                    Console.WriteLine("\t\tPlease enter a positive number [1, 2, 3,...]");
                }
                else if (numberOfCorners < 0)
                {
                    Console.WriteLine("\t\tPlease enter a positive number [0, 1, 2, 3,...]");
                }
                else
                {
                    validResponse = true;
                }


            } while (!validResponse);



            #region Calculations

            roadWidth = 144 * numberOfLanes + 144;
            roadVolume = roadWidth * 4;
            cornerArea = numberOfLanes * 144 - 250;
            cornerVolume = cornerArea * 4;

            roadVolumeFt = roadVolume / 1728;
            roadTotal = roadVolumeFt * lengthOfRoad;
            cornerVolumeFt = cornerVolume / 1728;
            cornerTotal = cornerVolumeFt * numberOfCorners;


            ashpaltVolume = cornerTotal + roadTotal;
            yrdsOfAshpalt = ashpaltVolume / 27;

            roadCost = yrdsOfAshpalt * 90;



            #endregion


            #region ECO

            DisplayScreenHeader("\t\tData");

            Console.Clear();
            Console.CursorVisible = false;
            Console.WriteLine();
            Console.WriteLine($"\tLength of Road:       {lengthOfRoad}");
            Console.WriteLine($"\tNumber of lanes:      {numberOfLanes}");
            Console.WriteLine($"\tNumber of Corners:    {numberOfCorners}");

            Console.WriteLine($"\tVolume of New Road:   {ashpaltVolume}");
            Console.WriteLine($"\tYards of Ashpalt:     {yrdsOfAshpalt}");

            Console.WriteLine($"\tEstimated Coast:      {roadCost:C}");

            DisplayContinuePrompt();



            #endregion
        }


        /// <summary>
        /// Concrete Highway Calculation
        /// </summary>
        static void DisplayConcreteHighwayCalculation()
        {
            string userResponse;

            int numberOfLanes;
            int lengthOfRoad;
            int numberOfCorners;
            int ConcretetVolume;
            int roadWidth;
            int cornerArea = 0;
            int yrdsOfConcrete;
            int roadVolume;
            int cornerVolume = 0;
            int roadVolumeFt;
            int cornerVolumeFt = 0;
            int cornerTotal;
            int roadTotal;

            double roadCost;
            double inch;


            bool validResponse;

            validResponse = false;
            do
            {
                DisplayScreenHeader("\t\tConcrete Information");

                Console.WriteLine();
                Console.WriteLine("\t\tHow many lanes will there be?");
                userResponse = Console.ReadLine();
                int.TryParse(userResponse, out numberOfLanes);
                Console.WriteLine("\t\tWhat is the length of the road (ft). " +
                    "(REMINDER! only give the distance along straight aways " +
                    "(any bend less then 130 Degrees) will be counted as a corner)");
                userResponse = Console.ReadLine();
                int.TryParse(userResponse, out lengthOfRoad);
                double feet = Convert.ToDouble(userResponse);
                inch = feet * 12;
                Console.WriteLine("\t\tHow many corners?");
                userResponse = Console.ReadLine();
                int.TryParse(userResponse, out numberOfCorners);
                if (numberOfLanes <= 0)
                {
                    Console.WriteLine("\t\tPlease enter a positive number [1, 2, 3,...]");
                }
                else if (lengthOfRoad <= 0)
                {
                    Console.WriteLine("\t\tPlease enter a positive number [1, 2, 3,...]");
                }
                else if (numberOfCorners < 0)
                {
                    Console.WriteLine("\t\tPlease enter a positive number [0, 1, 2, 3,...]");
                }
                else
                {
                    validResponse = true;
                }


            } while (!validResponse);



            #region Calculations

            roadWidth = 144 * numberOfLanes + 144;
            roadVolume = roadWidth * 12;
            cornerArea = numberOfLanes * 144 - 250;
            cornerVolume = cornerArea * 12;

            roadVolumeFt = roadVolume / 1728;
            roadTotal = roadVolumeFt * lengthOfRoad;
            cornerVolumeFt = cornerVolume / 1728;
            cornerTotal = cornerVolumeFt * numberOfCorners;


            ConcretetVolume = cornerTotal + roadTotal;
            yrdsOfConcrete = ConcretetVolume / 27;

            roadCost = yrdsOfConcrete * 125;



            #endregion


            #region ECO

            DisplayScreenHeader("\t\tData");

            Console.Clear();
            Console.CursorVisible = false;
            Console.WriteLine();
            Console.WriteLine($"\tLength of Road:       {lengthOfRoad}");
            Console.WriteLine($"\tNumber of lanes:      {numberOfLanes}");
            Console.WriteLine($"\tNumber of Corners:    {numberOfCorners}");

            Console.WriteLine($"\tVolume of New Road:   {ConcretetVolume}");
            Console.WriteLine($"\tYards of Concrete:     {yrdsOfConcrete}");

            Console.WriteLine($"\tEstimated Coast:      {roadCost:C}");

            DisplayContinuePrompt();


        }


        /// <summary>
        /// Ashpalt Highway Calculation
        /// </summary>
        static void DisplayAshpaltHighwayCalculation()
        {
            string userResponse;

            int numberOfLanes;
            int lengthOfRoad;
            int numberOfCorners;
            int ashpaltVolume;
            int roadWidth;
            int cornerArea = 0;
            int yrdsOfAshpalt;
            int roadVolume;
            int cornerVolume = 0;
            int roadVolumeFt;
            int cornerVolumeFt = 0;
            int cornerTotal;
            int roadTotal;

            double roadCost;
            double inch;


            bool validResponse;

            validResponse = false;
            do
            {
                DisplayScreenHeader("\t\tAshpalt Information");

                Console.WriteLine();
                Console.WriteLine("\t\tHow many lanes will there be?");
                userResponse = Console.ReadLine();
                int.TryParse(userResponse, out numberOfLanes);
                Console.WriteLine("\t\tWhat is the length of the road (ft). " +
                    "(REMINDER! only give the distance along straight aways " +
                    "(any bend less then 130 Degrees) will be counted as a corner)");
                userResponse = Console.ReadLine();
                int.TryParse(userResponse, out lengthOfRoad);
                double feet = Convert.ToDouble(userResponse);
                inch = feet * 12;
                Console.WriteLine("\t\tHow many corners?");
                userResponse = Console.ReadLine();
                int.TryParse(userResponse, out numberOfCorners);
                if (numberOfLanes <= 0)
                {
                    Console.WriteLine("\t\tPlease enter a positive number [1, 2, 3,...]");
                }
                else if (lengthOfRoad <= 0)
                {
                    Console.WriteLine("\t\tPlease enter a positive number [1, 2, 3,...]");
                }
                else if (numberOfCorners < 0)
                {
                    Console.WriteLine("\t\tPlease enter a positive number [0, 1, 2, 3,...]");
                }
                else
                {
                    validResponse = true;
                }


            } while (!validResponse);



            #region Calculations

            roadWidth = 144 * numberOfLanes + 144;
            roadVolume = roadWidth * 11;
            cornerArea = numberOfLanes * 144 - 250;
            cornerVolume = cornerArea * 11;

            roadVolumeFt = roadVolume / 1728;
            roadTotal = roadVolumeFt * lengthOfRoad;
            cornerVolumeFt = cornerVolume / 1728;
            cornerTotal = cornerVolumeFt * numberOfCorners;


            ashpaltVolume = cornerTotal + roadTotal;
            yrdsOfAshpalt = ashpaltVolume / 27;

            roadCost = yrdsOfAshpalt * 90;



            #endregion


            #region ECO

            DisplayScreenHeader("\t\tData");

            Console.Clear();
            Console.CursorVisible = false;
            Console.WriteLine();
            Console.WriteLine($"\tLength of Road:       {lengthOfRoad}");
            Console.WriteLine($"\tNumber of lanes:      {numberOfLanes}");
            Console.WriteLine($"\tNumber of Corners:    {numberOfCorners}");

            Console.WriteLine($"\tVolume of New Road:   {ashpaltVolume}");
            Console.WriteLine($"\tYards of Ashpalt:     {yrdsOfAshpalt}");

            Console.WriteLine($"\tEstimated Coast:      {roadCost:C}");

            DisplayContinuePrompt();



            #endregion


        }

        #endregion

        #region basics

        #region Theme



        /// <summary>
        /// Display Theme 
        /// </summary>
        static void DisplaySetTheme()
        {
            (ConsoleColor forgroundColor, ConsoleColor backgroundColor) themeColors;
            bool themeChosen = false;


            //Set Theme

            themeColors = ReadThemeData();
            Console.ForegroundColor = themeColors.forgroundColor;
            Console.BackgroundColor = themeColors.backgroundColor;
            Console.Clear();
            DisplayScreenHeader("\tSet App Theme");

            Console.WriteLine($"\t\tCurrent text color: {Console.ForegroundColor}");
            Console.WriteLine($"\t\tCurrent background color: {Console.BackgroundColor}");
            Console.WriteLine();

            Console.WriteLine("\t\tWould you like to change the theme colors? [Yes or No]");
            if (Console.ReadLine().ToLower() == "yes")
            {
                do
                {
                    themeColors.forgroundColor = GetColorFromUser("text");
                    themeColors.backgroundColor = GetColorFromUser("background");

                    //Set New Theme
                    Console.ForegroundColor = themeColors.forgroundColor;
                    Console.BackgroundColor = themeColors.backgroundColor;
                    Console.Clear();
                    DisplayScreenHeader("Set New Theme for App");
                    Console.WriteLine($"\t\tNew Text Color: {Console.ForegroundColor}");
                    Console.WriteLine($"\t\tNew Background Color: {Console.BackgroundColor}");

                    Console.WriteLine();
                    Console.Write("\t\tDo you wish to change the theme again?");
                    if (Console.ReadLine().ToLower() == "no")
                    {
                        themeChosen = true;
                        WriteThemeData(themeColors.forgroundColor, themeColors.backgroundColor);
                    }

                } while (!themeChosen);

            }
            DisplayContinuePrompt();

        }



        /// <summary>
        /// Write Theme Colors
        /// </summary>
        /// <param name="forground"></param>
        /// <param name="background"></param>
        static void WriteThemeData(ConsoleColor forground, ConsoleColor background)
        {
            string dataPath = @"Data/Theme.txt";

            File.WriteAllText(dataPath, forground.ToString() + "\n");
            File.AppendAllText(dataPath, background.ToString());
        }



        /// <summary>
        /// Read Theme Color
        /// </summary>
        /// <returns></returns>
        static (ConsoleColor forgroundColor, ConsoleColor backgroundColor) ReadThemeData()
        {
            string dataPath = @"Data/Theme.txt";
            string[] themeColors;

            ConsoleColor forgroundColor;
            ConsoleColor backgroundColor;

            themeColors = File.ReadAllLines(dataPath);

            Enum.TryParse(themeColors[0], true, out forgroundColor);
            Enum.TryParse(themeColors[1], true, out backgroundColor);

            return (forgroundColor, backgroundColor);

        }


        /// <summary>
        /// Get Color From User
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        static ConsoleColor GetColorFromUser(string property)
        {
            ConsoleColor consoleColor;
            bool validConsoleColor;


            Console.Clear();
            DisplayScreenHeader("\tChoose New Theme Colors");


            do
            {
                Console.WriteLine($"\t\tEnter a Color for the {property}:");
                Console.WriteLine("\tCOLOR LIST [Black, DarkBlue, DarkGreen, " +
                        "DarkRed, DarkMagenta, DarkYellow, Gray, DarkGray, Blue, Green, Cyan, Red, Magenta, Yellow, and White]");
                validConsoleColor = Enum.TryParse<ConsoleColor>(Console.ReadLine(), true, out consoleColor);



                if (!validConsoleColor)
                {
                    Console.WriteLine("\n\t***** Please enter a valid console color, [ Black, DarkBlue, DarkGreen, " +
                        "DarkRed, DarkMagenta, DarkYellow, Gray, DarkGray, Blue, Green, Cyan, Red, Magenta, Yellow, and White] ******\n");

                }
                else
                {
                    validConsoleColor = true;
                }



            } while (!validConsoleColor);

            return consoleColor;

        }



        #endregion

        #region UI             


        /// <summary>
        /// welcome screen
        /// </summary>
        static void DisplayWelcomeScreen()
        {
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t\t Welcome to Road Construction Estimator");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        /// <summary>
        /// closing screen
        /// </summary>
        static void DisplayClosingScreen()
        {
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t\t The app is now closing. Thank you");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        /// <summary>
        /// display continue prompt
        /// </summary>
        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("\t\tPress any key to continue.");
            Console.ReadKey();
        }

        /// <summary>
        /// display menu prompt
        /// </summary>
        static void DisplayMenuPrompt(string menuName)
        {
            Console.WriteLine();
            Console.WriteLine($"\tPress any key to return to the {menuName} Menu.");
            Console.ReadKey();
        }

        /// <summary>
        /// display screen header
        /// </summary>
        static void DisplayScreenHeader(string headerText)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t\t" + headerText);
            Console.WriteLine();
        }

        #endregion

        #endregion
    }
    
} 