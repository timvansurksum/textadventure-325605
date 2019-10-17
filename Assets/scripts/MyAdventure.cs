using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAdventure : MonoBehaviour
{
    // een lijst met alle levels in de game
    private enum States
    {
        start,
        intro,
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
    // Start is called before the first frame update
    void Start()
    {
        print("hello world");
        Terminal.WriteLine("its ye boii");
        ShowMainMenu();

    }

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
            case (States.intro):
                if (input.ToLower() == "continue")
                {
                    currentState = States.Alone6;
                    StartAlone6();
                }
                else if (input == "") 
                {
                    currentState = States.;
                    Start();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("");
                }
                break;
            case (States.YouDie1):
                if (input.ToLower() == "continue")
                {
                    currentState = States.Alone6;
                    StartAlone6();
                }
                else if (input == "")
                {
                    currentState = States.;
                    Start();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("");
                }
                break;
            case (States.YouDie2):
                if (input.ToLower() == "continue")
                {
                    currentState = States.Alone6;
                    StartAlone6();
                }
                else if (input == "")
                {
                    currentState = States.;
                    Start();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("");
                }
                break;
            case (States.YouDie3):
                if (input.ToLower() == "continue")
                {
                    currentState = States.Alone6;
                    StartAlone6();
                }
                else if (input == "")
                {
                    currentState = States.;
                    Start();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("");
                }
                break;
            case (States.YouDie4):
                if (input.ToLower() == "continue")
                {
                    currentState = States.Alone6;
                    StartAlone6();
                }
                else if (input == "")
                {
                    currentState = States.;
                    Start();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("");
                }
                break;
            case (States.YouDie5):
                if (input.ToLower() == "continue")
                {
                    currentState = States.Alone6;
                    StartAlone6();
                }
                else if (input == "")
                {
                    currentState = States.;
                    Start();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("");
                }
                break;
            case (States.YouDie6):
                if (input.ToLower() == "continue")
                {
                    currentState = States.Alone6;
                    StartAlone6();
                }
                else if (input == "")
                {
                    currentState = States.;
                    Start();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("");
                }
                break;
            case (States.YouDie7):
                if (input.ToLower() == "continue")
                {
                    currentState = States.Alone6;
                    StartAlone6();
                }
                else if (input == "")
                {
                    currentState = States.;
                    Start();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("");
                }
                break;
            case (States.YouDie8):
                if (input.ToLower() == "continue")
                {
                    currentState = States.Alone6;
                    StartAlone6();
                }
                else if (input == "")
                {
                    currentState = States.;
                    Start();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("");
                }
                break;
            case (States.YouDie9):
                if (input.ToLower() == "continue")
                {
                    currentState = States.Alone6;
                    StartAlone6();
                }
                else if (input == "")
                {
                    currentState = States.;
                    Start();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("");
                }
                break;
            case (States.YouDie10):
                if (input.ToLower() == "continue")
                {
                    currentState = States.Alone6;
                    StartAlone6();
                }
                else if (input == "")
                {
                    currentState = States.;
                    Start();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("");
                }
                break;
            case (States.YouDie11):
                if (input.ToLower() == "continue")
                {
                    currentState = States.Alone6;
                    StartAlone6();
                }
                else if (input == "")
                {
                    currentState = States.;
                    Start();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("");
                }
                break;
            case (States.YouDie12):
                if (input.ToLower() == "continue")
                {
                    currentState = States.Alone6;
                    StartAlone6();
                }
                else if (input == "")
                {
                    currentState = States.;
                    Start();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("");
                }
                break;
            case (States.YouDie13):
                if (input.ToLower() == "continue")
                {
                    currentState = States.Alone6;
                    StartAlone6();
                }
                else if (input == "")
                {
                    currentState = States.;
                    Start();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("");
                }
                break;
            case (States.ImportantChoice1):
                if (input.ToLower() == "continue")
                {
                    currentState = States.Alone6;
                    StartAlone6();
                }
                else if (input == "")
                {
                    currentState = States.;
                    Start();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("");
                }
                break;
            case (States.ImportantChoice2):
                if (input.ToLower() == "continue")
                {
                    currentState = States.Alone6;
                    StartAlone6();
                }
                else if (input == "")
                {
                    currentState = States.;
                    Start();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("");
                }
                break;
            case (States.ImportantChoice3):
                if (input.ToLower() == "continue")
                {
                    currentState = States.Alone6;
                    StartAlone6();
                }
                else if (input == "")
                {
                    currentState = States.;
                    Start();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("");
                }
                break;
            case (States.Family1):
                if (input.ToLower() == "continue")
                {
                    currentState = States.Alone6;
                    StartAlone6();
                }
                else if (input == "")
                {
                    currentState = States.;
                    Start();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("");
                }
                break;
            case (States.Family2):
                if (input.ToLower() == "continue")
                {
                    currentState = States.Alone6;
                    StartAlone6();
                }
                else if (input == "")
                {
                    currentState = States.;
                    Start();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("");
                }
                break;
            case (States.Family3):
                if (input.ToLower() == "continue")
                {
                    currentState = States.Alone6;
                    StartAlone6();
                }
                else if (input == "")
                {
                    currentState = States.;
                    Start();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("");
                }
                break;
            case (States.Alone1):
                if (input.ToLower() == "continue")
                {
                    currentState = States.Alone6;
                    StartAlone6();
                }
                else if (input == "")
                {
                    currentState = States.;
                    Start();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("");
                }
                break;
            case (States.Alone2):
                if (input.ToLower() == "continue")
                {
                    currentState = States.Alone6;
                    StartAlone6();
                }
                else if (input == "")
                {
                    currentState = States.;
                    Start();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("");
                }
                break;
            case (States.Alone3):
                if (input.ToLower() == "continue")
                {
                    currentState = States.Alone6;
                    StartAlone6();
                }
                else if (input == "")
                {
                    currentState = States.;
                    Start();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("");
                }
                break;
            case (States.Alone4):
                if (input.ToLower() == "continue")
                {
                    currentState = States.Alone6;
                    StartAlone6();
                }
                else if (input == "")
                {
                    currentState = States.;
                    Start();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("");
                }
                break;
            case (States.Alone5):
                if (input.ToLower() == "continue")
                {
                    currentState = States.Alone6;
                    StartAlone6();
                }
                else if (input == "")
                {
                    currentState = States.;
                    Start();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("");
                }
                break;
            case (States.Alone6):
                if (input.ToLower() == "continue")
                {
                    currentState = States.Alone6;
                    StartAlone6();
                }
                else if (input == "")
                {
                    currentState = States.;
                    Start();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("");
                }
                break;
            case (States.Alone1point1):
                if (input.ToLower() == "continue")
                {
                    currentState = States.Alone6;
                    StartAlone6();
                }
                else if (input == "")
                {
                    currentState = States.;
                    Start();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("");
                }
                break;
            case (States.IllusionOfChoice):
                if (input.ToLower() == "continue")
                {
                    currentState = States.Alone6;
                    StartAlone6();
                }
                else if (input == "")
                {
                    currentState = States.;
                    Start();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("");
                }
                break;
            case (States.):
            case (States.JourneyWithStrangers1):
                if (input.ToLower() == "continue")
                {
                    currentState = States.Alone6;
                    StartAlone6();
                }
                else if (input == "")
                {
                    currentState = States.;
                    Start();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("");
                }
                break;
            case (States.JourneyWithStrangers2):
                if (input.ToLower() == "continue")
                {
                    currentState = States.Alone6;
                    StartAlone6();
                }
                else if (input == "")
                {
                    currentState = States.;
                    Start();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("");
                }
                break;
            case (States.JourneyWithStrangers3):
                if (input.ToLower() == "continue")
                {
                    currentState = States.Alone6;
                    StartAlone6();
                }
                else if (input == "")
                {
                    currentState = States.;
                    Start();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("");
                }
                break;
            case (States.JourneyWithStrangers4):
                if (input.ToLower() == "continue")
                {
                    currentState = States.Alone6;
                    StartAlone6();
                }
                else if (input == "")
                {
                    currentState = States.;
                    Start();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("");
                }
                break;
            case (States.JourneyWithStrangers5):
                if (input.ToLower() == "continue")
                {
                    currentState = States.Alone6;
                    StartAlone6();
                }
                else if (input == "")
                {
                    currentState = States.;
                    Start();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("");
                }
                break;
            case (States.JourneyWithStrangers6):
                if (input.ToLower() == "continue")
                {
                    currentState = States.Alone6;
                    StartAlone6();
                }
                else if (input == "")
                {
                    currentState = States.;
                    Start();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("");
                }
                break;
            case (States.YouWin1):
                if (input.ToLower() == "continue")
                {
                    currentState = States.Alone6;
                    StartAlone6();
                }
                else if (input == "")
                {
                    currentState = States.;
                    Start();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("");
                }
                break;
            case (States.YouWin2):
                if (input.ToLower() == "continue")
                {
                    currentState = States.Alone6;
                    StartAlone6();
                }
                else if (input == "")
                {
                    currentState = States.;
                    Start();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("");
                }
                break;
            case (States.YouWin3):
                if (input.ToLower() == "continue")
                {
                    currentState = States.Alone6;
                    StartAlone6();
                }
                else if (input == "")
                {
                    currentState = States.;
                    Start();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("");
                }
                break;
        }

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
        Terminal.WriteLine("");
        Terminal.WriteLine("");
    }
    void StartYouDie11()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("");
    }
    void StartYouDie12()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("");
    }
    void StartYouDie13()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("");
    }
    
}