using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    new Rigidbody2D rigidbody;
    public new AudioSource audio;
    Vector2 savedVelocity;
    bool saved = false;
    float startspeed = 10f;

 
    void Start(){
        rigidbody = GetComponent<Rigidbody2D>();
        //wait two second before shooting the ball
        Invoke("BeginRound", 1.5f);
    }
    void BeginRound(){
        float randomValue = Random.value;
        float randx = Random.Range(0.3f, 1.0f);
        float randy = Random.Range(-1f, 1.0f);
        if(randomValue >= 0.5f)
            rigidbody.velocity = new Vector2(randx, randy) * startspeed;
        else
            rigidbody.velocity = new Vector2(-randx, randy)  * startspeed;
    }
    public void RestartGame(){
        rigidbody.velocity = new Vector2(0, 0);
        transform.position = Vector2.zero;
        Invoke("BeginRound", 1.5f);
    }
    void Update(){
        if(PongGlobal.paused && !saved){
            savedVelocity = rigidbody.velocity;
            rigidbody.velocity = Vector2.zero;
            saved = true;
        }
        if(!PongGlobal.paused && saved){
            saved = false;
            rigidbody.velocity = savedVelocity;
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
