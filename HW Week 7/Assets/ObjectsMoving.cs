using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsMoving : MonoBehaviour
{
    public GameObject Cube;
    public GameObject Sphere;
    public GameObject Capsule;
    public Light capsulechangingcolor;

    public float speed;
    public float timer;


    void Start()
    {
        speed = 1;

        Cube = Instantiate(Cube, new Vector3(-2, -2, 0), Quaternion.identity);
        Sphere = Instantiate(Sphere, new Vector3(2, 2, 0), Quaternion.identity);
        Capsule = Instantiate(Capsule, new Vector3(0, 0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        Cube.transform.position = new Vector3(Mathf.Sin(timer) * -4, -2, 0);

        Sphere.transform.position = new Vector3(Mathf.Sin(timer * -1) * -4, 2, 0);

        if (Input.GetKey(KeyCode.D))
        {

            Capsule.transform.position += new Vector3(1 * Time.deltaTime * speed, 0, 0);

        }

        if (Input.GetKey(KeyCode.A))
        {

            Capsule.transform.position += new Vector3(-1 * Time.deltaTime * speed, 0, 0);

        }

        if (Input.GetKey(KeyCode.W))
        {
            speed = speed + .5f;
        }

        if (Input.GetKey(KeyCode.S))
        {
            speed = speed - .5f;
        }

        colorchange();
    }

    public void colorchange()
    {
        if (Capsule.transform.position.x > 6)
        {
            capsulechangingcolor.color = new Color(1, 0, 0);
        }

        if (Capsule.transform.position.x > 6 && speed > 15)
        {
            capsulechangingcolor.color = new Color(1, 0, 1);
        }

        if (Capsule.transform.position.x > 6 && speed < -15)
        {
            capsulechangingcolor.color = new Color(.5f, .5f, .5f);
        }

        if (Capsule.transform.position.x < -6)
        {
            capsulechangingcolor.color = new Color(0, 1, 0);
        }

        if (Capsule.transform.position.x < -6 && speed > 15)
        {
            capsulechangingcolor.color = new Color(1, 1, 0);
        }

        if (Capsule.transform.position.x < -6 && speed < -15)
        {
            capsulechangingcolor.color = new Color(0, 0, 1);
        }
    }
}
