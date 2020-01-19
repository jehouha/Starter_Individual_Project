using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject life1, life2, life3, life4;
    public static int lives;

    // Start is called before the first frame update
    void Start()
    {
        lives = 4;
        life1.SetActive(true);
        life2.SetActive(true);
        life3.SetActive(true);
        life4.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        switch(lives)
            {
            case 4:
                    life1.SetActive(true);
                    life2.SetActive(true);
                    life3.SetActive(true);
                    break;
            case 3:
                    life1.SetActive(true);
                    life2.SetActive(true);
                    life3.SetActive(true);
                    break;
                case 2:
                    life1.SetActive(false);
                    life2.SetActive(true);
                    life3.SetActive(true);
                    break;
                case 1:
                    life1.SetActive(false);
                    life2.SetActive(false);
                    life3.SetActive(true);
                    break;
                case 0:
                    life1.SetActive(false);
                    life2.SetActive(false);
                    life3.SetActive(false);
                    //Time.timeScale = 0;
                    break;
            }
        
    }
}
