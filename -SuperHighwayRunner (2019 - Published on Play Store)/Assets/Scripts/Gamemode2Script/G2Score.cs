using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class G2Score : MonoBehaviour
{
    public Transform player;
    public Text score;
    public static float G2Scorenumber;

    public Animator BonusAnim;

    public PlayerMove playermove;

    public float Bonus;

    public Text HighscoreG2;
    

    // Start is called before the first frame update
    void Start()
    {
        Bonus = 0;
        HighscoreG2.text = PlayerPrefs.GetFloat("HighscoreG2", 0).ToString("0");

    }

    // Update is called once per frame
    void Update()
    {

        if (playermove.PLAYERMOVING == true)
        {
            G2Scorenumber = player.position.z - 2.53f + Bonus;
            score.text = (G2Scorenumber).ToString("0");
        }
        if (G2Scorenumber > PlayerPrefs.GetFloat("HighscoreG2", 0))
        {
            PlayerPrefs.SetFloat("HighscoreG2", G2Scorenumber);
            HighscoreG2.text = G2Scorenumber.ToString("0");
        }

        

        if (playermove.speed >= 14)
        {
            BonusAnim.SetBool("Bonus", true);
            Bonus = 2;
            
        }
        if (playermove.speed < 14)
        {
            Bonus = 0;
            BonusAnim.SetBool("Bonus", false);
        }

    }
}
