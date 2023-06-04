
Random random = new Random();
int randomNumber = random.Next(10, 100);

int lastDigit = randomNumber % 10;
int first = randomNumber / 10;

Console.WriteLine(randomNumber);
if (first > lastDigit)
{
   Console.WriteLine(first); 
}
else 
{
    Console.WriteLine(lastDigit); 
}