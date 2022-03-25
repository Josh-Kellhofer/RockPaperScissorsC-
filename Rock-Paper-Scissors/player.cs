public class Player
{
    public int wins;
    public string name;
    public string listOfGestures;
    public string chosenGesture;

    //constructor

    public Player(string name)
    {
        wins = 0;
        this.name = name;
        listOfGestures = ['Rock', 'Paper', 'Scissors', 'Lizard', 'Spock'];
        chosenGesture = "";
    }

    //member methods


    public string chooseGesture()
    {
        bool validGesture = false;

        while (validGesture = false)
        {
            listOfGestures = ['Rock', 'Paper', 'Scissors', 'Lizard', 'Spock'];

            for gesture in listOfGestures:

                Console.WriteLine(f'Press [{listOfGestures.index(gesture)}] for {gesture}')

            Console.WriteLine('Selection: ')
            int chosenGesture = Console.Readline();
            Console.WriteLine(chosenGesture)

            if (chosenGesture == '0' or chosenGesture == '1' or chosenGesture == '2' or chosenGesture == '3' or chosenGesture == '4'):

                validGesture = true


                integerChosenGesture = int(chosenGesture)

                chosenGesture = listOfGestures[integerChosenGesture]

                return chosenGesture

            else:

                validGesture = false

                Console.WriteLine('Invalid selection, try again.')
        }
    }

}

             
            

            