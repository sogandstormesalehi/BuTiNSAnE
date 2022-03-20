using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundShake : MonoBehaviour
{
    private bool shake = false;
    private float amount = 0.3f;
    private Vector3 temp;
    private void Start() {
        temp = new Vector3(amount, 0, 0);
    }
    void Update()
    {
         
        if (shake) {
            transform.position += temp;
        }
        else {
            transform.position -= temp;
        }

        shake = !shake;

    }
}
