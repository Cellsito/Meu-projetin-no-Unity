using UnityEngine;

public class exercicio07 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] int Dado;
    int resultado;
    void Start()
    {
        resultado = Random.Range(1 , Dado);
        print(resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
