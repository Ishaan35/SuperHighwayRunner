using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockingCar : MonoBehaviour
{
    public static bool F1CarIsLocked;
    public static bool MuscleCarIsLocked;
    public static bool DodgeHellcatCarIsLocked;
    public static bool CamaroCarIsLocked;
    public static bool MustangCarIsLocked;
    public static bool StingrayCarIsLocked;
    public static bool MclarenCarIsLocked;
    public static bool LamborghiniIsLocked;

    public Button NextButton;

    public Image Locked;

    public GameObject F1CarPurchase;
    public GameObject MuscleCarPurchase;
    public GameObject HellcatPurchase;
    public GameObject CamaroPurchase;
    public GameObject MustangPurchase;
    public GameObject StingrayPurchase;
    public GameObject MclarenPurchase;
    public GameObject LamborghiniPurchase;

    // Start is called before the first frame update
    void Start()
    {
        F1CarIsLocked = true;
        MuscleCarIsLocked = true;
        DodgeHellcatCarIsLocked = true;
        CamaroCarIsLocked = true;
        MustangCarIsLocked = true;
        StingrayCarIsLocked = true;
        MclarenCarIsLocked = true;
        LamborghiniIsLocked = true;
        LoadPlayer();
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void F1CarUnlock()
    {
        if (MoneyCount.Moneycount >=25)
        {
            F1CarIsLocked = false;
            MoneyCount.Moneycount -= 25;
            Locked.enabled = false;
            NextButton.enabled = true;
            F1CarPurchase.SetActive(false);
        }
        
    }
    public void MusclecarCarUnlock()
    {
        if (MoneyCount.Moneycount >= 50)
        {
            MuscleCarIsLocked = false;
            MoneyCount.Moneycount -= 50;
            Locked.enabled = false;
            NextButton.enabled = true;
            MuscleCarPurchase.SetActive(false);
        }
        
    }
    public void DodgeHellcatUnlock()
    {
        if (MoneyCount.Moneycount >= 75)
        {
            DodgeHellcatCarIsLocked = false;
            MoneyCount.Moneycount -= 75;
            Locked.enabled = false;
            NextButton.enabled = true;
            HellcatPurchase.SetActive(false);
        }
        
    }
    public void CamaroUnlock()
    {
        if (MoneyCount.Moneycount >= 100)
        {
            CamaroCarIsLocked = false;
            MoneyCount.Moneycount -= 100;
            Locked.enabled = false;
            NextButton.enabled = true;
            CamaroPurchase.SetActive(false);
        }
        
    }
    public void MustangUnlock()
    {
        if (MoneyCount.Moneycount >= 150)
        {
            MustangCarIsLocked = false;
            MoneyCount.Moneycount -= 150;
            Locked.enabled = false;
            NextButton.enabled = true;
            MustangPurchase.SetActive(false);
        }
            
    }
    public void StingrayUnlock()
    {
        if (MoneyCount.Moneycount >= 200)
        {
            StingrayCarIsLocked = false;
            MoneyCount.Moneycount -= 200;
            Locked.enabled = false;
            NextButton.enabled = true;
            StingrayPurchase.SetActive(false);
        }

        
    }
    public void MclarenUnlock()
    {
        if (MoneyCount.Moneycount >= 300)
        {
            MclarenCarIsLocked = false;
            MoneyCount.Moneycount -= 300;
            Locked.enabled = false;
            NextButton.enabled = true;
            MclarenPurchase.SetActive(false);
        }


    }
    public void LamborghiniUnlock()
    {
        if (MoneyCount.Moneycount >= 400)
        {
            LamborghiniIsLocked = false;
            MoneyCount.Moneycount -= 400;
            Locked.enabled = false;
            NextButton.enabled = true;
            LamborghiniPurchase.SetActive(false);
        }


    }

    public void LoadPlayer()
    {
        Stats data = Save.LoadPlayer();

        F1CarIsLocked = data.F1;
        MuscleCarIsLocked = data.MuscleCar;
        DodgeHellcatCarIsLocked = data.Hellcat;
        CamaroCarIsLocked = data.Camaro;
        MustangCarIsLocked = data.Mustang;
        StingrayCarIsLocked = data.Stingray;
        MclarenCarIsLocked = data.Mclaren;
        LamborghiniIsLocked = data.Lamborghini;
    }
}
