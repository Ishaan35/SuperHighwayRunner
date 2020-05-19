using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    AudioSource audiosource;
    public float startpitch = 0.25f;
    public StopCar stopcar;
    public bool Stopsoundenabled = true;
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();

        audiosource.pitch = startpitch;

        StartCoroutine(AccelerateSound());
    }

    // Update is called once per frame
    void Update()
    {
        if (stopcar.Moving == false)
        {
            if(Stopsoundenabled == true)
            {
                StartCoroutine(StoppingSound());
                Stopsoundenabled = false;
            }
           
        }
    }

    IEnumerator AccelerateSound()
    {
        for(int i = 0; i < 20; i++)
        {
            audiosource.pitch = audiosource.pitch + 0.035f;
            yield return new WaitForSeconds(0.12f);
        }
        
    }

    IEnumerator StoppingSound()
    {
           

            
                for (int j = 0; j < 21; j++)
                {
                    audiosource.pitch = audiosource.pitch - 0.041f;
                    yield return new WaitForSeconds(0.13f);
                }
                

           
        
    }

    
}
