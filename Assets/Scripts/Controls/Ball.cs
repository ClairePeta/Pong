using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    new Rigidbody2D rigidbody;

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
            rigidbody.AddForce(new Vector2(20, -15));
        else
            rigidbody.AddForce(new Vector2(-20, -15));
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
