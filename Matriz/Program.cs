using System;

class Program
{
    static void Main()
    {
        //Declara uma matriz 3x3
        int [,] matriz = new int[3,3];

        Console.WriteLine("Informe Nove elementos para a Matriz");

        for (int i = 0; i < matriz.GetLength(0); i++)//usado para ler linhas
        {
            for (int j = 0; j < matriz.GetLength(1); j++)//usado para ler colunas
            {
                Console.WriteLine("Informe o elemento: "+ i +"X" + j);
                matriz[i,j] = int.Parse(Console.ReadLine());
            }
        }


        /* 1) Faça um programa que preencha uma matriz de ordem 5 com números inteiros, calcule e mostre a quantidade de números negativos e a soma dos
         números positivos e valores primos desse vetor.*/
        //Declara uma matriz 5x5
        int[,] matriz5 = new int[5, 5];

        Console.WriteLine("Informe 25 elementos para a Matriz");

        for (int i = 0; i < 5; i++)//usado para ler linhas
        {
            for (int j = 0; j < 5; j++)//usado para ler colunas
            {
                Console.WriteLine("Informe o elemento: " + i + "X" + j);
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
        
        int qntdNumerosNegativos = 0;
        int somaDosNumeros = 0;
        for (int i = 0; i < 5; i++)//usado para ler linhas
        {
            for (int j = 0; j < 5; j++)//usado para ler colunas
            {
                //qntd de nums negativos
                if (i < 0 && j < 0)
                {
                    qntdNumerosNegativos+=2;
                }else if(i < 0 || j < 0)
                {
                    qntdNumerosNegativos++;
                }

                //´soma dos numeros negativos :)
                if (i > 0 && j > 0)
                {
                    somaDosNumeros += i + j;
                }else if(j > 0)
                {
                    somaDosNumeros += + j;
                }else if(i > 0)
                {
                    somaDosNumeros += +i;
                }

                if (i == j)
                {

                }
            }
        }


        //imprimindo a matriz
        Console.WriteLine("A matriz impressa: ");
        Console.WriteLine();

        for (int i = 0;i < 3; i++)
        {
            for(int j = 0;j < 3; j++)
            {
                Console.Write(" " + matriz[i, j]);
                
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        //imprimir os elementos da diagonal principal
        //indice de linha == indice de coluna
        Console.WriteLine("Imprimir elementos da diagonal principal: ");
        Console.WriteLine();
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if(i == j)
                {
                    Console.Write(" " + matriz[i, j]);

                }
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        //imprimir os elementos da diagonal secundária
        //indice de linha + indice de coluna == ordem da matriz - 1
        Console.WriteLine("Imprimir elementos da diagonal secundária: ");
        Console.WriteLine();
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (i + j == 2)
                {
                    Console.Write(" " + matriz[i, j]);

                }
            }
            Console.WriteLine();
        }
    }
}

