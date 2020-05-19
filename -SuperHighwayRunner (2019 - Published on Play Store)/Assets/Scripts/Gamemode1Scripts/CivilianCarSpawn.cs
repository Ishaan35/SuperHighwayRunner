using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This is one of the three scrips associated with three spawners. There are patterns which indicate which lanes the spawners will have to spawn a car in. In this case, the first spawner which is the script we have right now, can only be called if lanepatters is 1 or 4. If itis 1 or 4, determined by referencing another script, then we spawn a car

public class CivilianCarSpawn : MonoBehaviour
{
    public LanePatternsVariable pattern;
    public int carID;

    public bool abletospawn = true;
    public bool CarIdGenerate = true;

    //the spawners sets have 3 objects asociated with them, since some models have different locations that are 0,0,0 for them, I put these subspawners for specific cars which needed to have different spawn locations to actually spawn where i wanted them to spawn
    public Transform InstantiateLocation1;
    public Transform InstantiateLocation2;
    public Transform InstantiateLocation3;
    public Transform Truck;

    //cars list
    public GameObject BlueBus;
    public GameObject GreenBus;
    public GameObject OrangeBus;
    public GameObject YellowBus;
    public GameObject RedBus;
    public GameObject BlueBoxTruck;
    public GameObject GreenBoxTruck;
    public GameObject OrangeBoxTruck;
    public GameObject PurpleBoxTruck;
    public GameObject BlueTruck;
    public GameObject GreenTruck;
    public GameObject RedTruck;
    public GameObject YellowTruck;
    public GameObject RedCar;
    public GameObject GreenCar;
    public GameObject BlueCar;
    public GameObject BrownCar;
    public GameObject YellowCar;

    public Transform PlayerTrail;
  

    public CivilianCarSpawn civiliancarspawn;

    

    // Start is called before the first frame update
    void Start()
    {
    
    }


    // Update is called once per frame
    void Update() // If the pattern of the vehicle allignment on road is 1, then it will choose a random int called carID, and if that is 1, it will spawn blue bus.
    {
        if (pattern.LanePatternIndicator == 1 || pattern.LanePatternIndicator == 4)
        {
            if (CarIdGenerate == true)
            {
                StartCoroutine(CarIdSelect());
                if (carID == 1)
                {
                    GameObject clone = Instantiate(BlueBus, InstantiateLocation1.position, InstantiateLocation1.rotation);
                    clone.AddComponent<CivilianCarDestroy>();         
                }
                if (carID == 2)
                {
                    GameObject clone = Instantiate(GreenBus, InstantiateLocation1.position, InstantiateLocation1.rotation);
                    clone.AddComponent<CivilianCarDestroy>();
                }
                if (carID == 3)
                {
                    GameObject clone = Instantiate(OrangeBus, InstantiateLocation1.position, InstantiateLocation1.rotation);
                    clone.AddComponent<CivilianCarDestroy>();
                }
                if (carID == 4)
                {
                    GameObject clone = Instantiate(YellowBus, InstantiateLocation1.position, InstantiateLocation1.rotation);
                    clone.AddComponent<CivilianCarDestroy>();
                }
                if (carID == 5)
                {
                    GameObject clone = Instantiate(RedBus, InstantiateLocation1.position, InstantiateLocation1.rotation);
                    clone.AddComponent<CivilianCarDestroy>();
                }
                if (carID == 6)
                {
                    GameObject clone = Instantiate(BlueBoxTruck, InstantiateLocation2.position, InstantiateLocation2.rotation);
                    clone.AddComponent<CivilianCarDestroy>();
                }
                if (carID == 7)
                {
                    GameObject clone = Instantiate(GreenBoxTruck, InstantiateLocation2.position, InstantiateLocation2.rotation);
                    clone.AddComponent<CivilianCarDestroy>();
                }
                if (carID == 8)
                {
                    GameObject clone = Instantiate(OrangeBoxTruck, InstantiateLocation2.position, InstantiateLocation2.rotation);
                    clone.AddComponent<CivilianCarDestroy>();
                }
                if (carID == 9)
                {
                    GameObject clone = Instantiate(PurpleBoxTruck, InstantiateLocation2.position, InstantiateLocation2.rotation);
                    clone.AddComponent<CivilianCarDestroy>();
                }
                if (carID == 10)
                {
                    GameObject clone = Instantiate(BlueTruck, InstantiateLocation3.position, InstantiateLocation3.rotation);
                    clone.AddComponent<CivilianCarDestroy>();
                }
                if (carID == 11)
                {
                    GameObject clone = Instantiate(GreenTruck, InstantiateLocation3.position, InstantiateLocation3.rotation);
                    clone.AddComponent<CivilianCarDestroy>();
                }
                if (carID == 12)
                {
                    GameObject clone = Instantiate(RedTruck, InstantiateLocation3.position, InstantiateLocation3.rotation);
                    clone.AddComponent<CivilianCarDestroy>();
                }
                if (carID == 13)
                {
                    GameObject clone = Instantiate(YellowTruck, InstantiateLocation3.position, InstantiateLocation3.rotation);
                    clone.AddComponent<CivilianCarDestroy>();
                }
                if (carID == 14)
                {
                    GameObject clone = Instantiate(RedCar, InstantiateLocation1.position, InstantiateLocation1.rotation);
                    clone.AddComponent<CivilianCarDestroy>();
                }
                if (carID == 15)
                {
                    GameObject clone = Instantiate(GreenCar, InstantiateLocation1.position, InstantiateLocation1.rotation);
                    clone.AddComponent<CivilianCarDestroy>();
                }
                if (carID == 16)
                {
                    GameObject clone = Instantiate(BlueCar, InstantiateLocation1.position, InstantiateLocation1.rotation);
                    clone.AddComponent<CivilianCarDestroy>();
                }
                if (carID == 17)
                {
                    GameObject clone = Instantiate(BrownCar, InstantiateLocation1.position, InstantiateLocation1.rotation);
                    clone.AddComponent<CivilianCarDestroy>();
                }
                if (carID == 18)
                {
                    GameObject clone = Instantiate(YellowCar, InstantiateLocation1.position, InstantiateLocation1.rotation);
                    clone.AddComponent<CivilianCarDestroy>();
                }

            }
        }

        

    }
    //select a random car based on a number that is selected

    IEnumerator CarIdSelect()
    {
        carID = Random.Range(1, 19);
        CarIdGenerate = false;                      
        yield return new WaitForSeconds(pattern.spawntime);    // Do the function, make the bool false, and make it true in two seconds, or the time between car spawnings.
        CarIdGenerate = true;
    }

    


}
