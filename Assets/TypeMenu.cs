using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeMenu : MonoBehaviour
{
    [SerializeField] public GameObject image;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale= 0;
        if (PlayerPrefs.HasKey("showTip"))
        {
            ShovTip();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ShovTip()
    {
        image.SetActive(false);
        Time.timeScale = 1;
        PlayerPrefs.SetInt("showTip", 1);
    }
}
