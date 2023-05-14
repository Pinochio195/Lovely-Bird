using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector2 = System.Numerics.Vector2;

public class MovePipe : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.isCheck)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
    }
}