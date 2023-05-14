using System.Collections;
using System.Collections.Generic;
using Lean.Pool;
using UnityEngine;

public class SpawnPipePrefabs : MonoBehaviour
{
    public GameObject prefabs_Pipe;
    public float maxTime;
    private float timer = 0;
    public float height;

    void Start()
    {
        LeanPool.Spawn(prefabs_Pipe, transform.position + new Vector3(0, Random.Range(-height, height), 0),
            Quaternion.identity);
        GameManager.Instance.isCheck = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.isCheck)
        {
            if (timer > maxTime)
            {
                GameObject A = LeanPool.Spawn(prefabs_Pipe,
                    transform.position + new Vector3(0, Random.Range(-height, height), 0),
                    Quaternion.identity);
                LeanPool.Despawn(A, 6);
                timer = 0;
            }

            timer += Time.deltaTime;
        }
    }
}