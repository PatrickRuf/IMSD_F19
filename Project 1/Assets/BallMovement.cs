using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public GameObject Reward;
    public GameObject CubeReward;
    public GameObject CapsuleReward;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0, 10 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, 0, -10 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(10 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-10 * Time.deltaTime, 0, 0);
        }

        BottomRewards();
        TopRewards();
        RightRewards();
    }

    void BottomRewards()
    {
        if (transform.position.y > -10.0f && transform.position.y < -5 && transform.position.z < 0 && transform.position.x > 20 && transform.position.x < 30)
        {
            for (int ZPos = 0; ZPos < 50; ZPos = ZPos = ZPos + 5)
            {
                Instantiate(CubeReward, new Vector3(12.5f, 12.5f, ZPos), Quaternion.identity);
                Instantiate(CubeReward, new Vector3(25, 25, ZPos), Quaternion.identity);
                Instantiate(CubeReward, new Vector3(35, 35, ZPos), Quaternion.identity);
            }

            transform.position = new Vector3(-4.5f, 3, 25);

        }
    }

    void TopRewards()
    {
        if (transform.position.y > -10.0f && transform.position.y < -5 && transform.position.x > 20 && transform.position.x < 30)
        {
            for (int XPos = 0; XPos < 50; XPos = XPos = XPos + 5 )
            {
                Instantiate(Reward, new Vector3(XPos, 12.5f, 12.5f), Quaternion.identity);
                Instantiate(Reward, new Vector3(XPos, 25, 25), Quaternion.identity);
                Instantiate(Reward, new Vector3(XPos, 35, 35), Quaternion.identity);
            }
            
            transform.position = new Vector3(-4.5f, 3, 25);

        }
    }
    void RightRewards()
    {
        if (transform.position.y > -10.0f && transform.position.y < -5 && transform.position.x > 50 && transform.position.z > 20 && transform.position.z < 30)
        {
            for (int ZPos = 0; ZPos < 50; ZPos = ZPos = ZPos + 5)
            {
                Instantiate(CapsuleReward, new Vector3(12.5f, 12.5f, ZPos), Quaternion.identity);
                Instantiate(CapsuleReward, new Vector3(25, 25, ZPos), Quaternion.identity);
                Instantiate(CapsuleReward, new Vector3(35, 35, ZPos), Quaternion.identity);
            }

            transform.position = new Vector3(-4.5f, 3, 25);

        }
    }
}
