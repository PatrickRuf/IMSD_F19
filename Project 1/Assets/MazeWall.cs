using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeWall : MonoBehaviour
{
     public GameObject BrickBuilder;

    // Start is called before the first frame update
    void Start()
    {
        MazeFloor();
        TopWallsAndGap();
        BottomWallsAndGap();
        LeftWallsAndGap();
        RightWallsAndGap();
        StartingRoom();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MazeFloor()
    {
        for (int Xpos = 0; Xpos <= 50; Xpos++)
        {
            for (int ZPos = 0; ZPos <= 50; ZPos++)
            {
                Instantiate(BrickBuilder, new Vector3(Xpos, 0, ZPos), Quaternion.identity);
            }
        }
    }

    void BottomWallsAndGap()
    {
        for (int Xpos = 0; Xpos < 20; Xpos++)
        {
            for (int YPos = 0; YPos < 10; YPos++)
            {
                Instantiate(BrickBuilder, new Vector3(Xpos, YPos, 0), Quaternion.identity);
            }
        }

        for (int Xpos = 30; Xpos < 50; Xpos++)
        {
            for (int YPos = 0; YPos < 10; YPos++)
            {
                Instantiate(BrickBuilder, new Vector3(Xpos, YPos, 0), Quaternion.identity);
            }
        }
    }

    void TopWallsAndGap()
    {
        for (int Xpos = 0; Xpos < 20; Xpos++)
        {
            for (int YPos = 0; YPos < 10; YPos++)
            {
                Instantiate(BrickBuilder, new Vector3(Xpos, YPos, 50), Quaternion.identity);
            }
        }

        for (int Xpos = 30; Xpos < 50; Xpos++)
        {
            for (int YPos = 0; YPos < 10; YPos++)
            {
                Instantiate(BrickBuilder, new Vector3(Xpos, YPos, 50), Quaternion.identity);
            }
        }
    }

    void LeftWallsAndGap()
    {
        for (int ZPos = 0; ZPos < 20; ZPos++)
        {
            for (int YPos = 0; YPos < 10; YPos++)
            {
                Instantiate(BrickBuilder, new Vector3(0, YPos, ZPos), Quaternion.identity);
            }
        }

        for (int ZPos = 30; ZPos < 50; ZPos++)
        {
            for (int YPos = 0; YPos < 10; YPos++)
            {
                Instantiate(BrickBuilder, new Vector3(0, YPos, ZPos), Quaternion.identity);
            }
        }
    }

    void RightWallsAndGap()
    {
        for (int ZPos = 0; ZPos < 20; ZPos++)
        {
            for (int YPos = 0; YPos < 10; YPos++)
            {
                Instantiate(BrickBuilder, new Vector3(50, YPos, ZPos), Quaternion.identity);
            }
        }

        for (int ZPos = 30; ZPos < 50; ZPos++)
        {
            for (int YPos = 0; YPos < 10; YPos++)
            {
                Instantiate(BrickBuilder, new Vector3(50, YPos, ZPos), Quaternion.identity);
            }
        }
    }

    void StartingRoom()
    {
        //Starting room
        for (int XPos = 0; XPos < 10; XPos++)
        {
            for (int YPos = 0; YPos < 10; YPos++)
            {
                Instantiate(BrickBuilder, new Vector3(-XPos, YPos, 20), Quaternion.identity);
            }
        }

        for (int XPos = 0; XPos < 10; XPos++)
        {
            for (int YPos = 0; YPos < 10; YPos++)
            {
                Instantiate(BrickBuilder, new Vector3(-XPos, YPos, 30), Quaternion.identity);
            }
        }

        for (int Xpos = 0; Xpos < 10; Xpos++)
        {
            for (int ZPos = 20; ZPos < 30; ZPos++)
            {
                Instantiate(BrickBuilder, new Vector3(-Xpos, 0, ZPos), Quaternion.identity);
            }
        }
    }

    void WallsForBottomExit()
    {
        for (int ZPos = 0; ZPos < 10; ZPos++)
        {
            for (int YPos = 0; YPos < 10; YPos++)
            {
                Instantiate(BrickBuilder, new Vector3(20, YPos, ZPos), Quaternion.identity);
            }
        }

        for (int ZPos = 0; ZPos < 10; ZPos++)
        {
            for (int YPos = 0; YPos < 10; YPos++)
            {
                Instantiate(BrickBuilder, new Vector3(30, YPos, ZPos), Quaternion.identity);
            }
        }
    }
    
}
