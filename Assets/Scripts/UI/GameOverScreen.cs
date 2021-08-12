using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public Button homeButton;
    public TextMeshProUGUI winner;

    void Start()
    {
        homeButton.onClick.AddListener(()=> {
            this.gameObject.SetActive(false);
            SceneManager.LoadScene("Menu");
        });            
    }
    public void displayGameOver(string name){
        this.gameObject.SetActive(true);
        winner.text = name + " wins!";
    }

}
