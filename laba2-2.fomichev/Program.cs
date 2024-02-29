Console.Write("Введите четырехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int product = 1;
int tempNumber = number;
while (tempNumber > 0)
{
    int digit = tempNumber % 10;
    product *= digit;
    tempNumber /= 10;
}

Console.WriteLine("Произведение цифр числа: " + product);

bool a = (product % 3 == 0);
bool b = (number % product == 0);

if (a)
{
    Console.WriteLine("Произведение цифр кратно трём");
}
else
{
    Console.WriteLine("Произведение цифр не кратно трём");
}

if (b)
{
    Console.WriteLine("Число кратно произведению его цифр");
}
else
{
    Console.WriteLine("Число не кратно произведению его цифр");
}