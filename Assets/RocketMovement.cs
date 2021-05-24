using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMovement : MonoBehaviour
{
    Vector2 dir;
    int RocketSpeed = 2;
    public Vector2 startPoint;
    public Vector2 endPoint;
    
    // Start is called before the first frame update
    void Start()
    {
        print("Welcome to RocketGame");
        print("Please press Up Arrow to move to top, \n DownArrow to move down,\n LeftArrow to move left,\n Right Arrow to move right");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * Time.deltaTime * RocketSpeed);
            startPoint = startPoint + new Vector2(1, 0);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * Time.deltaTime * RocketSpeed);
            startPoint = startPoint + new Vector2(-1, 0);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * Time.deltaTime * RocketSpeed);
            startPoint = startPoint + new Vector2(0, 1);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * Time.deltaTime * RocketSpeed);
            startPoint = startPoint + new Vector2(0, -1);
        }
    }
    public void TimerEnd()
    {
        if(startPoint == endPoint)
        {
            print("Rocket succesfully reached destination\n You Won");
        }
    }
        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.name == "MovingObstacle")
            {
                print("Game Over");
            }
           
        }
}
