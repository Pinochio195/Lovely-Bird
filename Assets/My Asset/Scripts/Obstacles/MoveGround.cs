using System.Collections;
using System.Collections.Generic;
using Lean.Pool;
using UnityEngine;

public class MoveGround : MonoBehaviour
{
    public float moveSpeed;
    // Update is called once per frame

    void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
    }
  
}
