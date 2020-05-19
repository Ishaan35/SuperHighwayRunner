using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class G2LanePatternVariable : MonoBehaviour
{
    public int LanePatternIndicator;

    public float timetospawn = 3;


    public GameObject Money;
    public Transform Money_;

    public Transform Money1;
    public Transform Money2;
    public Transform Money3;
    public Transform Money4;

    public PlayerMove playermove;

    public int MoneyPatternIndicator;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Patternnumberselection", 1f, timetospawn);
        InvokeRepeating("SpawnMoney", 1f, timetospawn);

    }

    // Update is called once per frame
    void Update()
    {
        if (playermove.speed >= 12)
        {
            timetospawn = 2;
        }
        
        if (playermove.speed <= 11)
        {
            timetospawn = 2;
        }
    }

    void Patternnumberselection()
    {
        LanePatternIndicator = Random.Range(1, 7);
    }

    void SpawnMoney()
    {
        MoneyPatternIndicator = Random.Range(1, 5);
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
        if (MoneyPatternIndicator == 4)
        {
            Instantiate(Money, Money4.transform.position += new Vector3(0, 0, 0), Money_.rotation);
        }
    }


}
