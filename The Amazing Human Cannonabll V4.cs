//ProjectV4(b)

using System;

namespace ENGR115_AugTerm_ProjectV4b
{
    class Program
    {
        static void Welcome() //This method contains the welcome messege for the program. 
        {
            string inputString;

            string startMessege = "So, as I was saying to the guy 'You know why they calls me Sl...' " +
                "\nOh, uh... \nHey, Kid, you can't be in here right now, the show don't start for " +
                "another few hours. Go enjoy the games and rides, why don't ya.\nActually, uh, Kid, " +
                "you looks like a smart egg, you mind helping me set up for our main act" +
                " The 'Mazing Human Cannonball? \n'y' for yes, 'n' for no";

            string responseYes = "Hey, hey, hey, Kid, that's fantastic! Yous studied physics before, " +
                "right? Ahh, don't worry about it, we've got a lil' simuation here that will tell us " +
                "what we're working with.";

            string responseNo = "No? \nNo. \nAhh, don't worry 'bout it, Kid, as I said earlier, go enjoy" +
                " the rides and what not.";

            string responseUnknown = "Kid, you not from 'round here, are you? I can't understand what " +
                "you're saying, go ahead and, uh, enjoy the rides.";

            string continueMessege = "\nPress Enter Key to continue.";

            bool programWelcome = false;

            while (programWelcome == false)
            {
                Console.WriteLine(startMessege);
                inputString = Console.ReadLine();

                if (inputString == "y" || inputString == "Y") //User 'says' yes, program begins
                {
                    Console.WriteLine(responseYes);
                    Console.WriteLine(continueMessege);
                    Console.ReadLine();
                    programWelcome = true;
                }
                else if (inputString == "n" || inputString == "N") //User 'says' no, program ends
                {
                    Console.WriteLine(responseNo);
                    Console.WriteLine(continueMessege);
                    Console.ReadLine();
                    System.Environment.Exit(1);
                }
                else //User 'says' something unintelligible, program ends
                {
                    Console.WriteLine(responseUnknown);
                    Console.WriteLine(continueMessege);
                    Console.ReadLine();
                    System.Environment.Exit(1);
                }
            }


        }
                
