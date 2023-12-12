
int validVal()
{

    int inputSize = 0;
    bool validSize = false;
    Console.Write("\nEnter correct value for figure param: ");
    while (!validSize)
    {

        if (int.TryParse(Console.ReadLine(), out inputSize) && inputSize >= 1)
        {
            validSize = true;
        }
        else
            Console.Write("You entered incorrect value! Try again!");
    }

    return inputSize;
}

void renderSquare()
{
    int side = validVal();
    Console.WriteLine("Square\n");
    for (int i = 0; i < side; i++)
    {
        for (int j = 0; j < side; j++)
        {
            if (i == 0 || j == 0 || j == side - 1 || i == side - 1)
                Console.Write("*");
            else
                Console.Write(" ");
        }
        Console.WriteLine();
    }
}


void renderCirc()
{
    int radius = validVal();
   
    Console.WriteLine("\nCircle\n");
    for (int i = -radius; i <= radius; i++)
    {
        for (int j = -radius; j <= radius; j++)
        {
            float dist = i * i + j * j;
            if (dist <= radius * radius)
            {
                Console.Write("*");

            }

            else
                Console.Write(" ");
        }
        Console.WriteLine();
       
    }
}

void renderTriangle()
{
    int side = validVal();
    Console.WriteLine("\nTriangle\n");
    for (int i = 0; i < side; i++)
    {
        int tmp = side;
        for (int j = 0; j < side; j++)
        {
            
            if (j == i || j == 0 || i == side -1 )
            {
                Console.Write("*");
               
            }
              
            else
                Console.Write(" ");
        }
        Console.WriteLine();
        tmp--;
    }
}

renderSquare();
renderTriangle();
renderCirc();
