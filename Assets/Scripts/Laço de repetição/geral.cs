using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class LacosDeRepeticao : MonoBehaviour
{
    //For - Utilizado quando se sabe a quantidade de repeti��es

    //While ou DoWhile - � utilizado quando n�o se sabe a qtd. de repeti��es

    //Foreach - Quando tem uma lista que para cada elemento que fazer uma opera��o

    //Array - lista

    // Start is called before the first frame update

    int x = 0;
    int y = 0;


    void Start()
    {
        //for (int i = 0; i <= 10; i++)
        //if (i == 5)
        //{
        //    break;
        //}

        //if (i == 6)
        //{
        //    continue;
        //}

        //while (x <= 10) 
        //{
        //    print(x);
        //    x++;
        //}

        //do
        //{
        //    print(y);
        //    y--;
        //}
        //while (y >= 0);

        int[] num = { 10, 20, 30, 40, 50, 60, 70, 80 };

        //print(num[3]);
        //num[0]++;

        //print(num[0]);

        //string[] nomes;

        //nomes = new string[5];
        //nomes[0] = "Tadola";

        //print(nomes[1]); //nullz

        //print(i);

        //--------------------------------------------------------------------------

        //Criando uma lista
        List<int> nums = new List<int>();


        //Adiciona elementos � lista de nums
        nums.Add(1);  //Ind�ce 0
        nums.Add(2);  //Ind�ce 1
        nums.Add(3);  //Ind�ce 2
        nums.Add(4);  //Ind�ce 3
        nums.Add(5);
        nums.Add(6);
        nums.Add(7);
        nums.Add(8);  //Ind�ce 7

        //Remove o primeiro valor '4' encontrado na lista (ind�ce 3)
        nums.Remove(4);

        //Ordena os elementos da lista em ordem crescente
        nums.Sort();

        nums.Reverse();

        nums.IndexOf(1);


    }

    // Update is called once per frame
    void Update()
    {

    }
}
