// Что есть рекурсия?
// Метод вызывает сам себя внутри этого же метода.
// Пример, факториал.
// 5! = 5*4*3*2*1
//     5*4!
//       4*3!
//         3*2! ...


double Factorial (int n)
{
    if (n == 1) return 1;
    else return n * Factorial(n-1);
}

for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
