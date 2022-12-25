int Get5DigitNumber(string message)
{
    Console.WriteLine(message);
    int AnyNumber = int.Parse(Console.ReadLine()!); 
    return AnyNumber;
}
int AnyNumber= Get5DigitNumber("Input 5 digit  number");

int FirstHalf = AnyNumber/1000;
int SecondHalf = AnyNumber%100;

int GetReversedNumber(int AnyNumber)
   {
        
        int Rev = SecondHalf%10*10+SecondHalf/10;
    
        return Rev;
   }
     int ThreeDigitNumber = GetReversedNumber(AnyNumber);
    if (ThreeDigitNumber == FirstHalf)
    {
     Console.WriteLine($"  Number {AnyNumber} is a palindrome");
    }
     else
     {
        Console.WriteLine($"  Number {AnyNumber} is not a palindrome");
     }
      