        static void Main(string[] args) //Method that contains main program
        {
            int numberOfSystems, ringDiameter = 20, tentHeight = 25;

            float initialVelocity = 0.0f, launchAngle = 0.0f;

            string inputString;

            string systemsDecide = "Hey, before we start, the program's asking for how many systems" +
                " you wanna try out. A system is an individual set up.\nSo, whaddya say, Kid, " +
                "how many times you want this thing to go 'round the block?\n\nSystems must be in whole numbers.";

            string systemsDecideConfirmation = "\n{0}? \nOkay, {0}, let me dial that in.";

            string systemsNumber = "Alright, Kid, let's get started with system number {0}.";

            string enterVelocity = "Alright, Kid, I'm gonna need you to tell me what the exit " +
                "velocity should be.\nAlso, remember, this will be a number, in m/s. So, no " +
                "funny business.";

            string velocityConfirmation = "Alright, per your request, let me just put {0} m/s " +
                "into out lil' simuation here.";

            string wrongAnswerVelocity = "\nThe system wont accept that, Kid. I did tell you no funny " +
                "business, right?";

            string enterDegree = "Alright, now give me the angle of the cannon, Kid. This will " +
                "be in degrees, so no radians here, feels more natural that way.";

            string degreeConfirmation = "Okay, let me run {0} degrees.";

            string wrongAnswerDegree = "\nSame thing applies, Kid, 'member when I said no " +
                "funny business?";

            string calculations = "Alright, Kid, the programs doin' it's little calculations and " +
                "will tell you if attempt {0} passed or failed.";

            string passMessege = "\nGood job, Kid.";

            string failMessege = "\nNo shot, Kid, this system won't end well.";

            string columnHeading = "Velocity(m/s)   Angle(deg)   Distance(m)   Height(m)   Pass/Fail";

            string anotherGo = "Would you like to give the program 'nother go, Kid? You seem " +
                    "to be enjoying this. \n'y' for yes 'n' for no.";

            string clearOut = "Alright, let me just clear all this out, and we can begin anew.";

            string finalNo = "Alright, thanks for helping, Kid. Go have some fun and get some " +
                "cotton candy, tell 'em Slick sent ya'.";

            string finalUnknown = "Uh, that's kinda 'sus', so I'll take that as a no, Kid. " +
                "But, good work here, go enjoy the rides, and thanks for helping Ol Slick.";

            string continueMessege = "\nPress Enter Key to continue.";

            bool userInputLoop = false, inputVelocity = false, inputDegree = false, passFail = false;

            Welcome(); // Call on Welcome method

            do
            {
                Console.Clear();

                Console.WriteLine(systemsDecide); //Display messege asking User to decide how many attempts they wish to run.
                inputString = Console.ReadLine();
                numberOfSystems = int.Parse(inputString);
                Console.WriteLine(systemsDecideConfirmation, inputString);
                Console.WriteLine(continueMessege);
                Console.ReadLine();

                //These are the float arrays that store raw User input and processed data

                float[] userVelocity = new float[numberOfSystems];
                float[] userDegree = new float[numberOfSystems];
                float[] userDistance = new float[numberOfSystems];
                float[] userAngle = new float[numberOfSystems];
                float[] userHeight = new float[numberOfSystems];

                string[] userPassFail = new string[numberOfSystems]; //This string array stores the "Pass" and "Fail" identifiers for each iteration. (PS Thank you!)

                for (int x = 0; x < numberOfSystems; x++) //Main for-loop for the program
                {
                    Console.WriteLine(systemsNumber, x + 1); //Messege reminding User what system (iteration) they are on
                    Console.WriteLine(continueMessege);
                    inputString = Console.ReadLine();

                    do //Loop getting velocity input from User
                    {
                        Console.WriteLine(enterVelocity);
                        inputString = Console.ReadLine();

                        if (Single.TryParse(inputString, out userVelocity[x])) //User inputs correct format, storing value (in userVelocity array) and ending loop
                        {
                            inputVelocity = false;
                            initialVelocity = float.Parse(inputString);
                            Console.WriteLine(velocityConfirmation, initialVelocity);
                            Console.WriteLine(continueMessege);
                            Console.ReadLine();
                        }
                        else //User is asked to try again, restarting loop.
                        {
                            inputVelocity = true;
                            Console.WriteLine(wrongAnswerVelocity);
                            Console.WriteLine(continueMessege);
                            Console.ReadLine();
                        }
                    } while (inputVelocity);

                    do //Loop getting degree input from User
                    {
                        Console.WriteLine(enterDegree);
                        inputString = Console.ReadLine();

                        if (Single.TryParse(inputString, out userDegree[x])) //User inputs correct format, storing value (in userDegree array) and ending loop
                        {
                            inputDegree = false;
                            launchAngle = float.Parse(inputString);
                            Console.WriteLine(degreeConfirmation, launchAngle);
                            Console.WriteLine(continueMessege);
                            Console.ReadLine();
                        }
                        else //User is asked to try again, restarting loop.
                        {
                            inputDegree = true;
                            Console.WriteLine(wrongAnswerDegree);
                            Console.WriteLine(continueMessege);
                            Console.ReadLine();
                        }
                    } while (inputDegree);

                    float gravity = 9.8f;

                    //Calculations are done and stored in the appropriate array

                    userAngle[x] = (userDegree[x] * MathF.PI / 180);
                    userHeight[x] = MathF.Pow(userVelocity[x] * MathF.Sin(userAngle[x]), 2) / (2 * gravity);
                    userDistance[x] = MathF.Pow(userVelocity[x], 2) * MathF.Sin(2 * userAngle[x]) / gravity;

                    Console.WriteLine(calculations, x + 1);
                    Console.WriteLine(continueMessege);

                    //These statements decides if the User input has passed or failed

                    if (tentHeight >= userHeight[x] && ringDiameter >= userDistance[x])
                    {
                        userPassFail[x] = "PASS";
                        Console.WriteLine(passMessege);
                        //If the processed date meet the requirments, less than tent height AND less than ring diameter,
                        //this writes the PASS identifier to the array, it also includes a nice messege to display
                    }
                    else
                    {
                        userPassFail[x] = "FAIL";
                        Console.WriteLine(failMessege);
                        //In any other situation, this will write the FAIL identifier to the array, and display the appropriate messege
                    }

                    do //This loop holds the output table for the program (PS Thank you, again!)
                    {
                        Console.WriteLine(columnHeading);
                        
                        for (int y = 0; y <= x; y++)
                        {
                            Console.WriteLine("{0}              {1}           {2}     {3}    {4}", userVelocity[y], userDegree[y], userDistance[y], userHeight[y], userPassFail[y]);
                        }
                    } while (passFail);
                    
                    Console.ReadLine();
                    Console.WriteLine(continueMessege);
                }

                //This is the programs outtro
                
                userInputLoop = false;
                Console.WriteLine(anotherGo); //Ask User if they wish to go again.
                inputString = Console.ReadLine();

                if (inputString == "y" || inputString == "Y") //User 'says' yes, program restarts
                {
                    Console.WriteLine(clearOut);
                    Console.WriteLine(continueMessege);
                    Console.ReadLine();
                    userInputLoop = true;
                }
                else if (inputString == "n" || inputString == "N") //User 'says' no, program ends
                {
                    Console.WriteLine(finalNo);
                    Console.WriteLine(continueMessege);
                    Console.ReadLine();
                    userInputLoop = false;
                }
                else //User 'says' something unintelligible, program ends
                {
                    Console.WriteLine(finalUnknown);
                    Console.WriteLine(continueMessege);
                    Console.ReadLine();
                    userInputLoop = false;
                }

            } while (userInputLoop);
        }
    }
}
