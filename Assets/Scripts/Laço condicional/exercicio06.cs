using UnityEngine;

public class exercicio06 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] bool Guerreiro;
    [SerializeField] bool Mago;
    void Start()
    {
        if (Guerreiro == true && Mago == false) 
        {
            print("Guerreiro escolhido");
        }

        else if (Guerreiro == false && Mago == true)
        {
            print("Mago escolhido");
        }

        else if (Guerreiro == true && Mago == true)
        {
            print("Não pode escolher os Dois");
        }
        else
        {
            print("https://www.youtube.com/watch?v=LMaG_uOa440");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
