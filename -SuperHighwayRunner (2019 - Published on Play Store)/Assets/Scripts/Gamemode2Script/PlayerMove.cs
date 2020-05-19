using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5;
    public Rigidbody rb;
    public float anglespeed;

    public float startfuel = 100;
    public float fuel;

    public float FuelBarValue;

    public GameObject spawners;

    public Transform player;
    public GameObject player_;
    public bool PLAYERMOVING;
    public bool continuestopping;

   
    public GameObject Subspawner1;
    public GameObject Subspawner2;
    public GameObject Subspawner3;
    public GameObject Subspawner4;

    public bool random;

    public bool continuespeedingup;


   
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Acceleration());
        PLAYERMOVING = true;
        rb = GetComponent<Rigidbody>();
        fuel = startfuel;
        
        continuestopping = false;
        random = true;
    }

    private void Update()
    {

        if (PLAYERMOVING == true)
        {
            StopCoroutine(Acceleration());
        }

        if (speed < 18)
        {
            StartCoroutine(Acceleration());
        }

        if (PLAYERMOVING == false)
        {
            StartCoroutine(Stopmoving());
        }
        

        anglespeed = Input.acceleration.x;
        Debug.Log(anglespeed);

        if (fuel <= 0 && continuestopping == false)
        {
            StartCoroutine(Stopmoving());
            continuestopping = true;
        }
       
        if (speed < 0)
        {
            player_.GetComponent<PlayerMove>().enabled = false;

        }
        
        
        

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Forward
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        spawners.transform.Translate(Vector3.left * speed * Time.deltaTime);

        // Moving
        if (player.transform.position.x >= -1.15 && player.transform.position.x <= 2.05 && PLAYERMOVING == true)
        {
            transform.Translate(0, 0, anglespeed / 5);  
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(Vector3.back * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(Vector3.forward * speed * Time.deltaTime);
            }

        }

        // Barriers
        if (player.transform.position.x < -1.15)
        {

            player.transform.position += new Vector3(0.01f, 0, 0);
            
        }
        if (player.transform.position.x > 2.05)
        {
            player.transform.position += new Vector3(-0.01f, 0, 0);
            
        }
    }

    private IEnumerator OnCollisionEnter(Collision other)
    {
        
        {
            
            if (other.gameObject.tag == "Obstacle")
            {
                PLAYERMOVING = false;
                random = false;
                Subspawner1.GetComponent<G2CivilianCarSpawn>().enabled = false;
                Subspawner2.GetComponent<G2CivilianCarSpawn2>().enabled = false;
                Subspawner3.GetComponent<G2CivilianCarSpawn3>().enabled = false;
                Subspawner4.GetComponent<G2CivilianCarSpawn4>().enabled = false;
                spawners.GetComponent<G2LanePatternVariable>().enabled = false;
                other.gameObject.GetComponent<CivilianCarDestroy>().enabled = false;
                while (speed > 0)
                {
                    speed = speed - 0.5f;
                    yield return new WaitForSeconds(0.2f);
                }


            }
        }
    }



    

    IEnumerator Acceleration()
    {
        
            {
                speed = speed + 0.05f;
                yield return new WaitForSeconds(0.1f);
            }

    }

    IEnumerator Stopmoving()
    {
        
        while (speed > 0)
        {
            
            speed = speed - 0.07f;
            yield return new WaitForSeconds(0.1f);
        }
    }




}
