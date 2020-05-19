using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanePatternsVariable : MonoBehaviour
{

    public Transform Player;

    public int LanePatternIndicator;

    public int FuelPatternIndicator;

    public int MoneyPatternIndicator;

    public float spawntime = 5f;

    public float FuelSpawnTimer = 0;

    public Transform Fuel1;
    public Transform Fuel2;
    public Transform Fuel3;

    public Transform Money1;
    public Transform Money2;
    public Transform Money3;


    public GameObject FuelCan;
    public GameObject Money;
    public Transform Money_;

    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("Patternnumberselection", 1f, spawntime); // selecting patter variable later to be used in the civilian spawn scripts
        //also incorporated fuel and money spawning in this 
        InvokeRepeating("SpawnFuel", 1f, 10);
        InvokeRepeating("SpawnMoney", 1f, 5);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void Patternnumberselection()
    {
        LanePatternIndicator = Random.Range(1, 6); //5 different car orientation patterns to choose from : left lane, middle lane, right lane, left+middle lane, right+midle lane. This is why some civilian spawn scipts have a pattern variable being equal to multiple numbers as conditions
        
    }

    void SpawnFuel()
    {
        FuelPatternIndicator = Random.Range(1, 4); //1-3 inclusive representing either one of three lanes
        if (FuelPatternIndicator == 1)
        {
            Instantiate(FuelCan, Fuel1.transform.position += new Vector3(0, 0, 0), Fuel1.rotation);
        }
        if (FuelPatternIndicator == 2)
        {
            Instantiate(FuelCan, Fuel2.transform.position += new Vector3(0, 0, 0), Fuel2.rotation);
        }
        if (FuelPatternIndicator == 3)
        {
            Instantiate(FuelCan, Fuel3.transform.position += new Vector3(0, 0, 0), Fuel3.rotation);
        }
    }

    void SpawnMoney()
    {
        MoneyPatternIndicator = Random.Range(1, 4); //same concept as fuel
        if (MoneyPatternIndicator == 1)
        {
            Instantiate(Money, Money1.transform.position += new Vector3(0, 0, 0), Money_.rotation);
        }
        if (MoneyPatternIndicator == 2)
        {
            Instantiate(Money, Money2.transform.position += new Vector3(0, 0, 0), Money_.rotation);
        }
        if (MoneyPatternIndicator == 3)
        {
            Instantiate(Money, Money3.transform.position += new Vector3(0, 0, 0), Money_.rotation);
        }
    }








}
