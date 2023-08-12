using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{
    [SerializeField] public GameObject GameOverimage;
    [SerializeField] public GameObject GameOverimagePteradaptel;

    void Start()
    {
        GameOverimage.SetActive(false);
        Time.timeScale = 1;
    }

    void Update()
    {
       
    }

    public void OnTriggerEnter(Collider other)
    { 
        if(other.CompareTag("cactus"))
        {
            GameOverimage.SetActive(true);
            Time.timeScale = 0;
        }
        if (other.CompareTag("helicopter"))
        {
            GameOverimagePteradaptel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void TryAgain()
    {
        SceneManager.LoadScene(0);
    }
}
