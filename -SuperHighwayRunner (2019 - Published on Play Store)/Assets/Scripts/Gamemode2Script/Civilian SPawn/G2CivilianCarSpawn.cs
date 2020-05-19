using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class G2CivilianCarSpawn : MonoBehaviour
{
    public G2LanePatternVariable g2lane;

    public Transform InstantiateLocation1;
    public Transform InstantiateLocation2;
    public Transform InstantiateLocation3;
    public Transform Truck;

    public int carID;

    public bool abletospawn = true;
    public bool CarIdGenerate = true;

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
    void Update()
    {
        if (g2lane.LanePatternIndicator == 1 || g2lane.LanePatternIndicator == 3 || g2lane.LanePatternIndicator == 5)
        {
            if (CarIdGenerate == true)
            {
                StartCoroutine(CarIdSelect());
                if (carID == 1)
                {
                    GameObject clone = Instantiate(BlueBus, InstantiateLocation1.position, InstantiateLocation1.rotation);
                    clone.AddComponent<CivilianCarDestroy2>();
                }
                if (carID == 2)
                {
                    GameObject clone = Instantiate(GreenBus, InstantiateLocation1.position, InstantiateLocation1.rotation);
                    clone.AddComponent<CivilianCarDestroy2>();
                }
                if (carID == 3)
                {
                    GameObject clone = Instantiate(OrangeBus, InstantiateLocation1.position, InstantiateLocation1.rotation);
                    clone.AddComponent<CivilianCarDestroy2>();
                }
                if (carID == 4)
                {
                    GameObject clone = Instantiate(YellowBus, InstantiateLocation1.position, InstantiateLocation1.rotation);
                    clone.AddComponent<CivilianCarDestroy2>();
                }
                if (carID == 5)
                {
                    GameObject clone = Instantiate(RedBus, InstantiateLocation1.position, InstantiateLocation1.rotation);
                    clone.AddComponent<CivilianCarDestroy2>();
                }
                if (carID == 6)
                {
                    GameObject clone = Instantiate(BlueBoxTruck, InstantiateLocation2.transform.position, Truck.transform.rotation);
                    clone.AddComponent<CivilianCarDestroy2>();
                }
                if (carID == 7)
                {
                    GameObject clone = Instantiate(GreenBoxTruck, InstantiateLocation2.transform.position, Truck.transform.rotation);
                    clone.AddComponent<CivilianCarDestroy2>();
                }
                if (carID == 8)
                {
                    GameObject clone = Instantiate(OrangeBoxTruck, InstantiateLocation2.transform.position, Truck.transform.rotation);
                    clone.AddComponent<CivilianCarDestroy2>();
                }
                if (carID == 9)
                {
                    GameObject clone = Instantiate(PurpleBoxTruck, InstantiateLocation2.transform.position, Truck.transform.rotation);
                    clone.AddComponent<CivilianCarDestroy2>();
                }
                if (carID == 10)
                {
                    GameObject clone = Instantiate(BlueTruck, InstantiateLocation3.position, InstantiateLocation3.rotation);
                    clone.AddComponent<CivilianCarDestroy2>();
                }
                if (carID == 11)
                {
                    GameObject clone = Instantiate(GreenTruck, InstantiateLocation3.position, InstantiateLocation3.rotation);
                    clone.AddComponent<CivilianCarDestroy2>();
                }
                if (carID == 12)
                {
                    GameObject clone = Instantiate(RedTruck, InstantiateLocation3.position, InstantiateLocation3.rotation);
                    clone.AddComponent<CivilianCarDestroy2>();
                }
                if (carID == 13)
                {
                    GameObject clone = Instantiate(YellowTruck, InstantiateLocation3.position, InstantiateLocation3.rotation);
                    clone.AddComponent<CivilianCarDestroy2>();
                }
                if (carID == 14)
                {
                    GameObject clone = Instantiate(RedCar, InstantiateLocation1.position, InstantiateLocation1.rotation);
                    clone.AddComponent<CivilianCarDestroy2>();
                }
                if (carID == 15)
                {
                    GameObject clone = Instantiate(GreenCar, InstantiateLocation1.position, InstantiateLocation1.rotation);
                    clone.AddComponent<CivilianCarDestroy2>();
                }
                if (carID == 16)
                {
                    GameObject clone = Instantiate(BlueCar, InstantiateLocation1.position, InstantiateLocation1.rotation);
                    clone.AddComponent<CivilianCarDestroy2>();
                }
                if (carID == 17)
                {
                    GameObject clone = Instantiate(BrownCar, InstantiateLocation1.position, InstantiateLocation1.rotation);
                    clone.AddComponent<CivilianCarDestroy2>();
                }
                if (carID == 18)
                {
                    GameObject clone = Instantiate(YellowCar, InstantiateLocation1.position, InstantiateLocation1.rotation);
                    clone.AddComponent<CivilianCarDestroy2>();
                }

            }
        }

        IEnumerator CarIdSelect()
        {
            carID = Random.Range(1, 19);
            CarIdGenerate = false;
            yield return new WaitForSeconds(g2lane.timetospawn);    // Do the function, make the bool false, and make it true in two seconds, or the time between car spawnings.
            CarIdGenerate = true;
        }
    }

}
