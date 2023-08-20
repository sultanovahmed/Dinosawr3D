using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Jump : MonoBehaviour
{
    [SerializeField] float jumpSpeed; //высота прыжка
    bool isGrounded; //переменная, которая будет указывать на земле мы или нет
    Rigidbody rb;
    [SerializeField] GameObject Dino1;
    [SerializeField] GameObject Dino2;
    private bool MoznoPrigat = true;
    [SerializeField] Text textScore;
    float score;
    [SerializeField] Text textMaxScore;
    float MaxScore;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    void Update()
    {
        if (isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space) && MoznoPrigat == true)
            {
                JumpButton();

            }
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Dino1.SetActive(false);
            Dino2.SetActive(true);
            MoznoPrigat = false;
        }        
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            Dino1.SetActive(true);
            Dino2.SetActive(false);
            MoznoPrigat = true;
        }
    }

    private void FixedUpdate()
    {
        score += Time.deltaTime * 10;
        textScore.text = score.ToString("00000");

        if (MaxScore <= score) 
        { 
            MaxScore = score; 
        }
        textMaxScore.text = MaxScore.ToString("00000");
    }
    private void OnCollisionStay(Collision other)
    {
        if (other != null)
        {
            isGrounded = true;
        }
    }
    private void OnCollisionExit(Collision other)
    {
        isGrounded = false;
    }

    public void JumpButton()
    {
        if (isGrounded)
        {
            rb.AddForce(new Vector3(0, jumpSpeed, 0), ForceMode.Impulse);
        }
    }
    public void DownButton()
    {
        Dino1.SetActive(false);
        Dino2.SetActive(true);
    }

    public void UpButton()
    {
        Dino1.SetActive(true);
        Dino2.SetActive(false);
    }
}
