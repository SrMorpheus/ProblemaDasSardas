double[,] P = new double[100, 2];
int n;
double sum;

static void Memset(bool[] array, bool elem)
{
    int length = array.Length;
    if (length == 0) return;
    array[0] = elem;
    int count;
    for (count = 1; count <= length / 2; count *= 2)
        Array.Copy(array, 0, array, count, count);
    Array.Copy(array, 0, array, count, length - count);
}


void Dikjstra ()
{
    double ax, min;

    double[] dist = new double[100];
    bool[] intree = new bool[100];

    Memset(intree, false);
    for (int i = 0; i < 100; i++) dist[i] = 1000000.0;

    int v = 0;
    dist[0] = 0;
    sum = 0;

    while (!intree[v])
    {

        intree[v] = true;
        sum += dist[v];

        for (int i = 0; i < n; i++)
        {
            if (!intree[i])
            {

                ax = Math.Sqrt(Math.Pow(P[v, 0] - P[i, 0], 2) + Math.Pow(P[v, 1] - P[i, 1], 2));
                if (ax < dist[i]) dist[i] = ax;

            }


        }

        v = 0;
        min = 1000000.0;
       
        for (int i = 0; i < n; i ++)
        {
            if (!intree[i])
            {
                if (dist[i] <min)
                {
                    v = i;
                    min = dist[i];


                }


            }

        }


    }

    
    Console.WriteLine("Resultado é: " + sum.ToString("N3"));


}



//Teste
int T;
double a, b;

Console.Write("Coloque a quantidade que vai usar o programa: ");
T = int.Parse(Console.ReadLine());


for (int i = 0; i < T; i ++)
{
    Console.Write("Coloque o valor de n : ");
    n = int.Parse(Console.ReadLine());


    for (int j = 0; j < n; j++)
    {
        Console.Write("valor da primeira Coordenada: ");
        a = double.Parse(Console.ReadLine());
        Console.Write("valor da segunda Coordenada: ");
        b = double.Parse(Console.ReadLine());

        P[j,0] = a;
        P[j, 1] = b;

    }

    Console.WriteLine();

    Dikjstra();


}