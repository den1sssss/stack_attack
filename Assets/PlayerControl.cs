using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float  speed = 3.0f;

    void Update()
    {
        float  trans = Input.GetAxis("Horizontal") * speed;
        trans *= Time.deltaTime;
        transform.Translate(trans, 0, 0);
    }
}
