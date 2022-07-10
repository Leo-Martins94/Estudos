package com.example.notification

import android.app.Service
import android.content.Intent
import android.os.IBinder
import android.os.Message
import android.util.Log

class MyFirebaseMessagingService : FirebaseMessagingService() {

   private val tag = "FirebaseMessagingServ"

    override fun onMessageReceived(remoteMessage: RemoteMessage) {
        Log.i(tag, remoteMessage.from.toString())

        if (remoteMessage.notification != null){
            this.showNotification("1234", remoteMessage.notification?.title.toString(),
            remoteMessage.notification?.body.toString())
        }

    }
}