using System.Diagnostics;

string[] options = { "rock", "paper", "scissors" };
int botChoice;
string playerChoice;
int convertedP;

Console.WriteLine("Rock paper scissors because my teacher told me to...");
reset();

void comparison(int bot, int player)
{
    Console.WriteLine("Bot chose: " + options[bot] + "\nPlayer chose: " + options[player]);
    if (bot == player) {
        Console.WriteLine("Draw, resetting.");
        reset();
    }
    else if (bot == 0 && bot - player == -1 || bot == 1 && bot - player == -1 || bot == 2 && bot - player == 2) {
        Console.WriteLine("Player wins.");
    }
    else {
        Console.WriteLine("Bot wins.");
    }
    Console.WriteLine("Would you like to play again? y/n");
    string pChoice;
    pChoice = Console.ReadLine();
    if (pChoice == "y" || pChoice =="Y" || pChoice == "") {
        reset();
        pChoice = "";
    }
    else {
        Process.GetCurrentProcess().Kill();
    }
}

void reset()
{
    Random random = new Random();
    botChoice = random.Next(0, 2);
    playerChoice = null;
    Console.WriteLine("Choose your option: \n1: Rock \n2: Paper \n3: Scissors");
    while (optionChecker(playerChoice) == false) {
        playerChoice = Console.ReadLine();
    }
    Int32.TryParse(playerChoice, out convertedP);
    convertedP -= 1;
    comparison(botChoice, convertedP);
}

bool optionChecker(string Option)
{
    if (Option != "1" && Option != "2" && Option != "3")
    {
        return false;
    } else {
        return true;
    }
}