using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGas : MonoBehaviour
{
    public Transform Player;
    public GameObject FuelCan;
    public GameObject Money;
    public StopCar stopcar;
    public MoneyCount moneycount;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(Player.position, FuelCan.transform.position) < 0.5)
        {
            stopcar.fuel = stopcar.fuel + 35;
            Destroy(FuelCan);
            
        }
        if (Vector3.Distance(Player.position, Money.transform.position) < 0.5)
        {
            Destroy(Money);

            MoneyCount.Moneycount++;
            





        }
    }

    
}
