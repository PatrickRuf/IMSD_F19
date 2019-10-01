using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackSphereMovement : MonoBehaviour
{   

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 10)
        {
            transform.position = new Vector3(-5, 0, 0);
        }
        else
        {
            transform.position += new Vector3(0, 3 * Time.deltaTime, 0);
        }
    }

    }

