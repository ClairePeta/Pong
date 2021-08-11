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
    // Start is called before the first frame update
    void Start()
    {
        startSinglePlayerButton.onClick.AddListener(()=> {
            StartGame(true);
        });
        startMultiPlayerButton.onClick.AddListener(()=> {
            StartGame();
        });
        settingsButton.onClick.AddListener(()=> {
            settingsScreen.SetActive(true);
        });       

        //for no
        startMultiPlayerButton.enabled = false;         
    }

    // Update is called once per frame
    void StartGame(bool singlePlayer = false)
    {
        SceneManager.LoadScene("Game");
    }

}
