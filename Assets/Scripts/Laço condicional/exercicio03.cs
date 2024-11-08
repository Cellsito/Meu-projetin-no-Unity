using UnityEngine;

public class exercicio03 : MonoBehaviour
{
    [SerializeField] bool powerUp;

    [SerializeField] int vidaHeroi = 100;
    [SerializeField] int dano = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int cinquenta = vidaHeroi / 2;
        int batalha = vidaHeroi - dano;

        if (batalha <= 0 && powerUp == true)
        {
            int vida = 0 + cinquenta;
            print("Ainda não (Power-Up usado)");
            print("Vida restante:");
            print(vida);
        }
        else if (batalha > 0)
        {
            print("Ainda não");
            print("Vida restante:");
            print(batalha);
        }
        else
        {
            print("Game Over");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
