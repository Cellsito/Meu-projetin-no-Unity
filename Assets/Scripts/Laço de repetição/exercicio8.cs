using System;
using UnityEngine;
using UnityEngine.InputSystem.Processors;

public class exercicio8 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Exemplo de string a ser invertida
    [SerializeField] string texto = "";

    void Start()
    {

        // Variável para armazenar a string invertida
        string textoInvertido = "";

        // Percorre a string do último caractere até o primeiro
        for (int i = texto.Length - 1; i >= 0; i--)
        {
            textoInvertido += texto[i];
        }

        // Exibe a string invertida
        print("String original: " + texto);
        print("String invertida: " + textoInvertido);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
