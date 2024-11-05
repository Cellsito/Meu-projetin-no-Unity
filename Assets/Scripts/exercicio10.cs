using UnityEngine;

public class exercicio10 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] string Item;
    void Start()
    {
        switch (Item) 
        {
            case "Moeda" :
                print("EBA!! EU GOSTO DE DINHEIRO!!!");

                break;

            case "Poção de Vida":
                print("Então esse é o tal do 'Estus Flask'?? ");

                break;

            case "Poção de Magia":
                print("Recuperando sua esquiz-- digo.... Seus poderes ");

                break;

            case "Master Sword":
                print("HEEEEEYYAAAAA.....HAAAAAAA ");

                break;

            case "Velo de Ouro":
                print("Ao se defender com isso, nada irá te ferir ");

                break;

            default:
                print("Tua bolça ainda ta vazia viu!");

                break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
