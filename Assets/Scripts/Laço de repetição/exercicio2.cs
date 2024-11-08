using UnityEngine;

public class exercicio2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    float dano = 1;
    int atk = 0;

    void Start()
    {
        while (atk < 5)
        {
            print(dano);
            dano += 2;
            atk++;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
