using GameLogic;


MathGameLogic MathGame = new MathGameLogic();

MathGame.ShowMenu(); 
int userInput = Convert.ToInt32(Console.ReadLine());

while (userInput != 6) {
    MathGame.UserInput = userInput;
    MathGame.GameOperation();
    if (userInput == 5) {
        MathGame.ShowMenu(); 
        userInput = Convert.ToInt32(Console.ReadLine());
        continue;
    }
    MathGame.SetUserAnswer = Convert.ToInt32(Console.ReadLine());
    bool answerStatus = MathGame.CheckUserAnswer();

    if (answerStatus) {
        Console.WriteLine("You Got It!!!");
        MathGame.GameHistory.Add("You won");
    }
    else {
        Console.WriteLine("Sorry thats wrong...");
        MathGame.GameHistory.Add("You lost");
    }

    MathGame.ShowMenu(); 
    userInput = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
}