using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    //players score stored here
    public static int PlayerOneScore = 0;
    public static int PlayerTwoScore = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public static void incrementScore(string hitside){
        if(hitside == "ScoreCollider-Right")
            PlayerTwoScore++;
        else
            PlayerOneScore++;
    }

    void Update(){
        //check game state - did someone win
        if(PlayerOneScore > 10){
            //player one won
        }else{
            //player two won
        }
        //if someone won display game over and reset

    }
}
