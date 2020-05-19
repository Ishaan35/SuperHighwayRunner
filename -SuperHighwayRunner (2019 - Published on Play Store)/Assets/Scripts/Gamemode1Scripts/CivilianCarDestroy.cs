using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CivilianCarDestroy : MonoBehaviour
{
    public float movespeed = 0.03f;
    private MoveCar movecar;
    private StopCar stopcar;
    
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Move());
        StartCoroutine(SpeedChange());
        movecar = Object.FindObjectOfType<MoveCar>();
        stopcar = Object.FindObjectOfType<StopCar>();
    }

    // Update is called once per frame
    void Update()
    {
       
        if (stopcar.Moving == false)
        {
            movespeed = 0.15f;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CivilianDestroyer")
        {
            Destroy(gameObject);
        }
        

    }

    //incorporated the move mechanics in this script to

    IEnumerator Move()
    {
        while(true) //just moving cars forward
        {
            gameObject.transform.position += new Vector3(0, 0, movespeed);
            yield return new WaitForSeconds(0.03f);
        }
    }

    IEnumerator SpeedChange()
    {
        yield return new WaitForSeconds(25);
        movespeed = 0.05f; //changing the speed after 25 seconds
    } 

}
