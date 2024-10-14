using System.IO.Compression;
using DesafioPOO.Models;

class program 
{
    static void Main (string[] args)
    
    {
           
        

           Console.WriteLine("Smartphone Iphone:");
           Smartphone Iphone = new Iphone("096574", "Iphone 15 pro", "2367819457", 516);
           Iphone.Ligar();
           Iphone.InstalarAplicativo("Telegram");
             

             Console.WriteLine();

          
           Console.WriteLine("Smartphone Nokia:");      
           Smartphone Nokia = new Nokia ("347699", "Nokia modelo C01 Plus", "9835012757", 32);
           Nokia.ReceberLigacao();
           Nokia.InstalarAplicativo("Instagram");




    }

}















// TODO: Realizar os testes com as classes Nokia e Iphone