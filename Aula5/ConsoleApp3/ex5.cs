using System;

class Program
{
    static void Main()
    {
        int horasPorDia;
        int totalHorasSemana = 0;

        Console.WriteLine("Insira o número de horas de treinamento por dia (de segunda a sexta): ");
        horasPorDia = int.Parse(Console.ReadLine());

        for (int dia = 1; dia <= 5; dia++)
        {
            totalHorasSemana += horasPorDia;
        }

        int totalHorasNecessarias = 1000;
        int diasNecessarios = (totalHorasNecessarias + totalHorasSemana - 1) / totalHorasSemana * 5; 
        int semanasNecessarias = (diasNecessarios + 4) / 5;
        double mesesNecessarios = semanasNecessarias / 4.5;

        Console.WriteLine("Total de horas de treinamento em uma semana (de segunda a sexta): " + totalHorasSemana);
        Console.WriteLine("Dias necessários para alcançar 1000 horas de treinamento: " + diasNecessarios);
        Console.WriteLine("Semanas necessárias para alcançar 1000 horas de treinamento: " + semanasNecessarias);
        Console.WriteLine("Meses necessários para alcançar 1000 horas de treinamento: " + (int)mesesNecessarios);
    }
}