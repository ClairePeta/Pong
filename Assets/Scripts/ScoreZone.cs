using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Ball"){
            Debug.Log("collided with ball at " + this.gameObject.name);
            GameManager.incrementScore(this.gameObject.name);
            //award the other player/AI a point
            //reset the ball to center
            //start another roung

        }     
    }  
}
