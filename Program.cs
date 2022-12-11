// Task 41

void EnterNumbers()
{
    Console.WriteLine("Сколько чисел хотите ввести?");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[size];
    Console.WriteLine("Введите числа через кнопку 'Enter'");
    for (int i = 0; i < size; i++)
    {    
        numbers[i] = int.Parse(Console.ReadLine());
    }
    PositiveNumbers(numbers);
}

void PositiveNumbers(int[] nums)
{
    int counter = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] > 0)
        {
            counter++;
        }
    }
    Console.WriteLine("Положительных числел " + counter + " штук");
}
EnterNumbers();

// Task 43

void EnterCoeff()
{
    
    double[] y1 = new double[2];
    double[] y2 = new double[2]; 
    Console.WriteLine("Введите для уравнение первой прямой y = k1*x + b1 коэффициент k1");
    y1[0] = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите для уравнение первой прямой y = k1*x + b1 коэффициент b1");
    y1[1] = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите для уравнение второй прямой y = k2*x + b2 коэффициент k2");
    y2[0] = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите для уравнение второй прямой y = k2*x + b2 коэффициент b2");
    y2[1] = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine(y1[1]);
    double Intersection = (y2[1] - y1[1])/(y1[0] - y2[0]);
    Console.WriteLine("Точка пересечения двух прямых = " + Intersection);
    
}
EnterCoeff();