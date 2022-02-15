using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBallCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        switch(other.name)
        {
            case "Big Target":
                Score.scoreAmount += 1;
                break;
            case "Small Target":
                Score.scoreAmount += 2;
                break;
        }
    }
}
