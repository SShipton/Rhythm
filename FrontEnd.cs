using System;
using System.Collections.Generic;

namespace Rhythm
{
    class FrontEnd
    {
        public void Menu()
        {
            var userHasChosenToQuit = false;

            while (userHasChosenToQuit == false)
            {
                Console.WriteLine("Please choose one of the options below:");
                Console.WriteLine("(A)dd an Album");
                Console.WriteLine("(L)et a band go");
                Console.WriteLine("(R)esign a band");
                Console.WriteLine("(V)iew a band's albums");
                Console.WriteLine("(I) want to see all signed bands");
                Console.WriteLine("(Q)uit");

                var choice = PromptForString("I want to:  ");

                switch (choice)
                {
                    case "V":
                        var albums = Band.albums();

                        foreach (var album in bands)
                        {
                            var title = album.Title();
                            Console.WriteLine(title);
                        }
                        break;

                    case "I":
                        var bands = Band.name();

                        foreach (var band in bands)
                        {
                            var title = band.Name();
                            Console.WriteLine(name);
                        }
                        break;

                    case "A":
                        var albumTitle = PromptForString("Title: ");
                        var explicitBool = PromptForBool("Explicit?:  ");
                        var releaseDate = PromptForInt("Release Date:  ");
                        break;

                    case "R":
                        var bandName = PromptForString("Which band would you like to let go?:  ");

                        var bandName = (band.Name);
                        if (bandName == null)
                        {
                            Console.WriteLine($"We don't have a band named {bandName}");
                        }
                        else
                        {
                            var bandName = band.Name();
                            Console.WriteLine(bandName);

                            var shouldWeRemove = PromptForString("Are you sure that you want to remove this band from the database? (Y/N):  ");
                            if (shouldWeRemove == "Y")
                            {
                                Remove(bandName);
                            }
                        }
                        break;

                    case "Q":
                        userHasChosenToQuit = true;
                        break;
                }
            }
        }

    }
}