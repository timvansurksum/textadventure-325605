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

            break;
            case (States.YouDie1):

            break;
            case (States.YouDie2):

            break;
            case (States.YouDie3):

            break;
            case (States.YouDie4):

            break;
            case (States.YouDie5):

            break;
            case (States.YouDie6):

            break;
            case (States.YouDie7):

            break;
            case (States.YouDie8):

            break;
            case (States.YouDie9):

            break;
            case (States.YouDie10):

            break;
            case (States.YouDie11):

            break;
            case (States.YouDie12):

            break;
            case (States.YouDie13):

            break;
            case (States.ImportantChoice1):

            break;
            case (States.ImportantChoice2):

            break;
            case (States.ImportantChoice3):

            break;
            case (States.Family1):

            break;
            case (States.Family2):

            break;
            case (States.Family3):

            break;
            case (States.Alone1):

            break;
            case (States.Alone2):

            break;
            case (States.Alone3):

            break;
            case (States.Alone4):

            break;
            case (States.Alone5):

            break;
            case (States.Alone6):

            break;
            case (States.Alone1point1):

            break;
            case (States.IllusionOfChoice):

            break;
            case (States.):
            case (States.JourneyWithStrangers1):

            break;
            case (States.JourneyWithStrangers2):

            break;
            case (States.JourneyWithStrangers3):

            break;
            case (States.JourneyWithStrangers4):

            break;
            case (States.JourneyWithStrangers5):

            break;
            case (States.JourneyWithStrangers6):

            break;
            case (States.YouWin1):

            break;
            case (States.YouWin2):

            break;
            case (States.YouWin3):

            break;
        }

        }



    }
void StartIntro()
{
    Terminal.ClearScreen();
    Terminal.WriteLine("Your asleep you have a nightmare the world is run over by zombies. " +
        "Then your house is surrounded by zombies and just when you’re about to die. " +
        "Then you wake up and realize that that was no nightmare but reality. " +
        "You also realize that you are alone in your home, " +
        "then suddenly you experience great dread when thinking about where your family is Type “continue” to start the game");
    currentState = states.YouDie1;
        }
    void StartYouDie1()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine();
        Terminal.WriteLine();
    }
    void StartYouDie2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine();
        Terminal.WriteLine();
    }
    void StartYouDie3()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine();
        Terminal.WriteLine();
    }
    void StartYouDie4()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine();
        Terminal.WriteLine();
    }
    void StartYouDie5()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine();
        Terminal.WriteLine();
    }
    void StartYouDie6()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine();
        Terminal.WriteLine();
    }
    void StartYouDie7()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine();
        Terminal.WriteLine();
    }
    void StartYouDie8()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine();
        Terminal.WriteLine();
    }
    void StartYouDie9()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine();
        Terminal.WriteLine();
    }
    void StartYouDie10()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine();
        Terminal.WriteLine();
    }
    void StartYouDie11()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine();
        Terminal.WriteLine();
    }
    void StartYouDie12()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine();
        Terminal.WriteLine();
    }
    void StartYouDie13()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine();
        Terminal.WriteLine();
    }
    
}



}
