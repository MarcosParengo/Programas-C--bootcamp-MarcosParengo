package me.nxsyed.presence

import android.support.v7.app.AppCompatActivity
import android.os.Bundle
import android.provider.Settings
import android.util.Log
import android.widget.TextView
import com.pubnub.api.PNConfiguration
import com.pubnub.api.PubNub
import java.util.*
import com.pubnub.api.models.consumer.PNStatus
import com.pubnub.api.models.consumer.presence.PNHereNowResult
import com.pubnub.api.callbacks.PNCallback
import com.pubnub.api.callbacks.SubscribeCallback
import com.pubnub.api.models.consumer.pubsub.PNMessageResult
import com.pubnub.api.models.consumer.pubsub.PNPresenceEventResult

class MainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        val occupancy = findViewById<TextView>(R.id.textOnline)

        val androidID = Settings.Secure.getString(this.contentResolver, Settings.Secure.ANDROID_ID)!!

        val pnConfiguration = PNConfiguration()
        pnConfiguration.subscribeKey = "sub-c-d312bfc0-f6a8-11e9-8dd7-ca99873d233c"
        pnConfiguration.publishKey = "pub-c-ab04fdd4-adc7-46a5-a67b-a41e3289d1e0"
        pnConfiguration.secretKey = "true"
        pnConfiguration.uuid = androidID
        val pubNub = PubNub(pnConfiguration)

        occupancy.text = "1"

        val subscribeCallback: SubscribeCallback = object : SubscribeCallback()  {
            override fun status(pubnub: PubNub, status: PNStatus) {

            }

            override fun message(pubnub: PubNub?, message: PNMessageResult?) {
                Log.d("message", message!!.message.toString())
            }
            override fun presence(pubnub: PubNub, presence: PNPresenceEventResult) {
                Log.d("presence", presence.toString())
                runOnUiThread {
                    occupancy.text = presence.occupancy.toString()
                }
            }
        }

        pubNub.run {
            addListener(subscribeCallback)
            subscribe()
                    .channels(Arrays.asList("whiteboard")) // subscribe to channels
                    .withPresence() // also subscribe to related presence information
                    .execute()
        }
    }
}
