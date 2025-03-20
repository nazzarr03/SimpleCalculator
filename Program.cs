// See https://aka.ms/new-console-template for more information

Console.WriteLine("Birinci sayınızı giriniz : ");
double firstNumber = double.Parse(Console.ReadLine());
Console.WriteLine("İkinci sayınızı giriniz : ");
double secondNumber = double.Parse(Console.ReadLine());

char process;
double sonuc = 0.0;
bool validProcess = false;

do
{
    Console.Write("Yapmak istediğiniz işlemi seçin (+, -, *, /): ");
    process = char.Parse(Console.ReadLine());

    // if-else kullanımı
    if (process == '+')
    {
        sonuc = firstNumber + secondNumber;
        validProcess = true;
    } else if (process == '-')
    {
        sonuc = firstNumber - secondNumber;
    } else if (process == '*')
    {
        sonuc = firstNumber * secondNumber;
    } else if (process == '/')
    {
        if (secondNumber != 0)
        {
            sonuc = firstNumber / secondNumber;
            validProcess = true;
        }
        else
        {
            Console.WriteLine("Payda sıfır olamaz...");
            return;
        }
    } else
    {
        Console.WriteLine("Yanlış işlem girdiniz tekrar deneyiniz...");
    }
    
    // switch-case kullanımı
/*    switch (process)
    {
        case '+':
            sonuc = sonuc + firstNumber;
            validProcess = true;
            break;
        case '-':
            sonuc = sonuc - firstNumber;
            validProcess = true;
            break;
        case '*':
            sonuc = sonuc * firstNumber;
            validProcess = true;
            break;
        case '/':
            if (secondNumber == 0)
            {
                Console.WriteLine("Payda sıfır olamaz...");
                return;
            }
            sonuc = firstNumber / secondNumber;
            validProcess = true;
            break;
        default:
            Console.WriteLine("Yanlış işlem girdiniz tekrar deneyiniz...");
            break;
    } */
    
} while (!validProcess);

Console.WriteLine("İşlem sonucunuz : " + sonuc);

