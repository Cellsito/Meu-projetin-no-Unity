using UnityEngine;

public class exercicio08 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] int dias;
    [SerializeField] int horas;
    [SerializeField] float segundos;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        segundos += Time.deltaTime;
        if (segundos >= 10)
        {
            horas+=1;
            segundos = 0;
        }
        else if (horas >= 24)
        {
            dias+=1;
            horas = 0;
        }
    }
}
