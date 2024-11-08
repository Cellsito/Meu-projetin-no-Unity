using UnityEngine;

public class exercicio02 : MonoBehaviour
{

    [SerializeField] bool powerUp;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (powerUp == false)
        {
            print("Nenhum Power-Up encontrado");
        }
        else
        {
            print("Power-Up coletado");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
