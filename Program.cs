//Натуральные числа в промежутке от 1 до N

// int n = 8;
// System.Console.WriteLine(Real(n));
// string Real(int num)
// {
//     if (num == 1)
//         return num.ToString();
//     return Real(num - 1) + num.ToString();
// }



//Натуральные числа в промежутке от M до N

// int m = 3;
// int num = 8;
// System.Console.WriteLine(Real(m , num));
// string Real(int m , int num)
// {
//     if (num == m)
//         return num.ToString();
//     return Real(m ,num - 1) + num.ToString();
// }

////

// int m = 8;
// int num = 3;
// System.Console.WriteLine(Real(m, num));
// string Real(int m, int num)
// {
//     int a = -1;
//     if (m > num) a = 1;
//     if (num == m)
//         return num.ToString();
//     return Real(m, num + a) + num.ToString();
// }


//на вход число и возвращать сумму его цифр

// int num = 123;
// System.Console.WriteLine(Sum(num));
// Sum(num);
// int Sum(int num)
// {
//     if (num == 0)
//         return num;
//     return Sum(num / 10) + num % 10;
// }

//возводим число А в степень В

int a = 2;
int b = 4;
System.Console.WriteLine(Pow(a, b));

int Pow(int a, int b)
{
    if (b == 0)
        return 1;
    return a * Pow(a, b - 1);
}






