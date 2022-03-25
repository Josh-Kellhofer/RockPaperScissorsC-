from human import Human
from ai import Ai

class Game
{ 
    
        
       player1 = Human()

       desiredRounds = 2

    def introduction(): #displays rules and asks the user if they want to play single player or multiplayer. void

        player1InputValid = false

        player1.setName()

        Console.WriteLine(f'Welcome to the game {player1.name}\n')

        Console.WriteLine("Before you play you'll have to know the rules! This isn't your ma and pa's rock, paper, scissors!\n")

        Console.WriteLine("HERE ARE THE RULES!\n")
        Console.WriteLine("************************************************************************************")

        listOfRules = ['--Rock crushes Scissors & smashes Lizard', '--Scissors cuts Paper & decapitates Lizard', '--Paper covers Rock & disproves Spock', '--Lizard poisons Spock & eats Paper', '--Spock smashes Scissors & vaporizes Rock\n']

        for rule in listOfRules:

            Console.WriteLine(rule)

        Console.WriteLine("************************************************************************************")

        while player1InputValid is false:

            Console.WriteLine('Would you like to play against an opponent or the AI?: Press [1] to play with a friend or [2] to face the CPU. ')
            string player1Input = Console.ReadLine()

            if (player1Input == '1'):
                player2 = Human()
                Console.WriteLine("What is the 2nd player's name? ")
                string player2.name = Console.ReadLine()
                Console.WriteLine(f"Welcome to the game, {player2.name}\n")
                player1InputValid = true

            elif(player1Input == '2'):

                player2 = Ai()
                player1InputValid = true

            else:
                
                Console.WriteLine('Invalid response, please try again.')
                player1InputValid = false

        isDigit = false

        while isDigit is false:

               Console.WriteLine('How many rounds do you want to win the game? ')
               
               desiredRoundsInput = Console.ReadLine()

            if desiredRoundsInput.isnumeric() == true:

                desiredRounds = int(desiredRoundsInput)

                maximumRounds = (desiredRounds * 2) - 1

                Console.WriteLine(f"Looks like you chose best {desiredRounds} out of {maximumRounds}.\n")

                isDigit = true

            else:

                Console.WriteLine('Invalid response, please try again.')

                isDigit = false


    def run_game(self): #runs all functions. void
        
        introduction()

        winner = false

        while winner is false:
        
            round()

            if ((player1.wins == desiredRounds) or (player2.wins == desiredRounds)):
                
                winner = true


            else:

                winner = false
                Console.WriteLine(f"{player1.name} has {player1.wins} wins and {player2.name} has {player2.wins} wins.\n")

        display_winner()

    def round(): #keeps track of wins - while loop until wins for either player == 2. void player1.wins < 2 or player2.wins < 2:

        Console.WriteLine(f"It is now {player1.name}'s turn")
        player1.chooseGesture()


        Console.WriteLine(f"It is now {player2.name}'s turn")
        player2.chooseGesture()

        compareGestures()

    def compareGestures():

        if (player1.chosenGesture == 'Rock' and player2.chosenGesture == 'Scissors'):               
            Console.WriteLine(f'{player1.name} chose Rock and {player2.name} chose Scissors\n')
            Console.WriteLine(f'Rock crushes scissors! {player1.name} wins!\n')
            player1.wins += 1


        elif(player2.chosenGesture == 'Rock' and player1.chosenGesture == 'Scissors'):
            Console.WriteLine(f'{player2.name} chose Rock and {player1.name} chose Scissors\n')
            Console.WriteLine(f'Rock crushes scissors! {player2.name} wins!\n')
            player2.wins += 1

        elif(player1.chosenGesture == 'Rock' and player2.chosenGesture == 'Lizard'):         
            Console.WriteLine(f'{player1.name} chose Rock and {player2.name} chose Lizard\n')
            Console.WriteLine(f'Rock crushes Lizard! {player1.name} wins!\n')
            player1.wins += 1


        elif(player2.chosenGesture == 'Rock' and player1.chosenGesture == 'Lizard'):
            Console.WriteLine(f'{player2.name} chose Rock and {player1.name} chose Lizard\n')
            Console.WriteLine(f'Rock crushes Lizard! {player2.name} wins!\n')
            player2.wins += 1

        elif(player1.chosenGesture == 'Scissors' and player2.chosenGesture == 'Paper'):      
            Console.WriteLine(f'{player1.name} chose Scissors and {player2.name} chose Paper\n')
            Console.WriteLine(f'Scissors cuts paper! {player1.name} wins!\n')
            player1.wins += 1


        elif(player2.chosenGesture == 'Scissors' and player1.chosenGesture == 'Paper'):
            Console.WriteLine(f'{player2.name} chose Scissors and {player1.name} chose Paper\n')
            Console.WriteLine(f'Scissors cuts paper! {player2.name} wins!\n')
            player2.wins += 1

        elif(player1.chosenGesture == 'Scissors' and player2.chosenGesture == 'Lizard'):               
            Console.WriteLine(f'{player1.name} chose Scissors and {player2.name} chose Lizard\n')
            Console.WriteLine(f'Scissors crushes Lizard! {player1.name} wins!\n')
            player1.wins += 1


