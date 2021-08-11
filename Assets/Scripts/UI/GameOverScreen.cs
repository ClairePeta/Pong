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

    // Start is called before the first frame update
    void Start()
    {
        homeButton.onClick.AddListener(()=> {
            SceneManager.LoadScene("Menu");
        });
        replayButton.onClick.AddListener(()=> {
            //StartGame(true);
        });                
    }
    public void displayGameOver(string name){
        this.gameObject.SetActive(true);
        winner.text = name + " wins!";
    }

}
