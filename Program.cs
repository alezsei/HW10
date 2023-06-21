int InText(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void ShowNum(int m, int n)
{
    if (m > n) return;
    if (m % 3 ==0)
    {
        Console.WriteLine(m);
    }
    m++;
    ShowNum(m,n);

}
int SumNum(int m, int n,int sum = 0)
{
    if (m > n) 
    {
        return sum;
    }
    sum += m;
    m++;
    return SumNum(m,n,sum);
    
}
int Accerman(int m, int n)
{
    if (m == 0) return n+1;
    if (m != 0 && n==0) return Accerman(m-1,1);
    if (m > 0 && n > 0) return Accerman(m-1,Accerman(m,n-1));
    Console.WriteLine (Accerman(m,n));
    return (Accerman(m,n));
    
}
void Task64()
{
    int m = InText("Введите  стартовое число");
    int n = InText("Введите конечное число");
    ShowNum(m,n);
}
void Task66()
{
    int m = InText("Введите  стартовое число");
    int n = InText("Введите конечное число");
    Console.WriteLine($"Сумма чисел от {m} до {n} равна {SumNum(m,n)}");
}
void Task68()
{
    int m = InText("Введите  число m функции А(m,n) ");
    int n = InText("Введите  числ n функции А(m,n)");
    Console.WriteLine($"A({m},{n})равна {Accerman(m,n)}");
}
Task64();
Task66();
Task68();