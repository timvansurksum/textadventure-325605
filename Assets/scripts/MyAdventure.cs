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
        Family2,
        Family3,
        Family5,
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
        if (currentState == States.start)
        {
            if (input == "walker")
            {
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
            input = "De ingevoerde text is: " + input;
            print(input);
        }

        if (currentState == States.intro)
        {
         if (input == "continue")
            {
                Terminal.ClearScreen();
                Terminal.WriteLine("Your asleep you have a nightmare the world is run over by zombies. " +
            "Then your house is surrounded by zombies and just when you’re about to die." +
            " Then you wake up and realize that that was no nightmare but reality. " +
            "You also realize that you are alone in your home, " +
            "then suddenly you experience great dread when thinking about where your family is" +
            "Type “continue” to start the game");
            }

        }



    }
    void StartIntro()
        {
            Terminal.ClearScreen();
           Terminal.WriteLine( "Your asleep you have a nightmare the world is run over by zombies. " +
               "Then your house is surrounded by zombies and just when you’re about to die. " +
               "Then you wake up and realize that that was no nightmare but reality. " +
               "You also realize that you are alone in your home, " +
               "then suddenly you experience great dread when thinking about where your family is Type “continue” to start the game");
        currentState = States.intro;

    }
    

    
}
