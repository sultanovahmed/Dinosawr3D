using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cactuscontroller : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }

    void Update()
    {
        if(transform.position.x <= -9f)
        {
            Destroy(gameObject);
        }
        else
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
    }
}
