using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public Button backButton;
    public Button effectsButton;
    public Sprite on;
    public Sprite off;
    void Start()
    {
        backButton.onClick.AddListener(()=> {
            this.gameObject.SetActive(false);
        });              
        effectsButton.onClick.AddListener(()=> {
            //turn on/ off sound effects and change the image to match
            PongGlobal.effectVolume = !PongGlobal.effectVolume;
            if(PongGlobal.effectVolume)
                effectsButton.image.sprite = on;
            else
                effectsButton.image.sprite = off;            
        });                      
    }
}
