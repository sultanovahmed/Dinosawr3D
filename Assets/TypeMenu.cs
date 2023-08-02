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
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.X))
        {
            ShovTip();
        }
    }
    public void ShovTip()
    {
        image.SetActive(false);
        Time.timeScale = 1;
    }
}
