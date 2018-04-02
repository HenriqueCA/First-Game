﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public Transform[] spawns;

    public GameObject block;

    private float timeToSpawn = 2f;

    private float timeBetweenWaves = 1.1f;

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= timeToSpawn)
        {
            SpawnBlocks();
            timeToSpawn = Time.time + timeBetweenWaves;
        }

    }

    void SpawnBlocks()
    {
        int random = Random.Range(0, spawns.Length);

        for (int i = 0; i < spawns.Length; i++)
        {
            if (i != random)
            {
                Instantiate(block, spawns[i].position, Quaternion.identity);
            }

        }
    }
}