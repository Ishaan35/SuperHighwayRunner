using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopCar : MonoBehaviour

    
{
    public GameObject trigger;

    public GameObject Gas;
    public GameObject Money;

    public Transform player;
    public GameObject player_;
    
    public bool Moving;
    public MoveCar movecar;
    public GameObject Car;
    public Rigidbody rb;

    public bool FuelEmpty;
    public bool FuelCanTouch;

    public GameObject FuelCan;

    public float Startfuel = 100;
    public float fuel;

    public float FuelBarValue;
    
    public float DeAccelerationRate;

    public GameObject Lane1Spawner;
    public GameObject Lane2Spawner;
    public GameObject Lane3Spawner;

    public GameObject subLane1Spawner;
    public GameObject subLane2Spawner;
    public GameObject subLane3Spawner;

    public GameObject gamecamera;

    public Canvas ControlButtons;

    public GroundSpawnManager groundspawn;
    
    

    [Header("Unity Stuff")]
    public Image FuelBar;

    // Start is called before the first frame update
    void Start()
    {
        Moving = true;
        rb = GetComponent<Rigidbody>();
        fuel = Startfuel;
        StartCoroutine(UsingFuel());

        FuelEmpty = false;
        FuelCanTouch = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        FuelBarValue = fuel / Startfuel;

        if (movecar.Velocity < -8)
        {
            
            DeAccelerationRate = 0.1f;
        }
        

        FuelBar.fillAmount = FuelBarValue;

        if (FuelEmpty == false)
        {
            if (fuel <= 0)
            {
                Moving = false;
                FuelEmpty = true;
                StartCoroutine(FuelDeaccelerate());

                
                
            }
        }

        if (Moving == false)
        {
            ControlButtons.enabled = false;
        }


    }


    
        IEnumerator OnCollisionEnter(Collision other)
        {
            if (Moving == true)
            {
                Moving = false;
                if (other.gameObject.tag == "Obstacle")
                {
                    if (Moving == false)
                    {
                    
                    rb.isKinematic = false;
                    subLane1Spawner.GetComponent<CivilianCarSpawn>().enabled = false;
                    subLane2Spawner.GetComponent<CivilianCarSpawn2>().enabled = false;
                    subLane3Spawner.GetComponent<CivilianCarSpawn3>().enabled = false;
                    Lane1Spawner.SetActive(false);
                    Lane2Spawner.SetActive(false);
                    Lane3Spawner.SetActive(false);
                    ControlButtons.enabled = false;
                    
                    movecar.spawnground = false;
                    
                    Destroy(Gas);
                    Destroy(Money);
                    player_.GetComponent<LanePatternsVariable>().enabled = false;

                    for (int i = 0; i > (2 * movecar.VelocityCounter); i--)
                        {
                        movecar.Velocity = movecar.Velocity + 0.5f;
                        yield return new WaitForSeconds(DeAccelerationRate);
                        }
                    player_.GetComponent<MoveCar>().enabled = false;
                    player_.GetComponent<StopCar>().enabled = false;
                    }
                    
                
                }

                if (other.gameObject.tag == "Drown")
                {
                Debug.Log("son");

                }


        }
        }


    

    IEnumerator UsingFuel()
    {
        
        while(Moving == true)
        {
            fuel = fuel - 0.05f;
            yield return new WaitForSeconds(0.01f);

        }

      
    }


    IEnumerator FuelDeaccelerate()
    {
        rb.isKinematic = false;
        movecar.spawnground = false;
        for (int i = 0; i > (2 * movecar.VelocityCounter); i--)
        {
            movecar.Velocity = movecar.Velocity + 0.5f;
            yield return new WaitForSeconds(DeAccelerationRate);
            
        }
        player_.GetComponent<MoveCar>().enabled = false;
        player_.GetComponent<StopCar>().enabled = false;
    }

    
    






}
