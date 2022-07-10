package com.example.notification

import android.app.Service
import android.content.Intent
import android.os.IBinder

class MyFirebaseInstanceIdService :  FirebaseInstanceIdService(){

    override fun onTokenRefresh(intent: Intent): IBinder {
        Log.i("**newTokenService", FirebaseInstanceId.getInstance().token.toString())
    }
}