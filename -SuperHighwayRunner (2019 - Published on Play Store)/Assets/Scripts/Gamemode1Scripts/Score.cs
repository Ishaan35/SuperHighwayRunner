using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public StopCar stopcar;


    public Text score;
    public static float Scorenumber;
    

    public Text highscore;



    // Start is called before the first frame update
    void Start()
    {
        highscore.text = PlayerPrefs.GetFloat("Highscore", 0).ToString("0");
    }

    // Update is called once per frame
    void Update()
    {
        if (stopcar.Moving == true)
        {
            Scorenumber = player.position.z - 2.53f;
            score.text = (Scorenumber).ToString("0");
        }
        if (Scorenumber > PlayerPrefs.GetFloat("Highscore", 0))
        {
            PlayerPrefs.SetFloat("Highscore", Scorenumber);
            highscore.text = Scorenumber.ToString("0");
        }
        

    }
}
