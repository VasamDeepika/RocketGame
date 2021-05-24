using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacle : MonoBehaviour
{
    int speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x <= 3)
        {
            speed = 1;
        }
        if(transform.position.x >= 5)
        {
            speed = -1;
        }
        transform.Translate(speed*Time.deltaTime,0,0);
    }
}
