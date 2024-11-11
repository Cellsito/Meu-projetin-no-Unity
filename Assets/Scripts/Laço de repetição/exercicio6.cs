using UnityEngine;

public class exercicio6 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created



    [SerializeField] float n;

    void Start()
    {


        print(n);

        if (n % 5 == 0 && n % 3 == 0)
        {
            print("Fizz Buzz");
        }
        else if (n % 3 == 0)
        {
            print("Fizz");
        }
        else if (n % 5 == 0)
        {
            print("Buzz");
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
