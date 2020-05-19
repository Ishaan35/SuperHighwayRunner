using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeControls : MonoBehaviour
{

    private bool Tap;
    private bool swipeRight;
    private bool swipeLeft;
    private bool swipeUp;
    private bool swipeDown;
    private bool IsDragging = false;

    private Vector2 startTouch;
    private Vector2 swipeDelta;


 

    // Update is called once per frame
    private void Update()
    {
        Tap = swipeLeft = swipeRight = false;

        #region Standalone Inputs
        if (Input.GetMouseButtonDown(0))
        {
            Tap = true;
            IsDragging = true;
            startTouch = Input.mousePosition;
        }
        else if(Input.GetMouseButtonDown(0))
        {
            Reset();
            IsDragging = false;
        }
        #endregion

        #region Mobile Inputs
        if(Input.touches.Length > 0)
        {
            if(Input.touches[0].phase == TouchPhase.Began)
            {
                IsDragging = true;
                Tap = true;
                startTouch = Input.touches[0].position;
            }
            else if(Input.touches[0].phase == TouchPhase.Ended || Input.touches[0].phase == TouchPhase.Canceled)
            {
                Reset();
                IsDragging = false;
            }
        }


        #endregion

        //Calculate Distance

        swipeDelta = Vector2.zero;
        if (IsDragging)
        {
            if(Input.touches.Length > 0)
                swipeDelta = Input.touches[0].position - startTouch;
            else if (Input.GetMouseButton(0))           
                swipeDelta = (Vector2)Input.mousePosition - startTouch;
           
        }

        //Did we cross deadzone
        if(swipeDelta.magnitude > 1)
        {
            // Which direction

            float x = swipeDelta.x;
            float y = swipeDelta.y;
            if(Mathf.Abs(x) > Mathf.Abs(y))
            {
                //Left or Right
                if(x < 0)
                {
                    swipeLeft = true;
                }
                else
                {
                    swipeRight = true;
                }
            }
            else
            {
                //Up or down
                if (y < 0)
                {
                    swipeDown = true;
                }
                else
                {
                    swipeUp = true;
                }
            }

            Reset();
        }
    }

    private void Reset()
    {
        startTouch = swipeDelta = Vector2.zero;
        IsDragging = false;
    }

    public Vector2 SwipeDelta { get { return swipeDelta; } }
    public bool SwipeLeft { get { return swipeLeft; } }
    public bool SwipeRight { get { return swipeRight; } }
    public bool SwipeUp { get { return swipeUp; } }
    public bool SwipeDown { get { return swipeDown; } }
}
