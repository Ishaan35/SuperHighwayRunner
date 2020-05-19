using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyIntroduction : MonoBehaviour
{

    //an unused component of this game. I was going to add n introduction about me, but scraped the idea after realizing that I can publish this on the playstore
    public static MyIntroduction Instance;

    public static bool IntroEnabled;

    public GameObject Panel;

    public Canvas Introduction;

    public Animator IntroductionAnim;

    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        IntroEnabled = true;

        if (IntroEnabled == false)
        {
            Panel.SetActive(false);

        }
        if (IntroEnabled == true)
        {
            Panel.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OKBUTTON()
    {
        IntroductionAnim.SetBool("OkButtonPressed", true);
        IntroEnabled = false;

    }
}

