using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarActiveDetector : MonoBehaviour
{
    public GameObject Yellowcar;
    public AudioSource yellowcaraudio;
    public GameObject F1Car;
    public AudioSource F1audio;
    public GameObject MuscleCar;
    public AudioSource musclecaraudio;
    public GameObject DodgeHellcat;
    public AudioSource DodgeHellcatAudio;
    public GameObject Camaro;
    public GameObject Mustang;
    public GameObject Stingray;
    public GameObject Mclaren;
    public GameObject Lamborghini;

    // Start is called before the first frame update
    void Start()
    {
        //depending on which car enters the trigger in the selection bars, that car will display on the display platform. The selectcarid is set in the car select script, depending on tags
        if (CarSelect.SelectCarId == 1)
        {
            Yellowcar.SetActive(true);
            yellowcaraudio.enabled = true;
            F1Car.SetActive(false);
            F1audio.enabled = false;
            MuscleCar.SetActive(false);
            musclecaraudio.enabled = false;
            DodgeHellcat.SetActive(false);
            DodgeHellcatAudio.enabled = false;
            Camaro.SetActive(false);
            Mustang.SetActive(false);
            Stingray.SetActive(false);
            Mclaren.SetActive(false);
            Lamborghini.SetActive(false);
        }
        if (CarSelect.SelectCarId == 2)
        {
            Yellowcar.SetActive(false);
            yellowcaraudio.enabled = false;
            F1Car.SetActive(true);
            F1audio.enabled = true;
            MuscleCar.SetActive(false);
            musclecaraudio.enabled = false;
            DodgeHellcat.SetActive(false);
            DodgeHellcatAudio.enabled = false;
            Camaro.SetActive(false);
            Mustang.SetActive(false);
            Stingray.SetActive(false);
            Mclaren.SetActive(false);
            Lamborghini.SetActive(false);
        }
        if (CarSelect.SelectCarId == 3)
        {
            Yellowcar.SetActive(false);
            yellowcaraudio.enabled = false;
            F1Car.SetActive(false);
            F1audio.enabled = false;
            MuscleCar.SetActive(true);
            musclecaraudio.enabled = true;
            DodgeHellcat.SetActive(false);
            DodgeHellcatAudio.enabled = false;
            Camaro.SetActive(false);
            Mustang.SetActive(false);
            Stingray.SetActive(false);
            Mclaren.SetActive(false);
            Lamborghini.SetActive(false);
        }
        if (CarSelect.SelectCarId == 4)
        {
            Yellowcar.SetActive(false);
            yellowcaraudio.enabled = false;
            F1Car.SetActive(false);
            F1audio.enabled = false;
            MuscleCar.SetActive(false);
            musclecaraudio.enabled = false;
            DodgeHellcat.SetActive(true);
            DodgeHellcatAudio.enabled = true;
            Camaro.SetActive(false);
            Mustang.SetActive(false);
            Stingray.SetActive(false);
            Mclaren.SetActive(false);
            Lamborghini.SetActive(false);
        }
        if (CarSelect.SelectCarId == 5)
        {
            Yellowcar.SetActive(false);
            yellowcaraudio.enabled = false;
            F1Car.SetActive(false);
            F1audio.enabled = false;
            MuscleCar.SetActive(false);
            musclecaraudio.enabled = false;
            DodgeHellcat.SetActive(false);
            DodgeHellcatAudio.enabled = false;
            Camaro.SetActive(true);
            Mustang.SetActive(false);
            Stingray.SetActive(false);
            Mclaren.SetActive(false);
            Lamborghini.SetActive(false);
        }
        if (CarSelect.SelectCarId == 6)
        {
            Yellowcar.SetActive(false);
            yellowcaraudio.enabled = false;
            F1Car.SetActive(false);
            F1audio.enabled = false;
            MuscleCar.SetActive(false);
            musclecaraudio.enabled = false;
            DodgeHellcat.SetActive(false);
            DodgeHellcatAudio.enabled = false;
            Camaro.SetActive(false);
            Mustang.SetActive(true);
            Stingray.SetActive(false);
            Mclaren.SetActive(false);
            Lamborghini.SetActive(false);
        }
        if (CarSelect.SelectCarId == 7)
        {
            Yellowcar.SetActive(false);
            yellowcaraudio.enabled = false;
            F1Car.SetActive(false);
            F1audio.enabled = false;
            MuscleCar.SetActive(false);
            musclecaraudio.enabled = false;
            DodgeHellcat.SetActive(false);
            DodgeHellcatAudio.enabled = false;
            Camaro.SetActive(false);
            Mustang.SetActive(false);
            Stingray.SetActive(true);
            Mclaren.SetActive(false);
            Lamborghini.SetActive(false);
        }
        if (CarSelect.SelectCarId == 8)
        {
            Yellowcar.SetActive(false);
            yellowcaraudio.enabled = false;
            F1Car.SetActive(false);
            F1audio.enabled = false;
            MuscleCar.SetActive(false);
            musclecaraudio.enabled = false;
            DodgeHellcat.SetActive(false);
            DodgeHellcatAudio.enabled = false;
            Camaro.SetActive(false);
            Mustang.SetActive(false);
            Stingray.SetActive(false);
            Mclaren.SetActive(true);
            Lamborghini.SetActive(false);
        }
        if (CarSelect.SelectCarId == 9)
        {
            Yellowcar.SetActive(false);
            yellowcaraudio.enabled = false;
            F1Car.SetActive(false);
            F1audio.enabled = false;
            MuscleCar.SetActive(false);
            musclecaraudio.enabled = false;
            DodgeHellcat.SetActive(false);
            DodgeHellcatAudio.enabled = false;
            Camaro.SetActive(false);
            Mustang.SetActive(false);
            Stingray.SetActive(false);
            Mclaren.SetActive(false);
            Lamborghini.SetActive(true);
            
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
