using System;

namespace Calc1{
    class Area{
        public float Quad(float bas, float alt){
            if(bas==0 || alt == 0){
                throw new Exception("Base ou altura não informada corretamente");
            }
            return bas*alt;
        }
    }
}

namespace Calc2{
    class Area{
        public float Quad(float bas, float alt){
            if(bas==0 || alt == 0){
                throw new Exception("Base ou altura não informada corretamente");
            }
            return bas*alt;
        }
    }
}

class Aula54{
    static void Main(){
        float area=0;

        try{
            area=Calc1.Area.Quad(4,4);
            Console.WriteLine("Area do quadrado: {0}",area);
        }catch(Exception e){
            Console.WriteLine("Erro: {0}", e.Message);
        }finally{
            Console.WriteLine("Fim do processo");
        }

    }
}


