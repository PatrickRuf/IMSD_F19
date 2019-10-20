using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReferenceOtherStuff : MonoBehaviour
{

    //Mathf.Sin(timer)
    //private float startTimer;
    //startTimer += Time.deltaTime;
    //if (startTimer >= 5)
        //timer += Time.deltaTime;
     

    public float timer;
    public Light lightchangingtored;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 5)
        {
            //float r = (Mathf.Sin(timer) / 2) + .5f;
            lightchangingtored.color = new Color(Mathf.Sin(timer), 0, 0);
        }
    }
}
