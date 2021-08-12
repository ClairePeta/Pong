using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Button startSinglePlayerButton;
    public Button startMultiPlayerButton;
    public Button settingsButton;
    public GameObject settingsScreen;
    void Start()
    {
        startSinglePlayerButton.onClick.AddListener(()=> {
            PongGlobal.playAgainstAI = true;
            SceneManager.LoadScene("Game");
        });
        startMultiPlayerButton.onClick.AddListener(()=> {
            PongGlobal.playAgainstAI = false;
            SceneManager.LoadScene("Game");
        });
        settingsButton.onClick.AddListener(()=> {
            settingsScreen.SetActive(true);
        });               
    }
}
