using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCactus : MonoBehaviour
{
    [SerializeField] private GameObject cactusPrefab;
    [SerializeField] private Transform SpawnPosition;
    [SerializeField] private float cooldown;
    private float timer;
    void Start()
    {
        
    }


    void Update()
    {
        timer += Time.deltaTime;
        if (timer > cooldown)
        {
            timer = 0;
            CreateCactus();
        }
    }

    private void CreateCactus()
    {
        Instantiate(cactusPrefab,SpawnPosition.position, cactusPrefab.transform.rotation);
        cooldown = Random.Range(3.0f, 4.0f);
    }
}
