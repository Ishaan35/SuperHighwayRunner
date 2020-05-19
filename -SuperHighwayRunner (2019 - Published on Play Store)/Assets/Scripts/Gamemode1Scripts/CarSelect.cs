using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CarSelect : MonoBehaviour
{
    public static int SelectCarId;

    //cars list
    public GameObject YellowCarDisplay;
    public GameObject F1CarDisplay;
    public GameObject MuscleCarDisplay;
    public GameObject HellcatDisplay;
    public GameObject CamaroDisplay;
    public GameObject Mustangdisplay;
    public GameObject CorvetteStingray;
    public GameObject Mclaren;
    public GameObject Lamborghini;

    //starting game botton
    public Button NextButton;

    //locked image to indicate cars not purchased
    public Image Locked;

    public GameObject F1CarPurchase;
    public GameObject MuscleCarPurchase;
    public GameObject HellcatPurchase;
    public GameObject CamaroPurchase;
    public GameObject MustangPurchase;
    public GameObject StingrayPurchase;
    public GameObject MclarenPurchase;
    public GameObject LamborghiniPurchase;

    public GameObject  Right;
    public GameObject Left;


    // Start is called before the first frame update
    void Start()
    {
        
        


    }

    private void OnTriggerEnter(Collider other)
    {
        //if 
        if (other.gameObject.tag == "YellowCarSelect")
        {
            SelectCarId = 1;
            Left.SetActive(false);
            YellowCarDisplay.SetActive(true);
            F1CarDisplay.SetActive(false);
            MuscleCarDisplay.SetActive(false);
            HellcatDisplay.SetActive(false);
            CamaroDisplay.SetActive(false);
            Mustangdisplay.SetActive(false);
            CorvetteStingray.SetActive(false);
            Mclaren.SetActive(false);
            Lamborghini.SetActive(false);

            NextButton.enabled = true;
            Locked.enabled = false;

            F1CarPurchase.SetActive(false);
            MuscleCarPurchase.SetActive(false);
            HellcatPurchase.SetActive(false);
            CamaroPurchase.SetActive(false);
            MustangPurchase.SetActive(false);
            StingrayPurchase.SetActive(false);
            MclarenPurchase.SetActive(false);
            LamborghiniPurchase.SetActive(false);
        }
        if (other.gameObject.tag == "F1CarSelect")
        {
            //make this static int representing car id to 2, since this is second car, and disable every other car on the display platform
            SelectCarId = 2;
            Left.SetActive(true);
            YellowCarDisplay.SetActive(false);
            F1CarDisplay.SetActive(true);
            MuscleCarDisplay.SetActive(false);
            HellcatDisplay.SetActive(false);
            CamaroDisplay.SetActive(false);
            Mustangdisplay.SetActive(false);
            CorvetteStingray.SetActive(false);
            Mclaren.SetActive(false);
            Lamborghini.SetActive(false);

            if (UnlockingCar.F1CarIsLocked == true) //unlocking car is script that handles purchases and records of different cars this type of code in this script is similar for all cars
            {
                //if the car is not purchased
                NextButton.enabled = false; //cannot start game, so button gameobject is disabled
                Locked.enabled = true; //locked image true
                F1CarPurchase.SetActive(true); //purchase prompt is active

            } 
            if (UnlockingCar.F1CarIsLocked == false) //if unlocked, do opposite of previous
            {
                NextButton.enabled = true; 
                F1CarPurchase.SetActive(false);
                Locked.enabled = false;
            }
            //deactivate all other car purchase buttons
            MuscleCarPurchase.SetActive(false);
            HellcatPurchase.SetActive(false);
            CamaroPurchase.SetActive(false);
            MustangPurchase.SetActive(false);
            StingrayPurchase.SetActive(false);
            MclarenPurchase.SetActive(false);
            LamborghiniPurchase.SetActive(false);
        }
        if (other.gameObject.tag == "MuscleCarSelect")
        {
            SelectCarId = 3;
            YellowCarDisplay.SetActive(false);
            F1CarDisplay.SetActive(false);
            MuscleCarDisplay.SetActive(true);
            HellcatDisplay.SetActive(false);
            CamaroDisplay.SetActive(false);
            Mustangdisplay.SetActive(false);
            CorvetteStingray.SetActive(false);
            Mclaren.SetActive(false);
            Lamborghini.SetActive(false);

            if (UnlockingCar.MuscleCarIsLocked == true)
            {
                NextButton.enabled = false;
                Locked.enabled = true;
                MuscleCarPurchase.SetActive(true);
            }
            if (UnlockingCar.MuscleCarIsLocked == false)
            {
                NextButton.enabled = true;
                Locked.enabled = false;
                MuscleCarPurchase.SetActive(false);
            }

            F1CarPurchase.SetActive(false);
            HellcatPurchase.SetActive(false);
            CamaroPurchase.SetActive(false);
            MustangPurchase.SetActive(false);
            StingrayPurchase.SetActive(false);
            MclarenPurchase.SetActive(false);
            LamborghiniPurchase.SetActive(false);

        }
        if (other.gameObject.tag == "HellcatSelect")
        {
            SelectCarId = 4;
            YellowCarDisplay.SetActive(false);
            F1CarDisplay.SetActive(false);
            MuscleCarDisplay.SetActive(false);
            HellcatDisplay.SetActive(true);
            CamaroDisplay.SetActive(false);
            Mustangdisplay.SetActive(false);
            CorvetteStingray.SetActive(false);
            Mclaren.SetActive(false);
            Lamborghini.SetActive(false);

            if (UnlockingCar.DodgeHellcatCarIsLocked == true)
            {
                NextButton.enabled = false;
                Locked.enabled = true;
                HellcatPurchase.SetActive(true);
            }
            if (UnlockingCar.DodgeHellcatCarIsLocked == false)
            {
                NextButton.enabled = true;
                Locked.enabled = false;
                HellcatPurchase.SetActive(false);
            }


            F1CarPurchase.SetActive(false);
            MuscleCarPurchase.SetActive(false);
            CamaroPurchase.SetActive(false);
            MustangPurchase.SetActive(false);
            StingrayPurchase.SetActive(false);
            MclarenPurchase.SetActive(false);
            LamborghiniPurchase.SetActive(false);
        }
        if (other.gameObject.tag == "Camaro")
        {
            SelectCarId = 5;
            YellowCarDisplay.SetActive(false);
            F1CarDisplay.SetActive(false);
            MuscleCarDisplay.SetActive(false);
            HellcatDisplay.SetActive(false);
            CamaroDisplay.SetActive(true);
            Mustangdisplay.SetActive(false);
            Mclaren.SetActive(false);
            Lamborghini.SetActive(false);



            if (UnlockingCar.CamaroCarIsLocked == true)
            {
                NextButton.enabled = false;
                Locked.enabled = true;
                CamaroPurchase.SetActive(true);
            }
            if (UnlockingCar.CamaroCarIsLocked == false)
            {
                NextButton.enabled = true;
                Locked.enabled = false;
                CamaroPurchase.SetActive(false);
            }

            F1CarPurchase.SetActive(false);
            MuscleCarPurchase.SetActive(false);
            HellcatPurchase.SetActive(false);
            MustangPurchase.SetActive(false);
            StingrayPurchase.SetActive(false);
            MclarenPurchase.SetActive(false);
            LamborghiniPurchase.SetActive(false);
        }
        if (other.gameObject.tag == "Mustang")
        {
            SelectCarId = 6;
            YellowCarDisplay.SetActive(false);
            F1CarDisplay.SetActive(false);
            MuscleCarDisplay.SetActive(false);
            HellcatDisplay.SetActive(false);
            CamaroDisplay.SetActive(false);
            Mustangdisplay.SetActive(true);
            CorvetteStingray.SetActive(false);
            Mclaren.SetActive(false);
            Lamborghini.SetActive(false);


            if (UnlockingCar.MustangCarIsLocked == true)
            {
                NextButton.enabled = false;
                Locked.enabled = true;
                MustangPurchase.SetActive(true);
            }
            if (UnlockingCar.MustangCarIsLocked == false)
            {
                NextButton.enabled = true;
                Locked.enabled = false;
                MustangPurchase.SetActive(false);
            }

            F1CarPurchase.SetActive(false);
            MuscleCarPurchase.SetActive(false);
            HellcatPurchase.SetActive(false);
            CamaroPurchase.SetActive(false);
            StingrayPurchase.SetActive(false);
            MclarenPurchase.SetActive(false);
            LamborghiniPurchase.SetActive(false);
        }
        if (other.gameObject.tag == "CorvetteStingray")
        {
            SelectCarId = 7;
            YellowCarDisplay.SetActive(false);
            F1CarDisplay.SetActive(false);
            MuscleCarDisplay.SetActive(false);
            HellcatDisplay.SetActive(false);
            CamaroDisplay.SetActive(false);
            Mustangdisplay.SetActive(false);
            CorvetteStingray.SetActive(true);
            Mclaren.SetActive(false);
            Lamborghini.SetActive(false);


            if (UnlockingCar.StingrayCarIsLocked == true)
            {
                NextButton.enabled = false;
                Locked.enabled = true;
                StingrayPurchase.SetActive(true);
            }
            if (UnlockingCar.StingrayCarIsLocked == false)
            {
                NextButton.enabled = true;
                Locked.enabled = false;
                StingrayPurchase.SetActive(false);
            }

            F1CarPurchase.SetActive(false);
            MuscleCarPurchase.SetActive(false);
            HellcatPurchase.SetActive(false);
            CamaroPurchase.SetActive(false);
            MustangPurchase.SetActive(false);
            MclarenPurchase.SetActive(false);
            LamborghiniPurchase.SetActive(false);
        }
        if (other.gameObject.tag == "Mclaren")
        {
            SelectCarId = 8;
            Right.SetActive(true);
            YellowCarDisplay.SetActive(false);
            F1CarDisplay.SetActive(false);
            MuscleCarDisplay.SetActive(false);
            HellcatDisplay.SetActive(false);
            CamaroDisplay.SetActive(false);
            Mustangdisplay.SetActive(false);
            CorvetteStingray.SetActive(false);
            Mclaren.SetActive(true);
            Lamborghini.SetActive(false);


            if (UnlockingCar.MclarenCarIsLocked == true)
            {
                NextButton.enabled = false;
                Locked.enabled = true;
                MclarenPurchase.SetActive(true);
            }
            if (UnlockingCar.MclarenCarIsLocked == false)
            {
                NextButton.enabled = true;
                Locked.enabled = false;
                MclarenPurchase.SetActive(false);
            }

            F1CarPurchase.SetActive(false);
            MuscleCarPurchase.SetActive(false);
            HellcatPurchase.SetActive(false);
            CamaroPurchase.SetActive(false);
            StingrayPurchase.SetActive(false);
            MustangPurchase.SetActive(false);
            LamborghiniPurchase.SetActive(false);
            
        }
        if (other.gameObject.tag == "Lamborghini")
        {
            SelectCarId = 9;
            Right.SetActive(false);
            YellowCarDisplay.SetActive(false);
            F1CarDisplay.SetActive(false);
            MuscleCarDisplay.SetActive(false);
            HellcatDisplay.SetActive(false);
            CamaroDisplay.SetActive(false);
            Mustangdisplay.SetActive(false);
            CorvetteStingray.SetActive(false);
            Mclaren.SetActive(false);
            Lamborghini.SetActive(true);


            if (UnlockingCar.LamborghiniIsLocked == true)
            {
                NextButton.enabled = false;
                Locked.enabled = true;
                LamborghiniPurchase.SetActive(true);
            }
            if (UnlockingCar.LamborghiniIsLocked == false)
            {
                NextButton.enabled = true;
                Locked.enabled = false;
                LamborghiniPurchase.SetActive(false);
            }

            F1CarPurchase.SetActive(false);
            MuscleCarPurchase.SetActive(false);
            HellcatPurchase.SetActive(false);
            CamaroPurchase.SetActive(false);
            StingrayPurchase.SetActive(false);
            MclarenPurchase.SetActive(false);
            MustangPurchase.SetActive(false);
            

        }

        

    }
}

