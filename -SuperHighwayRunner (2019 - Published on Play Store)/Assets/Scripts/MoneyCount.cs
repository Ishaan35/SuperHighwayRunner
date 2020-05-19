using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyCount : MonoBehaviour
{
    
    
    private void FixedUpdate()
    {
        
    }

    public Text Money;

    public static int Moneycount;

    
     

    // Start is called before the first frame update
    void Start()
    {
        LoadPlayer(); //load player in start
    }

    // Update is called once per frame
    void Update()
    {



        Money.text = Moneycount.ToString("0"); //displays money
       
    }

    public void Saveplayer() //call the saveplayer function
    {
        Save.SavePlayer(this);
    }
    public void LoadPlayer() //load all the sets and set moneycount to the money amount inside the data
    {
        Stats data = Save.LoadPlayer();

        Moneycount = data.MONEY;
    }

}
