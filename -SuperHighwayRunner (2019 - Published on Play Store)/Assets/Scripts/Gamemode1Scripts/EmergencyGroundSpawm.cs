using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmergencyGroundSpawm : MonoBehaviour
{
    public GameObject Ground1;
    public Transform InstantiateLocation;

    public StopCar stopcar;

    public bool emergencyspawn;

    // Start is called before the first frame update
    void Start()
    {
        emergencyspawn = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (stopcar.Moving == false)
        {
            if (other.gameObject.tag == "Player")
            {
                if (emergencyspawn == true)
                {
                    GameObject clone = Instantiate(Ground1, InstantiateLocation.position, InstantiateLocation.rotation);
                    emergencyspawn = false;
                }
            }
        }
    }
}
