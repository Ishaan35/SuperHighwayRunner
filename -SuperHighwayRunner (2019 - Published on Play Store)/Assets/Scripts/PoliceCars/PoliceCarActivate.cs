using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceCarActivate : MonoBehaviour
{
    public Transform Policecar1;
    public GameObject policecar1_;

    public Transform Player;

    public GameObject player;
    public StopCar stopcar;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.transform.position + offset;

        if (stopcar.Moving == true)
        {
            policecar1_.GetComponent<Police>().enabled = true;
            policecar1_.GetComponent<PoliceCarActivate>().enabled = false;
        }
    }
}
