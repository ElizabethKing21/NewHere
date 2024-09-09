class Cake
{
    public void Modulus(int a, int b, int q, int r)
    {
        double tree = (a * 1.0) / (b * 1.0);
        int tree1 = a / b;
        double tree3 = tree / (tree1 * 1.0);
        tree3 = tree3 / tree3;
        if (tree3 == 1 && (q * b + r == a) && 0 <= r && r < b) 
        {
            Console.WriteLine("Modulus"); 
        }
        else
        {
            Console.WriteLine("Not modulus");
        }

    }

    public string Caesar(string word)
    {
        char[] bet = { 'a' , 'b' , 'c' , 'd' , 'e' , 'f' , 'g' , 'h' , 'i' , 'j' , 'k' , 'l' , 'm' , 'n' , 'o' , 'p' , 'q' , 'r', 's' , 't' , 'u' , 'v' , 'w' , 'x' , 'y' , 'z'};
        string letter = "";
        for (int i = 0; i < word.Length; i++)
        {
            int x = 0;
            while (bet[x] != word[i])
            {
                x++;
            }
            if (x == 0)
            {
                letter = letter + 'x';
            }
            else if (x == 1)
            {
                letter = letter + 'y';
            }
            else if (x == 2)
            {
                letter = letter + 'z';
            }
            else
            {
                x = x - 3;
                letter = letter + bet[x];
            }
        }
        return letter;
    }
    
    public int Euclidean(int a, int b)
    {
        int c = 0;
        int number = 0;
        if (a > b)
        {
            c = b;
        }
        else {
            c = a;
        }
        if (c > 0) {
            while (c >= 0)
            {
                if (a % c == 0 && b % c == 0)
                {
                    number = c;
                    break;
                }
                c = c - 1;
            }
        }
        else if (c < 0)
        {
            while (c <= 0)
            {
                if (a % c == 0 && b % c == 0)
                {
                    number = c * (-1);
                    break;
                }
                c = c + 1;
            }
        }
        return number;
    }
    public static void Main(string[] args)
    {
        Cake cake = new Cake();
        Console.WriteLine(cake.Euclidean(8, 16));
    }
}