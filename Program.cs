using HW_Simple_Crud_Cli_App_NadavArania.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HW_Simple_Crud_Cli_App_NadavArania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new WebsiteContext())
            {
                Console.WriteLine("Hello welcome to our app here is our menu, please select what you want to do...");
                Console.WriteLine("1.Create an journalist \n2.Delete an journalist \n3.Update an journalist \n4.Get journalist details \n5.Get the list of journalistes \n6. Quit the app");
                int userNumInput = int.Parse(Console.ReadLine());
                while (userNumInput != 6)
                {
                    try
                    {
                        //Add journalist
                        if (userNumInput == 1)
                        {
                            try
                            {
                                Console.WriteLine("Please enter a name to the journalist you want to create!");
                                string userNameInput = Console.ReadLine();
                                Console.WriteLine("Please enter a age to the journalist you want to create!");
                                int userAgeInput = int.Parse(Console.ReadLine());
                                Console.WriteLine("Please enter a experince to the journalist you want to create!");
                                int userExperinceInput = int.Parse(Console.ReadLine());
                                context.Journalists.Add(new Journalist { JournalistName = userNameInput, JournalistAge = userAgeInput, JournalistExperince = userExperinceInput });
                                context.SaveChanges();
                            }
                            catch (Exception e)
                            {
                                throw new Exception("Please follow our instructions!" + e.Message);
                            }
                            
                        }

                        //Remove journalist
                        else if (userNumInput == 2)
                        {
                            try
                            {
                                Console.WriteLine("Please enter the id of the journalist that you want to delete!");
                                int userIdInput = int.Parse(Console.ReadLine());
                                var removeJouranlist = context.Journalists.SingleOrDefault(x => x.JournalistId == userIdInput);
                                if(removeJouranlist != null)
                                {
                                    context.Journalists.Remove(removeJouranlist);
                                    context.SaveChanges();
                                }
                                else
                                {
                                    Console.WriteLine("Cant find the id you want to delete, please try again!");
                                }
                            }
                            catch (Exception e)
                            {

                                throw new Exception("Please follow our instructions!" + e.Message);
                            }
                            
                        }

                        //Update journalist
                        else if (userNumInput == 3)
                        {
                            try
                            {
                                Console.WriteLine("Please enter the id of the journalist that you want to update!");
                                int userIdInput = int.Parse(Console.ReadLine());
                                var changeDetails = context.Journalists.SingleOrDefault(x => x.JournalistId == userIdInput);
                                if (changeDetails != null)
                                {
                                    Console.WriteLine("Enter journalist name");
                                    changeDetails.JournalistName = Console.ReadLine();
                                    Console.WriteLine("Enter journalist age");
                                    changeDetails.JournalistAge = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter journalist experince");
                                    changeDetails.JournalistExperince = int.Parse(Console.ReadLine());
                                    context.SaveChanges();
                                }
                            }
                            catch (Exception e)
                            {

                                throw new Exception("Please follow our instructions!" + e.Message);
                            }
                            
                        }

                        //Get spesific journalist details
                        else if (userNumInput == 4)
                        {
                            try
                            {
                                Console.WriteLine("Please enter the id of the journalist that you want to see his details!");
                                int? userIdInput = int.Parse(Console.ReadLine());
                                if (userIdInput != null)
                                {
                                    var jouranlistDetails = context.Journalists.SingleOrDefault(x => x.JournalistId == userIdInput);
                                    Console.WriteLine($"Jouranlist Id : {jouranlistDetails.JournalistId}, Journalist name : {jouranlistDetails.JournalistName}, Journalist Age : {jouranlistDetails.JournalistAge}, Journalist Experince : {jouranlistDetails.JournalistExperince}");
                                }
                                else
                                {
                                    Console.WriteLine("Cant find the id, please try again!");
                                }
                            }
                            catch (Exception e)
                            {

                                throw new Exception("Please follow our instructions!" + e.Message);
                            }
                            
                        }

                        //Get all journalists details
                        else if (userNumInput == 5)
                        {
                            var allJournalistDetails = context.Journalists.ToList();
                            allJournalistDetails.ForEach(x => Console.WriteLine($"Jouranlist Id : {x.JournalistId}, Journalist name : {x.JournalistName}, Journalist Age : {x.JournalistAge}, Journalist Experince : {x.JournalistExperince}"));
                        }

                        //Quit the app
                        else
                        {
                            break;
                        }

                        Console.WriteLine("What would you like to do now?\n1.Create an journalist \n2.Delete an journalist \n3.Update an journalist \n4.Get journalist details \n5.Get the list of journalistes \n6. Quit the app");
                        userNumInput = int.Parse(Console.ReadLine());

                    }
                    catch (Exception e)
                    {
                        throw new Exception("Please follow our instructions!" + e.Message);
                    }
                    
                }
            }
        }
    }
}
