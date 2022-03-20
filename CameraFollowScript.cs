using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowScript : MonoBehaviour {

    public Transform cameraPosition;
    private bool shake = false;
    private float amount = 0.5f;
	void Update () {
		
        if(cameraPosition.position.y > transform.position.y)
        {
            if (shake) amount = 0.5f;
            else amount = -0.5f;
            Vector3 newPosition = new Vector3(transform.position.x + amount, cameraPosition.position.y,transform.position.z);
            transform.position = newPosition;
            shake = !shake;
        }
    }
}
