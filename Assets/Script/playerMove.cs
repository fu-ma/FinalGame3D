using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerMove : MonoBehaviour
{
    Vector3 moveVelocity;
    public Rigidbody rb;
    public float maxSpeed;
    public float power;
    private PlayerInputSystem inputAction_;
    // Start is called before the first frame update
    void Start()
    {
        inputAction_ = new PlayerInputSystem();
        inputAction_.Enable();
        rb = GetComponent<Rigidbody>();
        rb.mass = 10;
        rb.drag = 20;
        rb.angularDrag = 0;
        rb.constraints = RigidbodyConstraints.FreezeRotation;
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (inputAction_.Player.MoveLeft.IsPressed())
        {
            if (inputAction_.Player.SpeedUp.IsPressed())
            {
                power = -24.0f;
                maxSpeed = 48.0f;
            }
            else
            {
                power = -12.0f;
                maxSpeed = 24.0f;
            }
            rb.AddForce(transform.right * ((maxSpeed - rb.velocity.x) * power), ForceMode.Force);
        }
        if (inputAction_.Player.MoveRight.IsPressed())
        {
            if (inputAction_.Player.SpeedUp.IsPressed())
            {
                power = 32.0f;
                maxSpeed = 48.0f;
            }
            else
            {
                power = 16.0f;
                maxSpeed = 24.0f;
            }
            rb.AddForce(transform.right * ((maxSpeed - rb.velocity.x) * power), ForceMode.Force);
        }
        if (inputAction_.Player.MoveUp.IsPressed())
        {
            if (inputAction_.Player.SpeedUp.IsPressed())
            {
                power = 32.0f;
                maxSpeed = 48.0f;
            }
            else
            {
                power = 16.0f;
                maxSpeed = 24.0f;
            }
            rb.AddForce(transform.forward * ((maxSpeed - rb.velocity.z) * power), ForceMode.Force);
        }
        if (inputAction_.Player.MoveDown.IsPressed())
        {
            if (inputAction_.Player.SpeedUp.IsPressed())
            {
                power = -24.0f;
                maxSpeed = 48.0f;
            }
            else
            {
                power = -12.0f;
                maxSpeed = 24.0f;
            }
            rb.AddForce(transform.forward * ((maxSpeed - rb.velocity.z) * power), ForceMode.Force);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Stage")
        {
            //playerMoveNum = 0.00000f;
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        
    }

}
