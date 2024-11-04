using UnityEngine;

public class exercicio04 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    [SerializeField] bool PoçãoDeVida;
    void Start()
    {
        if(PoçãoDeVida == true)
        {
            print("Usando Poção de Vida");
        }
        else
        {
            print("Poção indisponível");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
