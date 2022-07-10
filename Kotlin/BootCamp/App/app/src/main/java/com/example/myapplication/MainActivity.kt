package com.example.myapplication

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import kotlin.android.synthetic.main.activvity_main.*
class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        val btCalcular: Button = calcular
        val resultado = resultado

        btCalcular.setOnClickListener {
            val nota1 = Integer.parseInt(nota1.text.toStrintg())
            val nota2 = Integer.parseInt(nota2.text.toStrintg())
            val falta = Integer.parseInt(falta.text.toStrintg())

            val media = (nota1 + nota2) / 2

            if(media >= 6 && falta <=10){
                resultado.setText(
                        "Aluno Aprovado" + "\n" + "Nota final:$media" + "\n" + "Faltas: $falta"
                )
            }else{
                "Aluno Reprovado" + "\n" + "Nota final:$media" + "\n" + "Faltas: $falta"
            }
        }
    }
}