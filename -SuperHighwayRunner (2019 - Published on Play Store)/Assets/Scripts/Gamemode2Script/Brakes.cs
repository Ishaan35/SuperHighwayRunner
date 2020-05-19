
using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using UnityEngine.UI;

public class Brakes : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{

    public bool Pressed;

    public Image BrakePad;

    public float Brakefill = 1;

    public float BrakeAvailable;

    public PlayerMove playermove;


    // Use this for initialization
    void Start()
    {
 


    }

    // Update is called once per frame
    void Update()
    {

        if (Pressed == true && BrakeAvailable > 0)
        {
            StartCoroutine(brakes());
        }
        if (Pressed == false)
        {
            BrakePlus();
        }
        

        BrakeAvailable = BrakePad.fillAmount;
        
    }


    public void OnPointerDown(PointerEventData eventData)
    {

        Pressed = true;
        {

     

        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Pressed = false;

    }

    IEnumerator brakes()
    {
        if (playermove.speed > 8)
        {
            
            {
                playermove.speed = playermove.speed - 0.2f;
                BrakePad.fillAmount -= 1 / Brakefill * Time.deltaTime; 
                yield return new WaitForSeconds(0.1f);
            }
            
        }
    }

    void BrakePlus()
    {
        BrakePad.fillAmount += 0.001f;
    }
}