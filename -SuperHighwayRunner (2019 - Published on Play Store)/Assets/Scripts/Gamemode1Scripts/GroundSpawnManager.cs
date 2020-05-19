using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawnManager : MonoBehaviour
{
    public GameObject Ground;
    public GameObject Ground2;
    public GameObject Ground3;
    public Transform InstantiateLocation;

    public MoveCar movecar;
    
    public GameObject Trigger;
    public bool IsSpawn;
    public K K;

    public StopCar stopcar;

    public float DestroyTime = 13f;




    
    // Start is called before the first frame update
    void Start()
    {
        
        IsSpawn = true;
        


    }
    

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider Collision)
    {
        if(K.k == 1) //I made a variable named k representing which terrain to spawn. changes over time
        {
            if (movecar.spawnground == true) //if bool in player script is true
            {
                if (IsSpawn == true) //spawn once since we are in update() and then later set bool back to false
                {
                    if (Collision.gameObject.tag == "Player")

                    {
                        {

                            GameObject clone = Instantiate(Ground, InstantiateLocation.position, InstantiateLocation.rotation);
                            clone.AddComponent<GroundDestroy>();
                            if (stopcar.Moving == true)
                                IsSpawn = false;


                        }
                    }

                }
            }
            
        }

        if (K.k == 2)
        {
            if (movecar.spawnground == true)
            {
                if (IsSpawn == true)
                {
                    if (Collision.gameObject.tag == "Player")
                    {

                        GameObject clone1 = Instantiate(Ground2, InstantiateLocation.position, InstantiateLocation.rotation);
                        clone1.AddComponent<GroundDestroy>();
                        if (stopcar.Moving == true)
                            IsSpawn = false; // we dont set it back to true later on since this script is associated with every trigger on every spawning piece, so when instantiating a new ground, isspawn is set to true by defailt. We never need to reference the same trigger's script again, as the car already drove past it


                    }
                }
            }
           
        }

        if (K.k == 3)
        {
            if (movecar.spawnground == true)
            {
                if (IsSpawn == true)
                {
                    if (Collision.gameObject.tag == "Player")
                    {

                        GameObject clone2 = Instantiate(Ground3, InstantiateLocation.position, InstantiateLocation.rotation);
                        clone2.AddComponent<GroundDestroy>();
                        if (stopcar.Moving == true)
                            IsSpawn = false;


                    }
                }
            }
            
        }
    }

    

  

}
