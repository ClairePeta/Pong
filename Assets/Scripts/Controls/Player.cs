using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public bool player1 = true;
    new Rigidbody2D rigidbody;
    [Range(1f, 10f)]
    public float speed = 5f;
    public TextMeshProUGUI scoreText;

    void Start(){
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update(){
        if (Input.GetKeyDown(KeyCode.Space)){ PongGlobal.paused = true; GameManager.instance.pause();} /*pause*/ 
        if (Input.GetKeyDown(KeyCode.Escape)){ SceneManager.LoadScene("Menu");} /*quit*/ 
        if(player1 && !PongGlobal.paused){
            scoreText.text = GameManager.PlayerOneScore.ToString();          
            var vel = rigidbody.velocity;
            if (Input.GetKey(KeyCode.UpArrow)) { vel.y = speed; }  /*move up*/ 
            else if (Input.GetKey(KeyCode.DownArrow)) { vel.y = -speed; } /*move down*/
            else { vel.y = 0; } /*stop moving*/
            rigidbody.velocity = vel;
        }else if(!player1 && !PongGlobal.paused){
            scoreText.text = GameManager.PlayerTwoScore.ToString();   
            var vel = rigidbody.velocity;
            if (Input.GetKey(KeyCode.W)) { vel.y = speed; }  /*move up*/ 
            else if (Input.GetKey(KeyCode.S)) { vel.y = -speed; } /*move down*/
            else { vel.y = 0; } /*stop moving*/
            rigidbody.velocity = vel;
        }
        Vector2 pos = (Vector2)transform.position;
        if (pos.y > 4.2f) { pos.y = 4.2f; } /*upper bounds*/
        else if (pos.y < -4.2f) { pos.y = -4.2f; } /*lower bounds*/
        transform.position = pos; 
    }
}
