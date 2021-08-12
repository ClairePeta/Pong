using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Ball"){
            //Debug.Log("collided with ball at " + this.gameObject.name);
            //award the other player/AI a point and start another round
            GameManager.IncrementScore(this.gameObject.name);
            other.gameObject.GetComponent<Ball>().RestartGame();
        }     
    }  
}
