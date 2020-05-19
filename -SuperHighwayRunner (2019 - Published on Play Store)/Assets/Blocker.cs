using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This is a large object trailing the player which will prevent the player from flying backwards if in a car crash
public class Blocker : MonoBehaviour
{
    public GameObject player;

    public Vector3 offset;

    public StopCar stopcar;
    // Start is called before the first frame update
    void Start()
    {
        stopcar.Moving = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (stopcar.Moving == true)
        {
            gameObject.transform.position = player.transform.position + offset;
        }
        
    }
}
