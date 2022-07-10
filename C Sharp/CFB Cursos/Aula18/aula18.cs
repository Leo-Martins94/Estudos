using System;
class Aula18{
    static void Main(){
         int[,] n = new int[3,5];
         n[0,0]=10;
         n[0,1]=35;
         n[0,2]=40;
         n[0,3]=50;
         n[0,4]=35;
         n[1,0]=35;
         n[1,1]=37;
         n[1,2]=44;
         n[1,3]=57;
         n[1,4]=98;
         n[2,0]=65;
         n[2,1]=69;
         n[2,2]=67;
         n[2,3]=18;
         n[2,4]=3;            

         Console.WriteLine(n[0,2]);
    }
}