using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelAnimations : MonoBehaviour
{
    public MoveCar movecar;
    public Animator YellowCArAnimator; //animator controlling whatever animator in the object this script is associated with

    public float animspeed = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animspeed = -(movecar.Velocity / 4); //i also control the wheel spinning speed (animation speed) depending on the velocity
        YellowCArAnimator.speed = animspeed;
    }
}
