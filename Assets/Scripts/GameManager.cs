using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public static int PlayerOneScore = 0;
    public static int PlayerTwoScore = 0;
    public GameOverScreen gameover;
    public GameObject pauseScreen;
    public GameObject countdownCanvas;
    new public Camera camera;
    public float bounds;
    
    void Start(){
        instance = this;
        bounds = (float)camera.orthographicSize - ((float)(camera.orthographicSize  / Screen.height)*80);
    }
    public static void IncrementScore(string hitside){
        if(hitside == "ScoreCollider-Right")
            PlayerTwoScore++;
        else
            PlayerOneScore++;
    }
    public void startResume(){
        pauseScreen.SetActive(false);
        StartCoroutine(ResumeGame(3));
    }
    private IEnumerator ResumeGame(float time)
    {
        countdownCanvas.SetActive(true);
        TextMeshProUGUI text = countdownCanvas.GetComponentInChildren<TextMeshProUGUI>();
        float elapsedTime = 0;

        //loops until time is up then toggles the canvas and resumes game
        while (elapsedTime / time < 1)
        {
            int counter = 3 - (int)elapsedTime;
            text.text = counter.ToString();
            yield return new WaitForEndOfFrame();
            elapsedTime += Time.deltaTime;
        }
        countdownCanvas.SetActive(false);
        PongGlobal.paused = false;
    } 
    void Update(){
        //check game state - did someone win > display gameover screen
        if(PlayerOneScore > 10)
            gameover.displayGameOver("Player 1");
        else if (PlayerTwoScore > 10)
            gameover.displayGameOver("Player 2");
    }
    public void pause(){
        pauseScreen.SetActive(true);
    }
}
