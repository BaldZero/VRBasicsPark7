using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Utilities.Tweenables.Primitives;

public class ClockScript : MonoBehaviour
{
    public GameObject hourHand;
    public GameObject minuteHand;
    public GameObject secondHand;
    DateTime dateTime = DateTime.Now;
    public float rotateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        int hoursInClock = 360 / 12;
        

        int currentSeconds = DateTime.Now.Second;
        int currentMinutes = DateTime.Now.Minute;
        int currentHour = DateTime.Now.Hour;
        hourHand.transform.Rotate(0, currentHour * hoursInClock , 0);
        minuteHand.transform.Rotate(0, 360 *currentMinutes, 0);


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        secondHand.transform.Rotate(0, 0.12f, 0);
        minuteHand.transform.Rotate(0, 0.002f, 0);
        hourHand.transform.Rotate(0, 0.000033333333f, 0);
    }
}
