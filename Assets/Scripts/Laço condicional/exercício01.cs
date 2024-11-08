using UnityEngine;

public class exercício01 : MonoBehaviour
{

    [SerializeField] int vidaHeroi = 100;
    [SerializeField] int dano = 10;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int resultado = (vidaHeroi - dano);

        print("Heroi VS dano");

        if (resultado <= 0) 
        {
            print("Game Over");
        }
        else
        {
            print("Personagem Vivo");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
