using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawn : MonoBehaviour
{
    public GameObject Ground1;
    public GameObject Ground2;
    public GameObject Ground3;
    public Transform InstantiateLocation;

    public bool spawnground;
    public GroundID groundid;

    // Start is called before the first frame update
    void Start()
    {
        spawnground = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (groundid.Groundid == 1)
        {
            if (other.gameObject.tag == "Player")
            {
                if (spawnground == true)
                {
                    GameObject clone = Instantiate(Ground1, InstantiateLocation.position, InstantiateLocation.rotation);
                }
                spawnground = false;
            }
        }
        if (groundid.Groundid == 2)
        {
            if (other.gameObject.tag == "Player")
            {
                if (spawnground == true)
                {
                    GameObject clone = Instantiate(Ground2, InstantiateLocation.position, InstantiateLocation.rotation);
                }
                spawnground = false;
            }
        }
        if (groundid.Groundid == 3)
        {
            if (other.gameObject.tag == "Player")
            {
                if (spawnground == true)
                {
                    GameObject clone = Instantiate(Ground3, InstantiateLocation.position, InstantiateLocation.rotation);
                }
                spawnground = false;
            }
        }

    }
}
