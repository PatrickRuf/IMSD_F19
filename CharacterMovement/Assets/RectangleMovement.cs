using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RectangleMovement : MonoBehaviour
{
    public float EngineStart;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            EngineStart = 2;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-3 * Time.deltaTime * EngineStart, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(6 * Time.deltaTime * EngineStart, 0, 0);
        }


    }
}
