using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Stats
{
    public int MONEY;
    public bool F1;
    public bool MuscleCar;
    public bool Hellcat;
    public bool Camaro;
    public bool Mustang;
    public bool Stingray;
    public bool Mclaren;
    public bool Lamborghini;

    public bool INTRODUCTION;

    public Stats(MoneyCount MoneyAmount)
    {
        MONEY = MoneyCount.Moneycount;
        F1 = UnlockingCar.F1CarIsLocked;
        MuscleCar = UnlockingCar.MuscleCarIsLocked;
        Hellcat = UnlockingCar.DodgeHellcatCarIsLocked;
        Camaro = UnlockingCar.CamaroCarIsLocked;
        Mustang = UnlockingCar.MustangCarIsLocked;
        Stingray = UnlockingCar.StingrayCarIsLocked;
        Mclaren = UnlockingCar.MclarenCarIsLocked;
        Lamborghini = UnlockingCar.LamborghiniIsLocked;
        
    }
}
