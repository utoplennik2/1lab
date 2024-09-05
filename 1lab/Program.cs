 
    class Num                                   // КЛАС НАМБЕР
{ 
    private int a;                              // число яке працює в межах класу    
    public Num(int value)                       //конструктор з параметрами
    {
        a = value;
    }
    public bool Correct()                       //лог метод КОРЕКТ чи є натуральним
    {
        return a > 0;
    }


     public bool Prime()                        //ПРАЙМ чи є простим
    {
        if (a <= 1) return false;               
        for (int i = 2; i <= Math.Sqrt(a); i++)  
        {
            if (a % i == 0) return false;       //  если а делится на i НЕ ПРОСТЕ ЧИОЛСОО
        }
        return true;                            //просте якщо все ок

    }


    public bool Palindrome()
    {
        string str = a.ToString();               //строка
        int left = 0;                            //а скіко з кожної строки символів
        int right = str.Length - 1;
        while (left < right)
        {
            if (str[left] != str[right])         //якщо символи не збігаються фолс
            {
                return false;
            }
            left++;                              //
            right--;
        }
        return true;
    }
    public void Print()                          //  принт
    {
        Console.WriteLine("вашк число = " + a);
    }
}

    class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("введiть, будь ласка, НАТУРАЛЬНЕ число =  ");
            int inputNum = int.Parse(Console.ReadLine());
            Num numb = new Num(inputNum);        //консуттуктор
            numb.Print(); 
            if (numb.Correct())
            {
                Console.WriteLine("число просте =" + numb.Prime());
                Console.WriteLine("число є палiндромом = " + numb.Palindrome());
            }
            else
            {
                Console.WriteLine("ваше число не НАТУРАЛЬНЕ (не 0 i не вiд'ємне) :(");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("щось сталося..." + ex.Message);
        }
    }
}
