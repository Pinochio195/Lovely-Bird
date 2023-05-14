using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBird : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.GameOver();
        }
    }
}
