using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnCollisionEnter(Collider other)
    {
        if(other.CompareTag("Cactus"))
        {
            Destroy(gameObject);
        }
    }
}
