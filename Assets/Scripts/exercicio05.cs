using UnityEngine;

public class exercicio05 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] int PontosDaMissão = 0;
    void Start()
    {
        if (PontosDaMissão > 50)
        {
            print("Missão bem-sucedida");
        }
        else
        {
            print("Missão incompleta");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
