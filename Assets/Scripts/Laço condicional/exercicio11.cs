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
                    print("Ah, voc� � aquele que dizem ter enfrentado as bestas das montanhas... N�o parece t�o impressionante assim. ");

                    break;

                case 3:
                    print("Se precisar de informa��es, procure o velho na taverna. Ele tem mais segredos do que o pr�prio vento.");

                    break;

                case 4:
                    print("N�o entendo por que as pessoas insistem em lutar. O verdadeiro poder est� em controlar o que os outros n�o sabem.");

                    break;

                case 5:
                    print("Ao se defender com isso, nada ir� te ferir ");

                    break;

                default:

                    break;
            }


        }
        else
        {
            print("N�o vai falar nada n�o??");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
