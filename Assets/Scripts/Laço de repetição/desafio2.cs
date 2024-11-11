using System;
using UnityEngine;

public class desafio2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] int diaNascimento;
    [SerializeField] int mesNascimento;
    [SerializeField] int anoNascimento;

    void Start()
    {
        CalcularTempoVivido(diaNascimento, mesNascimento, anoNascimento);
    }

    void CalcularTempoVivido(int dia, int mes, int ano)
    {
        DateTime dataNascimento = new DateTime(ano, mes, dia);
        DateTime dataAtual = DateTime.Now;

        int diasTotais = (int)(dataAtual - dataNascimento).TotalDays;

        int anos = 0;
        int meses = 0;

        // Subtrair anos completos
        while (diasTotais >= 365)
        {
            diasTotais -= 365;
            anos++;
        }

        // Subtrair meses completos
        while (diasTotais >= 30)
        {
            diasTotais -= 30;
            meses++;
        }

        int dias = diasTotais;

        Debug.Log("Você viveu " +anos+ " anos, " +meses+ " meses e " +dias+ " dias.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
