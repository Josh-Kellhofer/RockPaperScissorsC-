from player import Player
import random

public class Ai(Player)
    { 
   public string name;


//constructor

    public Ai()

    name = "WALL-E";
    
    }

//methods

public chooseGesture(self):
        
       

    chosenGestureIndex = random.randint(0, len(listOfGestures)-1)

    chosenGesture = listOfGestures[chosenGestureIndex]

    return chosenGesture