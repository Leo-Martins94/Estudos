<?php

    /*class Caneta{
        public $modelo;
        var $cor;
        private $ponta;
        protected $carga;
        private $tampada;

        public function rabiscar(){
            if($this -> tampada == true){
                echo "<p><b>A caneta está tampada, destampe para rabiscar</b></p>";
            }else{
                echo "<p>Rabisco</p>";
            }
            
        }

        public function tampar(){
            $this -> tampada = true;
        }

        public function destampar(){
            $this -> tampada = false;
        }
        
    }*/

    class Caneta {
        public $modelo;
        private $ponta;

        public function getModelo(){
            return $this -> modelo;
        }

        public function setModelo($m){
            $this -> modelo = $m;
        }

        public function getPonta(){
            return $this -> ponta;
        }

        public function setPonta($p){
            $this -> ponta = $ponta;
        }
    }

?>