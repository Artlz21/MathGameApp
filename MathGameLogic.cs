namespace GameLogic {
    public class MathGameLogic() {
        public List<string> GameHistory {get; set;} = new List<string>();
        public int UserInput {get; set;}
        private int userAnswer;
        Random rand = new Random();
        private int firstValue = 0;
        private int secondValue = 0;
        
        public void ShowMenu () {
            Console.WriteLine("\nSelect an options below: ");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Show history");
            Console.WriteLine("6. Quit");
        }

        public int SetUserAnswer {
            set{ userAnswer = value; }
        }

        private void SetRandomNumbers () {
            firstValue = rand.Next(101);
            secondValue = rand.Next(101);

            while(firstValue < secondValue) {
                firstValue = rand.Next(101);
                secondValue = rand.Next(101);
            }
        }

        public void GameOperation () {
            switch (UserInput) {
                case 1:
                    SetRandomNumbers();
                    Console.Clear();
                    Console.WriteLine("\nSolve the addition problem");
                    Console.WriteLine($"{firstValue} + {secondValue}");
                    break;
                case 2:
                    SetRandomNumbers();
                    Console.Clear();
                    Console.WriteLine("\nSolve the subtraction problem");
                    Console.WriteLine($"{firstValue} - {secondValue}");
                    break;
                case 3:
                    SetRandomNumbers();
                    Console.Clear();
                    Console.WriteLine("\nSolve the division problem");
                    Console.WriteLine($"{firstValue} * {secondValue}");
                    break;
                case 4:
                    SetRandomNumbers();
                    while (firstValue % secondValue != 0) {
                        SetRandomNumbers();
                    }
                    Console.Clear();
                    Console.WriteLine("\nSolve the multiplication problem");
                    Console.WriteLine($"{firstValue} / {secondValue}");
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("\nYour game history: ");
                    DisplayGameHistory();
                    break;
            }
        }

        public void DisplayGameHistory () {
            foreach(string game in GameHistory) {
                Console.WriteLine(game);
            }
        }

        private bool CheckAddition() {
            if (userAnswer == firstValue + secondValue) return true;
            return false;
        }

        private bool CheckSubtraction() {
            if (userAnswer == firstValue - secondValue) return true;
            return false;
        }

        private bool CheckMultiplication() {
            if (userAnswer == firstValue * secondValue) return true;
            return false;
        }

        private bool CheckDivision() {
            if (userAnswer == firstValue / secondValue) return true;
            return false;
        }
        public bool CheckUserAnswer () {
            if (UserInput == 1) return CheckAddition();
            else if (UserInput == 2) return CheckSubtraction();
            else if (UserInput == 3) return CheckMultiplication();
            else if (UserInput == 4) return CheckDivision();
            else return false;
        }
    }
}