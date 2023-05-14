using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetScore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            GameManager.Instance.musicGame.Point.Play();
            GameManager.Instance.hightCore.Point++;
            GameManager.Instance.hightCore.txt_Point.text = GameManager.Instance.hightCore.Point.ToString();
        }
    }
}
