using UnityEngine;

public class exercicio3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    int fase = 1;
    int moedas = 0;

    void Start()
    {
        while (fase <= 10)
        {
            //print(fase);
            moedas += 3;
            fase++;
        }
        print("Você tem " + moedas + " moedas");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
