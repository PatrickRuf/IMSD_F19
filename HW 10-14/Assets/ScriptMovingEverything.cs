using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptMovingEverything : MonoBehaviour
{

    public GameObject Cube;
    public GameObject Sphere;
    public GameObject Capsule;
    public GameObject Cylinder;
    
    float XPos = 0;
    float YPos = -5;

    float speed = 8;

    void Start()
    {
        
        Cube = Instantiate(Cube, new Vector3(XPos, YPos, 0), Quaternion.identity);

        Sphere = Instantiate(Sphere, new Vector3(XPos + 5, YPos, 0), Quaternion.identity);

        Capsule = Instantiate(Capsule, new Vector3(XPos + 10, YPos, 0), Quaternion.identity);

        Cylinder = Instantiate(Cylinder, new Vector3(XPos + 15, YPos, 0), Quaternion.identity);

    }


    void Update()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
            Cube.transform.position += new Vector3(0, 1 * Time.deltaTime * speed, 0);

            Cylinder.transform.position += new Vector3(0, -1 * Time.deltaTime * speed, 0);

            Sphere.transform.position += new Vector3(0, 0, 1 * Time.deltaTime * speed);

            Capsule.transform.position += new Vector3(0, 0, -1 * Time.deltaTime * speed);

        }
        if (Input.GetKey(KeyCode.A))
        {
            Cube.transform.position += new Vector3(-1 * Time.deltaTime * speed, 0, 0);

            Cylinder.transform.position += new Vector3(1 * Time.deltaTime * speed, 0, 0);

            Sphere.transform.position += new Vector3(1 * Time.deltaTime * speed, 0, 0);

            Capsule.transform.position += new Vector3(-1 * Time.deltaTime * speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Cube.transform.position += new Vector3(0, -1 * Time.deltaTime * speed, 0);

            Cylinder.transform.position += new Vector3(0, 1 * Time.deltaTime * speed, 0);

            Sphere.transform.position += new Vector3(0, 0, -1 * Time.deltaTime * speed);

            Capsule.transform.position += new Vector3(0, 0, 1 * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Cube.transform.position += new Vector3(1 * Time.deltaTime * speed, 0, 0);

            Cylinder.transform.position += new Vector3(-1 * Time.deltaTime * speed, 0, 0);

            Sphere.transform.position += new Vector3(-1 * Time.deltaTime * speed, 0, 0);

            Capsule.transform.position += new Vector3(1 * Time.deltaTime * speed, 0, 0);
        }
    }
}
