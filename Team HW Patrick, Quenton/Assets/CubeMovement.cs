using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{

    public float speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CubeMovingLeftOfTheScreen();
        CubeMovingTowardsUs();
    }

    void CubeMovingLeftOfTheScreen()
    {
        transform.position += Vector3.left * speed/2;
    }

    void CubeMovingTowardsUs()
    {
        transform.position += Vector3.back * speed;
    }
}
