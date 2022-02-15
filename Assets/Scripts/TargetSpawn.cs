using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetSpawn : MonoBehaviour
{
    float timeLeft = 4;
    void Start()
    {
        if(gameObject.name == "Small Target")
        {
            timeLeft = 2;
        }
    }

    private void Update()
    {
        timeLeft -= Time.deltaTime;
        if(timeLeft < 0)
        {
            Respawn();
            timeLeft += 3;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        Respawn();
    }

    private void Respawn()
    {
        Vector3 spawnPoint = new Vector3(Random.Range(-4.35f, 3.35f), 0,Random.Range(-4.35f, 4.35f));
        transform.position = spawnPoint;
    }
}
