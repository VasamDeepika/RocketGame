using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class FuelTimer : MonoBehaviour
{
    public GameObject FuelText;
    public int secondsLeft = 30;
    public bool takingAway = false;

    void Start()
    {
        FuelText.GetComponent<Text>().text = "00:" + secondsLeft;
    }

    private void Update()
    {
        if(takingAway == false && secondsLeft > 0)
        {
            StartCoroutine(TimerTake());
        }
    }
    IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;
        if (secondsLeft < 10)
        {
            FuelText.GetComponent<Text>().text = "00:0" + secondsLeft;
        }
        else
        {
            FuelText.GetComponent<Text>().text = "00:" + secondsLeft;
        }
        takingAway = false;
        if (secondsLeft == 0)
        {
            print("GameOver");
        }
    }
    
}