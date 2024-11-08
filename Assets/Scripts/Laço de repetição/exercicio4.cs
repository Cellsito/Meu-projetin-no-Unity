using UnityEngine;

public class exercicio4 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    int combo = 1;
    int ponto = 0;

    void Start()
    {
        while (combo <= 7)
        {
            ponto += 10;
            print(ponto);
            combo++;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
