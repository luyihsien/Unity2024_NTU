using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float steerSpeed=0.9f;
    public float moveSpeed=0.06f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount=Input.GetAxis("Horizontal")*steerSpeed;
        float moveAmount=Input.GetAxis("Vertical")*moveSpeed;
        transform.Rotate(0,0,-steerAmount);
        transform.Translate(0,moveAmount,0);
    }
}
