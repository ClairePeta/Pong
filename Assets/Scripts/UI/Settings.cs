using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public Button backButton;
    public Button musicButton;
    public Button effectsButton;
    public Sprite on;
    public Sprite off;
    bool musicOn = true;
    bool effectsOn = true;

    void Start()
    {
        backButton.onClick.AddListener(()=> {
            this.gameObject.SetActive(false);
        });         
        musicButton.onClick.AddListener(()=> {
            //turn off audio
            musicOn = !musicOn;
            //change image to match
            if(musicOn)
                musicButton.image.sprite = on;
            else
                musicButton.image.sprite = off;
        });      
        effectsButton.onClick.AddListener(()=> {
            //turn off sound effects
            effectsOn = !effectsOn;
            //change image to match
            if(effectsOn)
                effectsButton.image.sprite = on;
            else
                effectsButton.image.sprite = off;            
        });                      
    }
}
