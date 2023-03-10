// Напишите программу, которая принимает на вход число и
// выдаёт сумму цифр в числе.

//452 -> 11
//82 -> 10
//9012 -> 12

Console.Clear();
Console.Write("Введите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());

  int Sum(int numN){
    
    int counter = Convert.ToString(numN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      advance = numN - numN % 10;
      result = result + (numN - advance);
      numN = numN / 10;
    }
   return result;
  }

int sum = Sum(numN);
Console.WriteLine($"Сумма цифр в числе: {sum}");