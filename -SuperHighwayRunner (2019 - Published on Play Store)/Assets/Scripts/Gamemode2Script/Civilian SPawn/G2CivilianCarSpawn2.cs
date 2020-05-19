using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class G2CivilianCarSpawn2 : MonoBehaviour
{
    public G2LanePatternVariable pattern;
    public int carID;

    public bool abletospawn = true;
    public bool CarIdGenerate = true;

    public Transform InstantiateLocation4;
    public Transform InstantiateLocation5;
    public Transform InstantiateLocation6;
    public Transform Truck;

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

    


    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update() // If the pattern of the vehicle allignment on road is 1, then it will choose a random int called carID, and if that is 1, it will spawn blue bus.
    {
        if (pattern.LanePatternIndicator == 2 || pattern.LanePatternIndicator == 4 || pattern.LanePatternIndicator == 5 || pattern.LanePatternIndicator == 6)
        {
            if (CarIdGenerate == true)
            {
                StartCoroutine(CarIdSelect());
                if (carID == 1)
                {
                    GameObject clone = Instantiate(BlueBus, InstantiateLocation4.position, InstantiateLocation4.rotation);
                    clone.AddComponent<CivilianCarDestroy2>();
                }
                if (carID == 2)
                {
                    GameObject clone = Instantiate(GreenBus, InstantiateLocation4.position, InstantiateLocation4.rotation);
                    clone.AddComponent<CivilianCarDestroy2>();
                }
                if (carID == 3)
                {
                    GameObject clone = Instantiate(OrangeBus, InstantiateLocation4.position, InstantiateLocation4.rotation);
                    clone.AddComponent<CivilianCarDestroy2>();
                }
                if (carID == 4)
                {
                    GameObject clone = Instantiate(YellowBus, InstantiateLocation4.position, InstantiateLocation4.rotation);
                    clone.AddComponent<CivilianCarDestroy2>();
                }
                if (carID == 5)
                {
                    GameObject clone = Instantiate(RedBus, InstantiateLocation4.position, InstantiateLocation4.rotation);
                    clone.AddComponent<CivilianCarDestroy2>();
                }
                if (carID == 6)
                {
                    GameObject clone = Instantiate(BlueBoxTruck, InstantiateLocation5.transform.position, Truck.transform.rotation);
                    clone.AddComponent<CivilianCarDestroy2>();
                }
                if (carID == 7)
                {
                    GameObject clone = Instantiate(GreenBoxTruck, InstantiateLocation5.transform.position, Truck.transform.rotation);
                    clone.AddComponent<CivilianCarDestroy2>();
                }
                if (carID == 8)
                {
                    GameObject clone = Instantiate(OrangeBoxTruck, InstantiateLocation5.transform.position, Truck.transform.rotation);
                    clone.AddComponent<CivilianCarDestroy2>();
                }
                if (carID == 9)
                {
                    GameObject clone = Instantiate(PurpleBoxTruck, InstantiateLocation5.transform.position, Truck.transform.rotation);
                    clone.AddComponent<CivilianCarDestroy2>();
                }
                if (carID == 10)
                {
                    GameObject clone = Instantiate(BlueTruck, InstantiateLocation6.position, InstantiateLocation6.rotation);
                    clone.AddComponent<CivilianCarDestroy2>();
                }
                if (carID == 11)
                {
                    GameObject clone = Instantiate(GreenTruck, InstantiateLocation6.position, InstantiateLocation6.rotation);
                    clone.AddComponent<CivilianCarDestroy2>();
                }
                if (carID == 12)
                {
                    GameObject clone = Instantiate(RedTruck, InstantiateLocation6.position, InstantiateLocation6.rotation);
                    clone.AddComponent<CivilianCarDestroy2>();
                }
                if (carID == 13)
                {
                    GameObject clone = Instantiate(YellowTruck, InstantiateLocation6.position, InstantiateLocation6.rotation);
                    clone.AddComponent<CivilianCarDestroy2>();
                }
                if (carID == 14)
                {
                    GameObject clone = Instantiate(RedCar, InstantiateLocation4.position, InstantiateLocation4.rotation);
                    clone.AddComponent<CivilianCarDestroy2>();
                }
                if (carID == 15)
                {
                    GameObject clone = Instantiate(GreenCar, InstantiateLocation4.position, InstantiateLocation4.rotation);
                    clone.AddComponent<CivilianCarDestroy2>();
                }
                if (carID == 16)
                {
                    GameObject clone = Instantiate(BlueCar, InstantiateLocation4.position, InstantiateLocation4.rotation);
                    clone.AddComponent<CivilianCarDestroy2>();
                }
                if (carID == 17)
                {
                    GameObject clone = Instantiate(BrownCar, InstantiateLocation4.position, InstantiateLocation4.rotation);
                    clone.AddComponent<CivilianCarDestroy2>();
                }
                if (carID == 18)
                {
                    GameObject clone = Instantiate(YellowCar, InstantiateLocation4.position, InstantiateLocation4.rotation);
                    clone.AddComponent<CivilianCarDestroy2>();
                }

            }
        }

        IEnumerator CarIdSelect()
        {
            carID = Random.Range(1, 19);
            CarIdGenerate = false;
            yield return new WaitForSeconds(pattern.timetospawn);    // Do the function, make the bool false, and make it true in two seconds, or the time between car spawnings.
            CarIdGenerate = true;
        }



    }

    
    



}
