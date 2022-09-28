using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Allows the camera to follow the player no matter how it is transformed by getting its position and setting cameras position to it
public class CameraScript : MonoBehaviour {
    public Transform target;

    void LateUpdate()
    {
        transform.position = new Vector3(target.position.x, target.position.y, -10);
        
    }
}
