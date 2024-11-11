using UnityEngine;

public class desafio1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] string palavra = "";
    int verificacao;
    string letras;

    void Start()
    {
        for (int i = 0; i < palavra.Length; i++)
        {
            letras += palavra[i];
            if (letras != "a" & letras != "e" & letras != "i" & letras != "o" & letras != "u")
            {
                verificacao++;
                letras = "";
            }
            else
            {
                letras = "";
            }
        }
        print("A palavra "+ palavra + " tem " + verificacao + " consoante(s)");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
