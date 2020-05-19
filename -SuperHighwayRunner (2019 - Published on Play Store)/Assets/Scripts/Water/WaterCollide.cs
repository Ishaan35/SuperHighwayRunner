using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterCollide : MonoBehaviour
{

    public ParticleSystem watersplash;

    

    public Transform Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Camera.main.GetComponent<CameraFollow>().enabled = false;
            watersplash.transform.position = Player.transform.position;
            watersplash.Play();
        }
    }
}
