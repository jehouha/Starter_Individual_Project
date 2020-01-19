using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCounter : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        GameController.lives -= 1;
    }
}
