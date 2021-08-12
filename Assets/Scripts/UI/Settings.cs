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
            //turn off sound effects
            PongGlobal.effectVolume = !PongGlobal.effectVolume;
            //change image to match
            if(PongGlobal.effectVolume)
                effectsButton.image.sprite = on;
            else
                effectsButton.image.sprite = off;            
        });                      
    }
}
