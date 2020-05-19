using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar : MonoBehaviour
{


    public GameObject Lane1spawner; //referencing 3 spawners
    public GameObject Lane2spawner;
    public GameObject Lane3spawner;

    public Transform Policecar1; //police car
    public GameObject Policecar1_;
   

    public bool spawnground; //controls spawning of ground

    public float Velocity; //player speed
    public float VelocityCounter; //float later used in for loop

    public GameObject car; 
    public int LaneChange; //what lane plauyr  is in

    public StopCar stopcar; //another script controlling player

    
    public Police police;
   
    public bool speedincrease1; 
    

    public Score score;

    

    public LanePatternsVariable lanepattern; //referenceing script that chooses an orientation for the cars to be on te road


    // Start is called before the first frame update
    void Start()
    {
        Velocity = 0;
        StartCoroutine(Accelerate());
        LaneChange = 0;
        spawnground = true;//start spawning
        car.GetComponent<LanePatternsVariable>().enabled = false; //temporary breathing time before starting
        

        speedincrease1 = true;
        

        
        



    }



    // Update is called once per frame
    void FixedUpdate()
    { 
        transform.Translate(Velocity * Time.deltaTime, 0f, 0);    //move by velocity float always  
    }

    private void Update()
    {
        
        if (Score.Scorenumber >= 250) //after 250 score, speed increase is still true, until this code is finished, and then it is false, to ensure this does not happen again
        {
            if (speedincrease1 == true)
            {
                InvokeRepeating("SpeedIncrease1", 0.5f, 2f);
            }
            speedincrease1 = false;
        }

        

        if (Score.Scorenumber > 600f || Vector3.Distance(Policecar1.position, this.transform.position) < 1.1f)
        {
            CancelInvoke(); //after 600score , cancel the previous invokerepeating
        }
        
      

        
    }



    IEnumerator Accelerate() //starting to move the car. it is negative since the global world's backwards is our local forward
    {
        
        for (float v = 0; v > -16; v--)
        {
            if (stopcar.Moving == true)
            {
                Velocity--;
                VelocityCounter--;
                yield return new WaitForSeconds(0.2f);
            }
            
        }
        car.GetComponent<LanePatternsVariable>().enabled = true;  //start the random car generation after desired speed of player
    }

    void SpeedIncrease1()
    {
        Velocity--;
        VelocityCounter--;
        
    }
    


    IEnumerator Left() //turning left
    {
        for (int l = 0; l < 10; l++)
        {
            car.transform.position += new Vector3(-0.1f, 0, 0);
            yield return new WaitForSeconds(0.01f);
        }
    }

    //functions that move the spawners opposite direction of player, to ensure that spawners stay on the road
    IEnumerator Lane1Spawnerright()
    {
        for (int l = 0; l < 10; l++)
        {
            Lane1spawner.transform.position += new Vector3(0.1f, 0, 0);
            yield return new WaitForSeconds(0.01f);
        }
    }
    IEnumerator Lane2Spawnerright()
    {
        for (int l = 0; l < 10; l++)
        {
            Lane2spawner.transform.position += new Vector3(0.1f, 0, 0);
            yield return new WaitForSeconds(0.01f);
        }
    }
    IEnumerator Lane3Spawnerright()
    {
        for (int l = 0; l < 10; l++)
        {
            Lane3spawner.transform.position += new Vector3(0.1f, 0, 0);
            yield return new WaitForSeconds(0.01f);
        }
    }





    IEnumerator Right() //turning right
    {
        for (int r = 0; r < 10; r++)
        {
            car.transform.position += new Vector3(0.1f, 0, 0);
            yield return new WaitForSeconds(0.01f);
        }

    }

    IEnumerator Lane1Spawnerleft()
    {
        for (int r = 0; r < 10; r++)
        {
            Lane1spawner.transform.position += new Vector3(-0.1f, 0, 0);
            yield return new WaitForSeconds(0.01f);
        }

    }
    IEnumerator Lane2Spawnerleft()
    {
        for (int r = 0; r < 10; r++)
        {
            Lane2spawner.transform.position += new Vector3(-0.1f, 0, 0);
            yield return new WaitForSeconds(0.01f);
        }

    }
    IEnumerator Lane3Spawnerleft()
    {
        for (int r = 0; r < 10; r++)
        {
            Lane3spawner.transform.position += new Vector3(-0.1f, 0, 0);
            yield return new WaitForSeconds(0.01f);
        }

    }





}