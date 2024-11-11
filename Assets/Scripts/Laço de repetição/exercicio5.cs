using UnityEngine;

public class exercicio5 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    int fase = 1;
    int dificuldade = 1;

    void Start()
    {
        while (fase <= 6)
        {
            //print(fase);
            print("Level: " + fase);
            print("Nível de Dificuldade: " + dificuldade );
            dificuldade += 5;
            fase++;
        }
       
    }

    // Update is called once per frame
    void Update()
    {

    }
}
