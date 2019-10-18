﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAdventure : MonoBehaviour
{
    // een lijst met alle levels in de game
    private enum States
    {
        start,
        intro,
        credits,
        YouDie1,
        YouDie2,
        YouDie3,
        YouDie4,
        YouDie5,
        YouDie6,
        YouDie7,
        YouDie8,
        YouDie9,
        YouDie10,
        YouDie11,
        YouDie12,
        YouDie13,
        ImportantChoice1,
        ImportantChoice2,
        ImportantChoice3,
        Family1,
        Family2,
        Family3,
        Alone1,
        Alone1point1,
        Alone2,
        Alone3,
        Alone4,
        Alone5,
        Alone6,
        IllusionOfChoice,
        JourneyWithStrangers1,
        JourneyWithStrangers2,
        JourneyWithStrangers3,
        JourneyWithStrangers4,
        JourneyWithStrangers5,
        JourneyWithStrangers6,
        YouWin1,
        YouWin3,
        YouWin2,


    }
    private States currentState = States.start;

    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("zombotony");
        Terminal.WriteLine("can you survive the zombies?!!!?");
        Terminal.WriteLine("type walker to start");

    }
    // Update is called once per frame
    void Update()
    {

    }



    void OnUserInput(string input)
    {
        switch (currentState)
        {
            //starting fase of game (not actual gamplay)
            case (States.start):

                if (input.ToLower() == "walker")
                {
                    currentState = States.intro;
                    StartIntro();
                }
                else if (input == "lucille")
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("you ended up with glenn and abraham");
                    Terminal.WriteLine("Type 'walker' to start game.");
                }
                else if (input == "start")
                {

                    Terminal.ClearScreen();
                    Terminal.WriteLine("zombotony");
                    Terminal.WriteLine("can you survive the zombies?!!!?");
                    Terminal.WriteLine("type walker to start");

                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("have you never watched the walking dead?!!?!?!?");
                Terminal.WriteLine("just type walker");
                }
                break;
            case (States.credits):

                if (input.ToLower() == "menu")
                {
                    currentState = States.start;
                    StartStart();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("error type: menu");
                }
                break;
            case (States.intro):
                if (input.ToLower() == "continue")
                {
                    currentState = States.Alone6;
                    StartAlone6();
                }

                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("error Type: continue");
                }
                break;
                //code for deaths
            case (States.YouDie1):
                if (input.ToLower() == "menu")
                {
                    currentState = States.start;
                    StartStart();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("error type menu");
                }
                break;
            case (States.YouDie2):
                if (input.ToLower() == "menu")
                {
                    currentState = States.start;
                    StartStart();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("error type menu");
                }
                break;
            case (States.YouDie3):
                if (input.ToLower() == "menu")
                {
                    currentState = States.start;
                    StartStart();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("error type menu");
                }
                break;
            case (States.YouDie4):
                if (input.ToLower() == "menu")
                {
                    currentState = States.start;
                    StartStart();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("error type menu");
                }
                break;
            case (States.YouDie5):
                if (input.ToLower() == "menu")
                {
                    currentState = States.start;
                    StartStart();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("error type menu");
                }
                break;
            case (States.YouDie6):
                if (input.ToLower() == "menu")
                {
                    currentState = States.start;
                    StartStart();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("error type menu");
                }
                break;
            case (States.YouDie7):
                if (input.ToLower() == "menu")
                {
                    currentState = States.start;
                    StartStart();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("error type menu");
                }
                break;
            case (States.YouDie8):
                if (input.ToLower() == "menu")
                {
                    currentState = States.start;
                    StartStart();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("error type menu");
                }
                break;
            case (States.YouDie9):
                if (input.ToLower() == "menu")
                {
                    currentState = States.start;
                    StartStart();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("error type menu");
                }
                break;
            case (States.YouDie10):
                if (input.ToLower() == "menu")
                {
                    currentState = States.start;
                    StartStart();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("error type menu");
                }
                break;
            case (States.YouDie11):
                if (input.ToLower() == "menu")
                {
                    currentState = States.start;
                    StartStart();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("error type menu");
                }
                break;
            case (States.YouDie12):
                if (input.ToLower() == "menu")
                {
                    currentState = States.start;
                    StartStart();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("error type menu");
                }
                break;
            case (States.YouDie13):
                if (input.ToLower() == "menu")
                {
                    currentState = States.start;
                    StartStart();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("error type menu");
                }
                break;
                //code for actual gameplay choices that are not at the end of a path
            case (States.ImportantChoice1):
                if (input.ToLower() == "stay")
                {
                    currentState = States.IllusionOfChoice;
                    StartIllusionOfChoice();
                }
                else if (input == "leave")
                {
                    currentState = States.Family1;
                    StartFamily1();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("Error Type: stay/leave");
                }
                break;
            case (States.ImportantChoice2):
                if (input.ToLower() == "stay")
                {
                    currentState = States.JourneyWithStrangers5;
                    StartJourneyWithStrangers5();
                }
                else if (input == "leave")
                {
                    currentState = States.Alone3;
                    StartAlone3();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("Error Type: stay/leave");
                }
                break;
            case (States.ImportantChoice3):
                if (input.ToLower() == "kill")
                {
                    currentState = States.YouDie13;
                    StartYouDie13();
                }
                else if (input == "leave")
                {
                    currentState = States.Alone1point1;
                    StartAlone1point1();
                }
                else if (input == "stay")
                {
                    currentState = States.Family3;
                    StartFamily3();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("Error type: kill/leave/stay");
                }
                break;
            case (States.Family1):
                if (input.ToLower() == "hide")
                {
                    currentState = States.YouDie11;
                    StartYouDie11();
                }
                else if (input == "fight")
                {
                    currentState = States.YouDie10;
                    StartYouDie10();
                }
                else if (input == "flee")
                {
                    currentState = States.Family2;
                    StartFamily2();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("Error type: flee/fight/hide");
                }
                break;
            case (States.Family2):
                if (input.ToLower() == "tony")
                {
                    currentState = States.ImportantChoice3;
                    startImportantChoice3();
                }
                else if (input == "david")
                {
                    currentState = States.YouDie12;
                    StartYouDie12();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("Error type: david/tony");
                }
                break;
            case (States.Family3):
                if (input.ToLower() == "GrimesMuch")
                {
                    currentState = States.YouWin3;
                    StartYouWin3();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("Error Type: GrimesMuch");
                }
                break;
            case (States.Alone1):
                if (input.ToLower() == "flee")
                {
                    currentState = States.YouDie7;
                    StartYouDie7();
                }
                else if (input == "car")
                {
                    currentState = States.Alone2;
                    StartAlone2();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("Error Type: car/flee");
                }
                break;
            case (States.Alone2):
                if (input.ToLower() == "back")
                {
                    currentState = States.JourneyWithStrangers1;
                    StartJourneyWithStrangers1();
                }
                else if (input == "search")
                {
                    currentState = States.YouDie6;
                    StartYouDie6();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("Error type: search/back ");
                }
                break;
            case (States.Alone3):
                if (input.ToLower() == "continue")
                {
                    currentState = States.Alone4;
                    StartAlone4();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("Error type: continue");
                }
                break;
            case (States.Alone4):
                if (input.ToLower() == "continue")
                {
                    currentState = States.Alone5;
                    StartAlone5();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("Error type: continue");
                }
                break;
            case (States.Alone5):
                if (input.ToLower() == "continue")
                {
                    currentState = States.YouWin2;
                    StartYouWin2();
                }

                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("Error type: continue");
                }
                break;
            case (States.Alone6):
                if (input.ToLower() == "north")
                {
                    currentState = States.YouDie8;
                    StartYouDie8();
                }
                else if (input == "south")
                {
                    currentState = States.ImportantChoice1;
                    startImportantChoice1();
                }                
                else if (input == "stay")
                {
                    currentState = States.YouDie9;
                    StartYouDie9();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("Error type: north/south/stay");
                }
                break;
            case (States.Alone1point1):
                if (input.ToLower() == "continue")
                {
                    currentState = States.Alone4;
                    StartAlone4();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("Error type: continue");
                }
                break;
            case (States.IllusionOfChoice):
                if (input.ToLower() == "leave")
                {
                    currentState = States.Alone1;
                    StartAlone1();
                }
                else if (input == "stay")
                {
                    currentState = States.JourneyWithStrangers1;
                    StartJourneyWithStrangers1();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("Error type: leave/stay");
                }
                break;
            case (States.JourneyWithStrangers1):
                if (input.ToLower() == "continue")
                {
                    currentState = States.JourneyWithStrangers3;
                    StartJourneyWithStrangers3();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("Error type: continue");
                }
                break;
            case (States.JourneyWithStrangers2):
                if (input.ToLower() == "north")
                {
                    currentState = States.YouDie5;
                    StartYouDie5();
                }
                else if (input == "south")
                {
                    currentState = States.YouDie4;
                    StartYouDie4();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("Error type: south/north");
                }
                break;
            case (States.JourneyWithStrangers3):
                if (input.ToLower() == "live")
                {
                    currentState = States.YouDie3;
                    StartYouDie3();
                }
                else if (input == "fight")
                {
                    currentState = States.JourneyWithStrangers4;
                    StartJourneyWithStrangers4();
                }
                else if (input == "run")
                {
                    currentState = States.JourneyWithStrangers2;
                    StartJourneyWithStrangers2();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("Error type: live/fight/run");
                }
                break;
            case (States.JourneyWithStrangers4):
                if (input.ToLower() == "sneak")
                {
                    currentState = States.ImportantChoice2;
                    startImportantChoice2();
                }
                else if (input == "charge")
                {
                    currentState = States.YouDie2;
                    StartYouDie2();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("Error type: sneak/charge");
                }
                break;
            case (States.JourneyWithStrangers5):
                if (input.ToLower() == "help")
                {
                    currentState = States.YouWin1;
                    StartYouDie1();
                }
                else if (input == "risk")
                {
                    currentState = States.JourneyWithStrangers6;
                    StartJourneyWithStrangers6();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("Error type: help/risk");
                }
                break;
            case (States.JourneyWithStrangers6):
                if (input.ToLower() == "continue")
                {
                    currentState = States.YouWin1;
                    StartYouWin1();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("Error type: continue");
                }
                break;
                // code for the positive endings of the game
            case (States.YouWin1):
                if (input.ToLower() == "bittersweet")
                {
                    currentState = States.credits;
                    StartCredits();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("Error type: bittersweet");
                }
                break;
            case (States.YouWin2):
                if (input.ToLower() == "peace")
                {
                    currentState = States.credits;
                    StartCredits();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("Error type: peace");
                }
                break;
            case (States.YouWin3):
                if (input.ToLower() == "peace")
                {
                    currentState = States.credits;
                    StartCredits();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("Error type: peace");
                }
                break;
        }

        }

    //code with all the text (the script) to be displayed
    void StartStart()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("zombotony");
        Terminal.WriteLine("can you survive the zombies?!!!?");
        Terminal.WriteLine("type walker to start");
    }
    void StartCredits()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Writer: Tim van Surksum ");
        Terminal.WriteLine("Lead programmer: Tim van surksum");
        Terminal.WriteLine("publisher: digital extremes");
        Terminal.WriteLine("Co story writer: a maze I found on google images");
        Terminal.WriteLine("Music: Bear McCrear");
        Terminal.WriteLine("");
        Terminal.WriteLine("Type “menu” to go back to the menu.");

    }
    void StartIntro()
{
    Terminal.ClearScreen();
    Terminal.WriteLine("Your asleep you have a nightmare the world is run over by zombies. " +
        "Then your house is surrounded by zombies and just when you’re about to die. " +
        "Then you wake up and realize that that was no nightmare but reality. " +
        "You also realize that you are alone in your home, " +
        "then suddenly you experience great dread when thinking about where your family is.");
        Terminal.WriteLine("Type “continue” to start the game");
    }
    void StartYouDie1()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You help the explanation however there are just too many zombies." +
            "Eventually the area is taken but at great cost of lives including yours." +
            "You're remembered as a hard worker towards a better future and a great leader" );
        Terminal.WriteLine("Type “menu” to go back to the menu.");
    }
    void StartYouDie2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You charge them head on but what you did not know is that their leader" +
            " is an army Seargeant who trained everyone over the past year you stand no chance," +
            " but at least your death is glorious. ");
        Terminal.WriteLine("Type “menu” to go back to the menu.");
    }
    void StartYouDie3()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You live together for about 3 days till you" +
            "and the other leaders of your group are killed") ;
        Terminal.WriteLine("Type “menu” to go back to the menu.");
    }
    void StartYouDie4()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You go south, but soon you notice that with the " +
            "many people you are you just simply don’t have enough food." +
            " You lose the spirit to fight and get taken by surprise by the zombies. ");
        Terminal.WriteLine("Type “menu” to go back to the menu.");
    }
    void StartYouDie5()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You go north, but soon you notice that with the many people" +
            " you are you just simply don’t have enough food.You lose the spirit to fight" +
            " and get taken by surprise by the zombies. ");
        Terminal.WriteLine("Type “menu” to go back to the menu.");
    }
    void StartYouDie6()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You spend weeks trying to find your family," +
            " but with time you end up losing hope and end up in a state of depression. " +
            "You lose your will to live and eventually die due to recklessness. ");
        Terminal.WriteLine("Type “menu” to go back to the menu.");
    }
    void StartYouDie7()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("After fleeing from the zombies," +
            " you notice it getting dark. You decide to seek shelter in the mall," +
            " however its dark and there are more zombies. ");
        Terminal.WriteLine("Type “menu” to get back to the menu.");
    }
    void StartYouDie8()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("you go north out of Florida after about a month of traveling" +
            " you end up at the border of Canada exhausted and hungry your alone there are almost no zombies," +
            " but it doesn’t matter because you have no food.");
        Terminal.WriteLine("Type “start” to go back to the menu.");
    }
    void StartYouDie9()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("you chose to stay at your house this." +
            " This goes well for about a month when all your food has " +
            "run out you get surrounded by zombies at the mall and this " +
            "is the end you kill as many as you can. Hoping this will at " +
            "least help the other humans alive.  ");
        Terminal.WriteLine("Type “start” to go back to the menu.");
    }
    void StartYouDie10()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You choose to fight, however." +
            " From behind another bigger horde of zombies appears you are lost." +
            " You spend your dying moments in dread to relieve the suffering you " +
            "shoot your family through the head and then yourself. ");
        Terminal.WriteLine("Type “start” to go back to the menu.");
    }
    void StartYouDie11()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("after about 3 hours you realize that the bunker is surrounded" +
            " those who fought lost. You have no place to go. " +
            "You and the others die of hunger, or commit suicide. ");
        Terminal.WriteLine("Type “start” to go back to the menu.");
    }
    void StartYouDie12()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You try to save David and Martha but when you are almost" +
            " done a large horde of zombies comes from behind and you all die. ");
        Terminal.WriteLine("Type “start” to go back to the menu.");
    }
    void StartYouDie13()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You wander around to find them when it turns night and you realize that this wasn’t" +
            " a way to honor them, but it was your out. You let yourself be eaten by zombies forever roaming this " +
            "earth as a shadow of what you once were.");
        Terminal.WriteLine("Type “start” to go back to the menu.");
    }
    void startImportantChoice1()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("After 2 days of traveling you meet a large group of people," +
            " they seem friendly. But they want to go to cape Canaveral to hopefully get help" +
            " from the military. But you know that your family probably would have gone to Orlando." +
            " So, you must choose search for your family risking death or stay with this group. ");
        Terminal.WriteLine("Type “stay” to stay with the group.");
        Terminal.WriteLine("Type “leave” to search for your family.");
    }
    void startImportantChoice2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You and another leader Natasja sneak in the building and successfully assassinate their leader." +
            " Apparently, he was an army Seargeant who oppressed the people into taking arms up against us." +
            " So, there is finally peace. And over the past year you have slowly fallen in love with Natasja," +
            " but when she finally kisses you. You get reminded of your old family. You're struck between " +
            "taking this huge step moving on or staying in the past. Do you leave or stay? ");
        Terminal.WriteLine("Type “stay” to stay.");
        Terminal.WriteLine("Type “leave” to leave.");
        
    }
    void startImportantChoice3()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("It is 2 weeks later, and everyone is still struck by the deaths of Martha and David." +
            " You! chose who to save, therefore you most of all are broken. " +
            "You consider leaving or at least to try to kill them as zombies and give them a proper burial. " +
            "Everyone tries to convince you that you should neither leave nor find their zombies. ");
        Terminal.WriteLine("Type ”kill” to kill those you left behind.");
        Terminal.WriteLine("Type “leave” to leave the group.");
        Terminal.WriteLine("Type “stay” to stay. ");
    }
    void StartFamily1()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("After 4 days of traveling you discover a huge military camp. " +
            "You have been there for 3 days when you find your family.You are as happy as you could possibly be," +
            " however the feeling is short lived the camp gets overrun by a huge group of zombies." +
            " Most of the people are fighting back with all they got, there is a military truck nearby. " +
            "Then suddenly you realize that this camp is built on an old fort and you can enter it." +
            " Do you flee hide or do you fight?");
        Terminal.WriteLine("Type “hide” to hide in the bunker.");
        Terminal.WriteLine("Type “fight” to defend the camp.");
        Terminal.WriteLine("Type “flee” to take the truck and flee.");
    }
    void StartFamily2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You fled the base with the truck and a nice family of 4(David, Martha," +
            " indigo, and tony). The family white is very nice and over a period of 6 hours" +
            " you bond with them. En then you notice you are out of gas." +
            " You get surrounded by zombies you fight your way through," +
            " but Tony and Indigo are surrounded and so are Martha and David." +
            " You all realize you can only save 2 people do you either save Tony and Indigo," +
            " or Martha and David. ");
        Terminal.WriteLine("Type “Tony” to try to save Tony and Indigo.");
        Terminal.WriteLine("Type “David” to try to save David and Martha.");
    }
    void StartFamily3()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You stayed with the group never forgetting what you did. " +
            "With the memory staying like a scar for the rest of your live. " +
            "You spend the next few yours surviving the apocalypse and slowly rebuilding society. " +
            "Your experiences shaped the person you are today. " +
            " Trying to save every human you can.");
        Terminal.WriteLine("Type “GrimesMuch” to continue.");
    }
    void StartAlone1()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You leave alone with only a few supplies and a small car." +
            "After only a day of traveling you realize the magnitude of doing this alone when" +
            " faced with a group of zombies around your car when you left shortly before." +
            " Do you try and get your car back risking getting bit? Or do you flee risking " +
            "not being able to find a car. ");
        Terminal.WriteLine("Type “flee” to flee.");
        Terminal.WriteLine("ype “car” to try to get your car back.");
    }
    void StartAlone1point1()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You decided to go away because you could not bear to be with them. " +
            "You decide to go back to your home up north. In a sort of self-banishment. " +
            "You retake your home. ");
        Terminal.WriteLine("Type “continue” to continue. ");

    }
    void StartAlone2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You succeed in getting back your car however the tank has not nearly" +
            " enough to get to where your family has gone. Do you risk the journey and seek" +
            " after your family or do you accept their death and move on with your new family? ");
        Terminal.WriteLine("Type “back” to go back.");
        Terminal.WriteLine("Type “search” to try to find your family.");
    }
    void StartAlone3()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You just could not take that reminder you leave. " +
            "You go back to your old home. As a reminder of Who you left to be alive.");
        Terminal.WriteLine("Type “continue” to continue.");
    }
    void StartAlone4()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You live a lonely life in your home of grief. " +
            "You wake up farm food kill zombies and go to bed. You're in a" +
            " continuing circle of depression. Then you decide to retake your hometown not" +
            " for yourself but for those who come and are willing to stay. ");
        Terminal.WriteLine("Type “continue” to continue.");

    }
    void StartAlone5()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Years later you have built a massive society of people" +
            " and you hear that your family died their dead bodies roaming around the" +
            " country. Once again you are struck with grief and self-hate. Could you " +
            "have made a difference ");
        Terminal.WriteLine("Type “continue” to read the next chapter.");
    }
    void StartAlone6()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You have survived the apocalypse for 2 weeks now" +
            " when you come to an conclusion: you stay here taking your chances," +
            " you go out lightly packed heading up north were you hope zombies can’t survive" +
            " because of the zombies, or you go to the south were you think most people and hopefully" +
            " your family will be. Risking the enormous number of zombies that will be there.");
        Terminal.WriteLine("Type “north” to go north.");
        Terminal.WriteLine("Type “south” to go south.");
        Terminal.WriteLine("Type “stay” to stay.");
    }
    void StartIllusionOfChoice()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You chose to stay with the group sadly after 2 weeks of traveling," +
            " and you getting to know them your travels and hardships are for nothing there is no-one" +
            " at the military base. Hearing this everyone wants to set up a base and maybe eventually" +
            " a society at the base. You feel great sadness knowing you could have sought after your" +
            " family and there empathetic to how you feel, however the ask you not to go and stay and help ");

        Terminal.WriteLine("Type “leave” to leave.");
        Terminal.WriteLine("Type “stay to stay.");
    }
    void StartJourneyWithStrangers1()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("After 1 year you finally made peace with the loss of your family." +
            " You move on having found a purpose of keeping people safe.  ");
        Terminal.WriteLine("Type “continue” to continue");
    }
    void StartJourneyWithStrangers2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You want to flee but where? Do you go north till you find some place," +
            " or do you try and reach Miami hoping there is another more welcome group there. ");
        Terminal.WriteLine("Type “north” to go north.");
        Terminal.WriteLine("Type “south” to go to Miami.");

    }
    void StartJourneyWithStrangers3()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("The society is doing well its seen as a safe haven" +
            " for those who arrive however there is another group forming." +
            " Turmoil stirs within the communities. Do you leave taking your" +
            " chances somewhere else do you fight, or do you try to live together?");
        Terminal.WriteLine("Type “live” to try to live with the other community.");
        Terminal.WriteLine("Type “fight” to go to war. ");
        Terminal.WriteLine("Type “run” to flee.");
    }
    void StartJourneyWithStrangers4()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Going to war it is," +
            " but now a plan of action is needed do you attack there base " +
            "or do you assassinate their leaders. ");
        Terminal.WriteLine("Type “sneak” for an assassination attempt.");
        Terminal.WriteLine("Type “charge” to attack them head on.");
    }
    void StartJourneyWithStrangers5()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You chose that to be able to honor your old family" +
            " you would have to at least be happy. So, you persue a relationship with Natasja." +
            " Years go by and the community is growing fast they need people to take over a large area." +
            " Do you help, or do you decide you have survived too much and" +
            " have too much to risk taking that chance. ");
        Terminal.WriteLine("Type “help” to help.");
        Terminal.WriteLine("Type “risk” to stay and be with your family.");
    }
    void StartJourneyWithStrangers6()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("After you did not choose to help almost no-one wanted to go" +
            " it took another 6 years to take the area. " +
            "At that point you had 2 kids to teach about the world that once was and the world" +
            " that is to come, there world. ");
        Terminal.WriteLine("Type “continue” to continue.");
    }
    void StartYouWin2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Decades pass your kids grow up and get kids of their own" +
            " when finaly at the age of 58 you die of natural causes." +
            " You are remembered as one of the people responsible for humans being" +
            " alive today you are admired across the new country you helped form.");
        Terminal.WriteLine("Type “peace” to go to the credits.");
    }
    void StartYouWin3()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You build a so safe that decades down the line statues are built after you." +
            " You are a hero. In fact, life is so safe that you die by heart attack while writing a book." +
            " Your funeral was attended by all the people around you. You die a hero's death.");
        Terminal.WriteLine("Type “peace” to go to the credits.");
    }
    void StartYouWin1()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("At the age of 80 you die of a heart attack alone in your house." +
            " You were the reason thousands lived yet almost no-one knows that only 5 people" +
            " that were at your community since the beginning spend your funeral. The world is safer" +
            " thanks to you. Yet it feels bittersweet to both you in your last years and for those" +
            " who knew you and your story.");
        Terminal.WriteLine("Type “bittersweet” to go to the credits.");
    }

}