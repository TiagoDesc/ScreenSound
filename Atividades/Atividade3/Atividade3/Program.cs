do
{
    int secretNumber = 42;
    Console.Write("Enter the number between 1 and 100: ");
    int number = int.Parse(Console.ReadLine());

    if (number == secretNumber){
        Console.WriteLine("Congratulations, you got the number right!");
        break;
    }else if (number < secretNumber){
        Console.WriteLine("The number that you entered is smaller than the secret number.");
    }else{
        Console.WriteLine("The number that you entered is bigger than the secret number.");
    }

} while (true);

// Aleatory mode: 
// Random randomNumber = new Random();
// int secretNumber = randomm.Next(1, 101);