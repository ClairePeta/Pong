using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    new Rigidbody2D rigidbody;
    Vector2 velocity;
    bool saved = false;

    //[Range(1f, 10f)]
     float speed = 15f;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = Vector2.right * speed;
        //wait two second before shooting the ball
        //Invoke("BeginRound", 2.0f);
    }
    void BeginRound(){
        float randomValue = Random.value;
        if(randomValue >= 0.5f)
            rigidbody.velocity = Vector2.right * speed;
            //rigidbody.AddForce(new Vector2(20, -15));
        else
            rigidbody.velocity = Vector2.left * speed;
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
            Vector2 vel;
            vel.x = rigidbody.velocity.x;
            vel.y = (rigidbody.velocity.y / 2) + (coll.collider.attachedRigidbody.velocity.y / 3);
            rigidbody.velocity = vel;
        }      
    }
}
