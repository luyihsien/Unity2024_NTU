using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera1 : MonoBehaviour
{
    public GameObject mainObject;
    private void LateUpdate() {
        transform.position=mainObject.transform.position+new Vector3(0,0,-10);
    }
}
