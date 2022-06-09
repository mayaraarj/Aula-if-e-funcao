﻿double cotacaoDoDolarHoje = 4.97;
const double VALOR_MINIMO_DE_COMPRA_EM_DOLAR = 100;
const double VALOR_MAXIMO_DE_COMPRA_EM_DOLAR = 2500;



string converterRealParaDolar(double valorDaCompraEmReais)
{
    double resultadoConversao;
    resultadoConversao = valorDaCompraEmReais / cotacaoDoDolarHoje;

    if (resultadoConversao < VALOR_MINIMO_DE_COMPRA_EM_DOLAR)
    {
        return "A compra mínima permitida é de $ 100,00.";
    }
    else if (resultadoConversao > VALOR_MAXIMO_DE_COMPRA_EM_DOLAR)
    {
        return "A compra máxima permitida é de $ 2500,00.";
    }
    else
    {
        return $"Você pode comprar  ${resultadoConversao}";
    }
}



Console.WriteLine(converterRealParaDolar(700));
