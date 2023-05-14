using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float velocity;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameManager.Instance.Bird.rigidbody.velocity = Vector2.up*velocity;
            GameManager.Instance.musicGame.Touch.Play();
            GameManager.Instance.PlayGame();
        }    
    }
}
