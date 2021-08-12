using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    new Rigidbody2D rigidbody;
    public new AudioSource audio;
    Vector2 velocity;
    bool saved = false;
    float startspeed = 10f;

 
    void Start(){
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = Vector2.right * startspeed;
        //wait two second before shooting the ball
        //Invoke("BeginRound", 2.0f);
    }
    void BeginRound(){
        float randomValue = Random.value;
        if(randomValue >= 0.5f)
            rigidbody.velocity = Vector2.right * startspeed;
            //rigidbody.AddForce(new Vector2(20, -15));
        else
            rigidbody.velocity = Vector2.left * startspeed;
            //rigidbody.AddForce(new Vector2(-20, -15));
    }
    public void RestartGame(){
        rigidbody.velocity = new Vector2(0, 0);
        transform.position = Vector2.zero;
        Invoke("BeginRound", 1.5f);
    }
    void Update(){
        if(PongGlobal.paused && !saved){
            velocity = rigidbody.velocity;
            rigidbody.velocity = Vector2.zero;
            saved = true;
        }
        if(!PongGlobal.paused && saved){
            saved = false;
            rigidbody.velocity = velocity;
        }
    }
    void OnCollisionEnter2D (Collision2D coll) {
        if(coll.collider.CompareTag("Player")){
            if(PongGlobal.effectVolume)
                audio.Play();
            Vector2 vel;
            vel.x = rigidbody.velocity.x;
            vel.y = (rigidbody.velocity.y / 2) + (coll.collider.attachedRigidbody.velocity.y / 3);
            rigidbody.velocity = vel * 1.025f;
        }      
    }
}
