using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
   public Sprite dayBackground;
   public Sprite nightBackground;
    void Start()
    {
        DateTime currentTime=DateTime.Now;
        if (currentTime.Hour>=6 && currentTime.Hour<18){
            SetBackground(dayBackground);
        }
        else{
            SetBackground(nightBackground);

        }
        Debug.Log("Current time " +currentTime.Hour);
        
    }
    private void SetBackground(Sprite background){
        SpriteRenderer spriteRenderer=GetComponent<SpriteRenderer>();
        spriteRenderer.sprite=background;
    }
}
