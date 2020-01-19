using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 12f;
    public static float deltaTime;
    public string winSoundName;

    [SerializeField]
    Text countdownText;
    [SerializeField]
    private GameObject gameWinUI;
    private AudioManager audioManager;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
        audioManager = AudioManager.instance;
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
        audioManager.PlaySound(winSoundName);
    }
}
