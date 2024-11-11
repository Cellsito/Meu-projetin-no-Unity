using System.Collections.Generic;
using UnityEngine;

public class exercicio7 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    List<int> numeros = new List<int> { 13, 48, 9, 12, 27, 32 };


    void Start()
    {

        int maior = numeros[0];

        foreach (int numero in numeros)
        {
            if (numero > maior)
            {
                maior = numero;
            }


        }
            print("O maior valor é: " + maior);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
