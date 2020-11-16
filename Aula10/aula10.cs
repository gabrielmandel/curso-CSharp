using System;  

class Aula10{

    enum DiasSemana{Domingo,Segunda,Terça,Quarta,Quinta,Sexta,Sábado};
    static void Main(){

        DiasSemana ds = DiasSemana.Domingo;
        Console.WriteLine(ds);

        DiasSemana ds1 = (DiasSemana)4;
        Console.WriteLine(ds1);

        int ds2 = (int)DiasSemana.Sábado;
        Console.WriteLine(ds2);
    }
}