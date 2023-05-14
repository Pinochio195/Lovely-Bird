using System;
using System.Collections;
using System.Collections.Generic;
using Lean.Pool;
using UnityEngine;

public class SpawnGround : MonoBehaviour
{
    public float moveSpeed; // Tốc độ di chuyển của ground
    public GameObject spawnOffset; // Khoảng cách giữa hai ground được tạo liên tiếp
    public GameObject prefabs_Ground;
    private GameObject spawn_Ground;

    private void Awake()
    {
        SpawnNextGround();
    }


    private void Update()
    {
        if (spawn_Ground.transform.position.x <= spawnOffset.transform.position.x)
        {
            SpawnNextGround();
        }
    }

    private void SpawnNextGround()
    {
        // Tạo ground mới bằng cách sao chép Prefab
        spawn_Ground = LeanPool.Spawn(prefabs_Ground, transform.position, Quaternion.identity);
        LeanPool.Despawn(spawn_Ground, 4);
    }
}