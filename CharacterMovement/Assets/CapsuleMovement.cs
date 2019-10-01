using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleMovement : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 0)
        {
            transform.position = new Vector3(5, 10, 0);
        }
        else
        {
            transform.position += new Vector3(0, -3 * Time.deltaTime, 0);
        }
    }
}
