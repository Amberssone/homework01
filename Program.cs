string numbers = Console.ReadLine();

string[] numbersArray = numbers.Split(' ');

string number1 = numbersArray[0];
string number2 = numbersArray[1];
int number1Int = Int32.Parse(number1);
int number2Int = Int32.Parse(number2);

if (number1Int > number2Int) {
    Console.WriteLine(number1Int);
}
else {
    Console.WriteLine(number2Int);
}
