using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBuilder : MonoBehaviour
{

    public GameObject BrickBuilder;

    // Start is called before the first frame update
    void Start()
    {
        BuildTheBackWall();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void BuildTheBackWall()
    {
        for ( int Xpos = 0; Xpos < 10; Xpos++)
        {
            for (int Ypos = 0; Ypos < 10; Ypos++)
            {
                Instantiate(BrickBuilder, new Vector3(Xpos * 2 - 10, Ypos, 0), Quaternion.identity);
            }
        }
    }
}
