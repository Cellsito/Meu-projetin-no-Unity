using UnityEngine;

public class exercicio09 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] int TimeA ;
    [SerializeField] int TimeB ;

    void Start()
    {
        if (TimeA > TimeB)
        {
            print("Vit�ria do Time A!");
        }
        else if (TimeB > TimeA)
        {
            print("V�t�ria do Time B!");
        }
        else if (TimeB == TimeA && TimeA > 3)
        {
            print("EMPATE EMOCIONANTE!!!");
        }
        else if (TimeB == TimeA)
        {
            print("Empate.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
