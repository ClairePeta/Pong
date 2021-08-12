using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public Button homeButton;
    public Button replayButton;
    public TextMeshProUGUI winner;

    void Start()
    {
        homeButton.onClick.AddListener(()=> {
            SceneManager.LoadScene("Menu");
        });
        replayButton.onClick.AddListener(()=> {
            SceneManager.LoadScene("Game");
        });                
    }
    public void displayGameOver(string name){
        this.gameObject.SetActive(true);
        winner.text = name + " wins!";
    }

}
