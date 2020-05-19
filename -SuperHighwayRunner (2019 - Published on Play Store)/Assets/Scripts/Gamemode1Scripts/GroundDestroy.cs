using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDestroy : MonoBehaviour
{
    public int GroundDestroyIndicator;
    public StopCar stopcar;

    
    // Start is called before the first frame update
    void Start()
    {
        GroundDestroyIndicator = 0;
        GameObject Player = GameObject.Find("Player");
        stopcar = Player.GetComponent<StopCar>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GroundDestroyIndicator == 2)
        {
            Destroy(gameObject);
        }

        if (stopcar.Moving == false)
        {
            GroundDestroyIndicator = 1;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CivilianDestroyer")
        {
            if (stopcar.Moving == true)
            {
                GroundDestroyIndicator = 1;
            }
            

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "CivilianDestroyer")
        {
            if (stopcar.Moving == true)
            {
                GroundDestroyIndicator = 2;
            }

        }
    }


}
