using UnityEngine;

public class bgm : MonoBehaviour
{
    public string bgmSoundName;

    private AudioManager audioManager;

    // Start is called before the first frame update
    void Start()
    {
        audioManager = AudioManager.instance;
    }

    void Update()
    {
        //audioManager.PlaySound(bgmSoundName);
    }
}
