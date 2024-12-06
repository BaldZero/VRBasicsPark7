using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotatePedestal : MonoBehaviour
{
    public Slider slider;
    private float maxRotate = 180;
    public float rotatePedestal;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        float transformRotate = (maxRotate * slider.value);
        transform.rotation = Quaternion.Euler(0, transformRotate, 0);
    }


}
