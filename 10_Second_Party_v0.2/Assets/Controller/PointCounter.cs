using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCounter : MonoBehaviour
{
    [SerializeField]
    private GameObject gameOverUI;
    public string loseSoundName;
    public string hitSoundName;

    private AudioManager audioManager;

    private Material matWhite;
    private Material matDefault;
    SpriteRenderer spriteRenderer;
    
    void Start()
    {
        audioManager = AudioManager.instance;
        spriteRenderer = GetComponent<SpriteRenderer>();
        matWhite = Resources.Load("WhiteFlash", typeof(Material)) as Material;
        matDefault = spriteRenderer.material;
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        TakeDamage();
        audioManager.PlaySound(hitSoundName);
        spriteRenderer.material = matWhite;
    }

    void ResetMaterial()
    {
        spriteRenderer.material = matDefault;
    }

    void TakeDamage()
    {
        GameController.lives--;
        Invoke("ResetMaterial", 0.1f);
        Debug.Log("Damage taken");
        if (GameController.lives <= 0)
        {
            EndGame();
        }
    }

    public void EndGame()
    {
        Debug.Log("GAME OVER");
        gameOverUI.SetActive(true);
        Time.timeScale = 0;
        audioManager.PlaySound(loseSoundName);
    }
}
