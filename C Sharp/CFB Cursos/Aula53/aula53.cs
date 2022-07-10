using System;
class Aula53{
    static void Main(){
        float area=0;
        /*int n1,n2,res;
        res=n1=n2=0;

        n1=10;
        n2=0;*/
        
        try{
            area=Area.Quad(0,5);
            Console.WriteLine("Area do quad.:{0}",area);
           /* res=n1/n2;
            Console.WriteLine("{0}/{1}={2}",n1,n2,res);
            throw new Exception("Genisis");*/
        }catch(Exception e){
            Console.WriteLine("Erro: {0}",e.Message);
            Console.WriteLine("Tipo: {0}",e.GetType());
        }finally{
            Console.WriteLine("Fim do Programa");
        }


    }

    class Area{
        public static float Quad(float bas, float alt){
            if(bas==0 || alt==0){
                throw new Exception("Base ou altura não informada ou infomada zerada");
            }
            return bas*alt;
        }
    }
}