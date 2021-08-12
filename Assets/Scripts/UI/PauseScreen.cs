using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseScreen : MonoBehaviour
{
    public Button resumeButton;
    void Start()
    {
        resumeButton.onClick.AddListener(()=> {
            this.gameObject.SetActive(false);
            GameManager.instance.startResume();
        });         
    }   
}
