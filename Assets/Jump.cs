using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] float jumpSpeed; //высота прыжка
    bool isGrounded; //переменная, которая будет указывать на земле мы или нет
    Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    void Update()
    {
        if (isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(new Vector3(0, jumpSpeed, 0), ForceMode.Impulse);
            }
        }
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

}
