package com.example.bootcampuxkotlin

import android.content.Context
import android.content.Intent
import android.content.SharedPreferences
import android.os.Bundle
import android.os.Message
import com.google.android.material.floatingactionbutton.FloatingActionButton
import com.google.android.material.snackbar.Snackbar
import androidx.appcompat.app.AppCompatActivity
import android.view.Menu
import android.view.MenuInflater
import android.view.MenuItem
import android.view.View
import android.widget.Toast
import android.widget.Toolbar
import androidx.appcompat.app.ActionBarDrawerToggle
import androidx.core.content.edit
import androidx.drawerlayout.widget.DrawerLayout
import androidx.recyclerview.widget.LinearLayoutManager
import androidx.recyclerview.widget.RecyclerView
import com.example.bootcampuxkotlin.DetailActivity.Companion.EXTRA_CONTACT

class MainActivity : AppCompatActivity(), ClickItemListener {

    private val rvList: RecyclerView by lazy {
        findViewById<RecyclerView>(R.id.rv_list)
    }
    private val adapter = ContactAdaptor(this)

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        initDrawer()
        fetchListContact()
        bindViews()
        updateList()

    }

    private fun fetchListContact(){
        val list = arrayListOf(
            Contact(
                "Leonardo Martins",
                "(11)932034949",
                "img.png"
            )
        )

        getInstanceSharedPreference().edit {
            putString("constacts", Gson().toJson(list))
        }
    }

    private fun getInstanceSharedPreference(): SharedPreferences{
        return getSharedPreferences("br.com.bootcampuxkotlin.PREFERENCES", Context.MODE_PRIVATE)
    }

    private fun  initDrawer(){
        val drawerLayout = findViewById<View>(R.id.drawer_layout) as DrawerLayout
        val toolbar = findViewById<Toolbar>(R.id.toolbar)
        //setSupportActionBar(toolbar)

        val toggle = ActionBarDrawerToggle(this, drawerLayout, R.string.open_drawer, R.string.close_drawer)
        drawerLayout.addDrawerListener(toggle)
        toggle.syncState()
    }
    private fun  bindViews(){
        rvList.adapter = adapter
        rvList.layoutManager = LinearLayoutManager(this)
    }

    private fun getListContacts(): List<Contact>{
        val list = getInstanceSharedPreference().getString("contacts", "[]")
        val turnsType = object : TypeToken<List<Contact>>(){}.type
        return Gson().fromJson(list, turnsType)
    }

    private fun updateList(){
        adapter.updateList(getListContacts())
    }

    private fun showToast(message: String){
        Toast.makeText(this,message, Toast.LENGTH_SHORT).show()
    }
    override fun onCreateOptionsMenu(menu: Menu?): Boolean {
        val inflater: MenuInflater = menuInflater
        inflater.inflate(R.menu.menu, menu)
        return true
    }

    override fun onOptionsItemSelected(item: MenuItem): Boolean {
        return when(item.itemId) {
            R.id.item_menu_1 ->{
                showToast("Menu 1")
                return true
            }
            R.id.item_menu_2 ->{
                showToast("Menu 2")
                return true
            }else -> super.onOptionsItemSelected(item)

        }        }

    override fun clickItemContact(contact: Contact) {
        val intent = Intent(this, DetailActivity::class.java)
        intent.putExtra(EXTRA_CONTACT, contact)
        startActivity(intent)
    }

}


