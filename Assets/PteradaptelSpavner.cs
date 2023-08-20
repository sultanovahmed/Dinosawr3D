using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PteradaptelSpavner : MonoBehaviour
{
    [SerializeField] private GameObject pteradaptelPrefab;
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
            CreatePteradaptel();
        }
    }

    private void CreatePteradaptel()
    {
        Instantiate(pteradaptelPrefab, SpawnPosition.position, pteradaptelPrefab.transform.rotation);
        cooldown = Random.Range(10.0f, 17.0f);
    }
}
