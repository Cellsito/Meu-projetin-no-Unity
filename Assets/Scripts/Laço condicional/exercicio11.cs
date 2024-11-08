using UnityEngine;
using static UnityEditor.Progress;

public class exercicio11 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] bool NPC ;
    int NPCF ;
    void Start()
    {
        NPCF = Random.Range(1, 5);

        if (NPC == true)
        {
            switch (NPCF)
            {
                case 1:
                    print("Cuidado onde pisa, forasteiro... esta terra tem olhos em cada canto.");

                    break;

                case 2:
                    print("Ah, você é aquele que dizem ter enfrentado as bestas das montanhas... Não parece tão impressionante assim. ");

                    break;

                case 3:
                    print("Se precisar de informações, procure o velho na taverna. Ele tem mais segredos do que o próprio vento.");

                    break;

                case 4:
                    print("Não entendo por que as pessoas insistem em lutar. O verdadeiro poder está em controlar o que os outros não sabem.");

                    break;

                case 5:
                    print("Ao se defender com isso, nada irá te ferir ");

                    break;

                default:

                    break;
            }


        }
        else
        {
            print("Não vai falar nada não??");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
