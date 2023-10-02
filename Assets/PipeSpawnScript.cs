using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float HeightOffset = 7.5f;
    public float Distance = 5;
    public LogicScript LogicScript;
    private GameObject latestPipe_;



    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (latestPipe_.transform.localPosition.x < Distance)
        {
            SpawnPipe();
        }

    }

    void SpawnPipe()
    {
        
        latestPipe_ = Instantiate(pipe, new Vector3(transform.position.x, Random.Range(-1 * HeightOffset, HeightOffset), 0), transform.rotation);
        var logicScript = latestPipe_.GetComponent<LogicScript>();
        LogicScript = logicScript;
        
    }
}
