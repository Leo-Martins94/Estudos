using System;
class Aula05{
    static void Main(){
        int res=(10+5)*3;
        bool resBol =10<5;
        int resIncre=10;
        resIncre++;//resIncre+=1;//resIncre+1;
        bool resAnd=(5>3)&(5<10);
        bool resOr=(5<6)|(8>9);
        Console.WriteLine(res);
        Console.WriteLine(resBol);
        Console.WriteLine(resIncre);
        Console.WriteLine(resAnd);
        Console.WriteLine(resOr);
    }
}