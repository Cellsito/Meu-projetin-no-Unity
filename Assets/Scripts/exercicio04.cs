using UnityEngine;

public class exercicio04 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    [SerializeField] bool Po��oDeVida;
    void Start()
    {
        if(Po��oDeVida == true)
        {
            print("Usando Po��o de Vida");
        }
        else
        {
            print("Po��o indispon�vel");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
