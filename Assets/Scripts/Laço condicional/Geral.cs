using UnityEngine;

public class Geral : MonoBehaviour
{
    /*
            Operadores relacionais

            == (igual)
            != (diferente)
            > (maior que)
            < (menor que)
            <= (menor igual)
            >= (maior igual)
    */

    //[SerializeField] int vidaHeroi = 100;
    //[SerializeField] int vidaVilao = 300;
    //string resultado;

    [SerializeField] int estadoVilao;


    void Start()
    {
        //print(vidaVilao == vidaHeroi); //false
        //print(vidaHeroi <= vidaVilao); //true
        //print(vidaVilao != vidaHeroi); //true

        //Operador ternário
        // condição ? valor a ser atribuido caso verdadeiro : caso falso
        //resultado = vidaHeroi < vidaVilao ? "Vida Heroi Menor" : "Vida Heroi Maior";

        //print(resultado);


        ////Estrutura condicional
        //if (vidaVilao > vidaHeroi)
        //{
        //    resultado = "Vida Heroi Menor";
        //    print(resultado);
        //    print("fraco");
        //}
        //else if (vidaVilao == vidaHeroi) 
        //{
        //    resultado = "Vida Heroi e Vilao igual";
        //    print(resultado);
        //    print("balanceado");
        //}
        //else
        //{
        //    resultado = "Vida Heroi Maior";
        //    print(resultado);
        //    print("forte");
        //}


        switch (estadoVilao)
        {
            case 1:
                print("Vilão atacando");
                if(true)
                {
                    print("Dano");
                }
                break;

            case 2:
                print("Vilão defende");
                break;

            case 3:
                print("Vilão tomando um coro");
                break;

            default:
                print("Valor n encontrado");
                break;
        }

    }


    void Update()
    {
        
    }

}
