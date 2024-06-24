using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collision : MonoBehaviour
{
    int score=0;
    public float delayDestroy=0.5f;
    public TextMeshProUGUI scoreText;
    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Collision");
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag=="Positive"){
            score+=1;
            scoreText.text=$"Score : {score}";
        }else if (other.tag=="Negative"){
            score-=1;
            scoreText.text=$"Score : {score}";   
        }
        Destroy(other.gameObject);
    }
}
