using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car2 : MonoBehaviour
{
    public float rotateSpeed=5f;
    public float moveSpeed=2f;
    void Update()
    {
        if (Input.GetKey(KeyCode.F)){
            transform.Rotate(0,0,rotateSpeed);
        }
        if (Input.GetKey(KeyCode.H)){
            transform.Rotate(0,0,-rotateSpeed);
        }
        if (Input.GetKey(KeyCode.T)){
            transform.Translate(0,moveSpeed,0);
        }
        if (Input.GetKey(KeyCode.G)){
            transform.Translate(0,-moveSpeed,0);
        }   
        
    }
}
