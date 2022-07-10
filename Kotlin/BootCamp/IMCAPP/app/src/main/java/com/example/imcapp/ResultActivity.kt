package com.example.imcapp

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.util.Log

class ResultActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_result)
        Log.w( "Lifecycle", "Entrei no CREATE - estou criando a tela" )
    }

    override fun onStart(){
        super.onStart()
        Log.w("Lifecycle", "entrei no START - deixei a tela visivel para voce")
    }

    override fun onResume(){
        super.onResume()
        Log.w("Lifecycle", "entrei no RESUME - agora voce pode interagir com a tela")
    }

    override fun onPause(){
        super.onPause()
        Log.w("Lifecycle", "PAUSE - a tela perdeu o foco, voce não pode mais interagir")
    }

    override fun onStop(){
        super.onStop()
        Log.w("Lifecycle", "STOP - a tela não está mais visível mas ainda existe")
    }

    override fun onRestart(){
        super.onRestart()
        Log.w("Lifecycle", "entrei no RESTART - a tela está voltando a ser o foco")
    }

    override fun onDestroy(){
        super.onDestroy()
        Log.w("Lifecycle", "entrei no DESTROY - a tela foi destruida")
    }
}