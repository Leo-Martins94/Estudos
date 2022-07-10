package com.example.bootcampuxkotlin

import android.os.Bundle

class DetailActivity {
    private var contact: Contact? = null

    fun onCreate(savedInstanceState: Bundle?){
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_contact_detail)
        getExtra()
        bindViews()
    }
    private fun getExtra(){
       contact = intent.getParcelableExtra(EXTRA_CONTACT)
    }

    private fun bindViews(){
        findViewByID<TextView>(R.id.tv_name).text = contact?.name
        findViewById<TextView>(R.id.tv_phone).text = contact?.phone
    }
    companion object{
        const val  EXTRA_CONTACT: String = "EXTRA_CONTACT"
    }
}
