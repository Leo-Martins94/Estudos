package com.example.vmodel

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import android.widget.Toast
import androidx.lifecycle.Observer
import androidx.lifecycle.ViewModelProvider

class MainActivity : AppCompatActivity() {

    lateinit var MainViewModel: MainViewModel

    lateinit var txtNome: EditText
    lateinit var btnDados: Button
    lateinit var btnMostrar: Button


    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        initDados()
        initClick()
    }

    private fun initDados(){

        MainViewModel = ViewModelProvider(this).get(com.example.vmodel.MainViewModel::class.java)

        txtNome = findViewById(R.id.txtContador)
        btnDados = findViewById(R.id.btnDados)
        btnMostrar = findViewById((R.id.btnMostrar))

        MainViewModel.mContador.observe(this, Observer { valor ->
            txtNome.setText(valor)
        })

    }

    private fun initClick(){
        btnDados.setOnClickListener {
         MainViewModel.Contador()

        }

        btnMostrar.setOnClickListener {
            Toast.makeText( applicationContext, "Valor Contador ${MainViewModel.mContador.value}", Toast.LENGTH_SHORT).show()
        }

    }



}