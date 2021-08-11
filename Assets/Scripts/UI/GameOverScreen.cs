using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public Button homeButton;
    public Button replayButton;
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

}
