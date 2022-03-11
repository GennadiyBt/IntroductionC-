// Задача 19

/*void Palindrom (int num)
{
    if(num/10000 == num%10)
    {
        int num1 = (num%10000)/10;
        if(num1/100 == num1%10)
        {
            Console.WriteLine("Данное число " + num + " является палиндромом.");
        }
        else
        {
            Console.WriteLine("Данное число " + num + " не является палиндромом.");
        }
    }
    else
    {
        Console.WriteLine("Данное число " + num + " не является палиндромом.");
    }
    
}

Console.WriteLine("Введите исследуемое число:");
int num = Convert.ToInt32(Console.ReadLine());
Palindrom(num);*/

// Задача 21

/*double Distanse(double xA, double yA, double zA, double xB, double yB, double zB)
{
    double Dis = Math.Sqrt(Math.Pow((xA-xB), 2) + Math.Pow((yA-yB), 2) + Math.Pow((zA-zB), 2));
    return Dis;
}

Console.WriteLine("Введите координаты точки А: ");
double xA = Convert.ToDouble(Console.ReadLine());
double yA = Convert.ToDouble(Console.ReadLine());
double zA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
double xB = Convert.ToDouble(Console.ReadLine());
double yB = Convert.ToDouble(Console.ReadLine());
double zB = Convert.ToDouble(Console.ReadLine());

double Dis = Distanse(xA, yA, zA, xB, yB, zB);

Console.WriteLine("Расстояние между точками А и В равно: " + Dis);
*/

//Задача 23

/*void CubeTab(int N)
{
    Console.Write(1);
    int n = 2;
    while(n < (N + 1))
    
    {
        Console.Write(", ");
        double Cube = Math.Pow(n, 3);
        Console.Write(Cube);
        n++;
    }
}

Console.WriteLine("Введите исследуемое число:");
int N = Convert.ToInt32(Console.ReadLine());

CubeTab(N);
*/








