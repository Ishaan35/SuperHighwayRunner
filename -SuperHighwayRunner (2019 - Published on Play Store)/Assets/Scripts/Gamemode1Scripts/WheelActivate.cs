using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelActivate : MonoBehaviour
{
    public StopCar stopcar;
    public GameObject Wheels;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {//to reduce lag, i disable mesh of wheels of cars whe they are out of view of the player
        if (stopcar.Moving == false)
        {
            Wheels.SetActive(true);
        }
    }
}
