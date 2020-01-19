/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

//add the Timer
public class Timer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 10f;
    public static float deltaTime;

    [SerializeField]
    Text countdownText;
    [SerializeField]
    private GameObject gameWinUI;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {
            currentTime = 0;
            WinGame();
        }
    }
    public void WinGame()
    {
        Debug.Log("GAME WON");
        gameWinUI.SetActive(true);
        currentTime = startingTime;
        Time.timeScale = 0;
    }
}

//end game
public class GameEndUI : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("Game Quit");
        Application.Quit();
    }

    public void Retry()
    {
        Debug.Log("Game Restart");
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }
}

//track health
public class GameController : MonoBehaviour
{
    public GameObject life1, life2, life3;
    public static int lives;

    // Start is called before the first frame update
    void Start()
    {
        lives = 3;
        life1.SetActive(true);
        life2.SetActive(true);
        life3.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        switch (lives)
        {
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
}*/