        elif(player2.chosenGesture == 'Scissors' and player1.chosenGesture == 'Lizard'):
            Console.WriteLine(f'{player2.name} chose Scissors and {player1.name} chose Lizard\n')
            Console.WriteLine(f'Scissors crushes Lizard! {player2.name} wins!\n')
            player2.wins += 1

        elif(player1.chosenGesture == 'Paper' and player2.chosenGesture == 'Rock'):               
            Console.WriteLine(f'{player1.name} chose Paper and {player2.name} chose Rock\n')
            Console.WriteLine(f'Paper suffocates Rock! {player1.name} wins!\n')
            player1.wins += 1


        elif(player2.chosenGesture == 'Paper' and player1.chosenGesture == 'Rock'):
            Console.WriteLine(f'{player2.name} chose Paper and {player1.name} chose Rock\n')
            Console.WriteLine(f'Paper suffocates Rock! {player2.name} wins!\n')
            player2.wins += 1

        elif(player1.chosenGesture == 'Paper' and player2.chosenGesture == 'Spock'):               
            Console.WriteLine(f'{player1.name} chose Paper and {player2.name} chose Spock\n')
            Console.WriteLine(f'Paper overwhelms Spock! {player1.name} wins!\n')
            player1.wins += 1


        elif(player2.chosenGesture == 'Paper' and player1.chosenGesture == 'Spock'):
            Console.WriteLine(f'{player2.name} chose Paper and {player2.name} chose Spock\n')
            Console.WriteLine(f'Paper overwhelms Spock! {player2.name} wins!\n')
            player2.wins += 1

        elif(player1.chosenGesture == 'Lizard' and player2.chosenGesture == 'Spock'):               
            Console.WriteLine(f'{player1.name} chose Lizard and {player2.name} chose Spock\n')
            Console.WriteLine(f'Lizard licks Spock to death! {player1.name} wins!\n')
            player1.wins += 1


        elif(player2.chosenGesture == 'Lizard' and player1.chosenGesture == 'Spock'):
            Console.WriteLine(f'{player2.name} chose Lizard and {player1.name} chose Spock\n')
            Console.WriteLine(f'Lizard licks Spock to death! {player2.name} wins!\n')
            player2.wins += 1

        elif(player1.chosenGesture == 'Lizard' and player2.chosenGesture == 'Paper'):               
            Console.WriteLine(f'{player1.name} chose Lizard and {player2.name} chose Paper\n')
            Console.WriteLine(f'Lizard licks paper into a drooly mess! {player1.name} wins!\n')
            player1.wins += 1


        elif(player2.chosenGesture == 'Lizard' and player1.chosenGesture == 'Paper'):
            Console.WriteLine(f'{player2.name} chose Lizard and {player1.name} chose Paper\n')
            Console.WriteLine(f'Lizard licks paper into a drooly mess! {player2.name} wins!\n')
            player2.wins += 1

        elif(player1.chosenGesture == 'Spock' and player2.chosenGesture == 'Scissors'):               
            Console.WriteLine(f'{player1.name} chose Spock and {player2.name} chose Scissors\n')
            Console.WriteLine(f'Spock dismantles scissors! {player1.name} wins!\n')
            player1.wins += 1


        elif(player2.chosenGesture == 'Spock' and player1.chosenGesture == 'Scissors'):
            Console.WriteLine(f'{player2.name} chose Spock and {player1.name} chose Scissors\n')
            Console.WriteLine(f'Spock dismantles scissors! {player2.name} wins!\n')
            player2.wins += 1

        elif(player1.chosenGesture == 'Spock' and player2.chosenGesture == 'Rock'):               
            Console.WriteLine(f'{player1.name} chose Spock and {player2.name} chose Rock\n')
            Console.WriteLine(f'Spock phasers Rock into dust! {player1.name} wins!\n')
            player1.wins += 1


        elif(player2.chosenGesture == 'Spock' and player1.chosenGesture == 'Rock'):
            Console.WriteLine(f'{player2.name} chose Spock and {player1.name} chose Rock\n')
            Console.WriteLine(f'Spock phasers Rock into dust! {player2.name} wins!\n')
            player2.wins += 1

        elif(player2.chosenGesture == player1.chosenGesture):
            Console.WriteLine(f'{player2.name} and {player1.name} chose the same thing!')
            Console.WriteLine("It's a tie, no one wins. Select again.\n")
            player2.wins += 0




    def displayWinner(): #once two wins are achieved by either player, this is displayed. void, funtion complete.

            if (player1.wins == desiredRounds):

                Console.WriteLine(f"{player1.name} has won the game!\n")

            elif(player2.wins == desiredRounds):

                if (player2.name == 'WALL-E'):

                    Console.WriteLine("WALL-E had become self-aware and has finally defeated his human overlords!\n")

                else:

                    Console.WriteLine(f"{player2.name} has won the game!\n")

            playAgainValue = false

            while playAgainValue is false:

                Console.WriteLine("Would you like to play again? Yes or No. ")

                string playAgain = Console.ReadLine()

                if (playAgain == 'Yes' or playAgain == 'yes' or playAgain == 'y'):

                    playAgainValue = true

                    player1.wins = 0

                    player2.wins = 0

                    run_game()

                elif(playAgain == "No" or playAgain == 'no' or playAgain == 'n'):

                    playAgain = true

                    Console.WriteLine("Goodbye!")

                    break

                else:
                
                    Console.WriteLine('Invalid response, please try again.')

                    playAgainValue = false






        