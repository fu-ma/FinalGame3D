using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerMove : MonoBehaviour
{
    Vector3 moveVelocity;
    public Rigidbody rb;
    public BoxCollider bc;
    public Transform playerTransform;
    public float maxSpeed;
    public float power;
    public GameObject girlObject;
    public GameObject boyObject;
    //public Transform cameraTransform;
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

        bc = GetComponent<BoxCollider>();
        bc.size = new Vector3(1, 2.36f, 1);

        playerTransform = GetComponent<Transform>();
        playerTransform.position = new Vector3(0, 1, -20);
        //cameraTransform = GetComponent<Transform>();
        Application.targetFrameRate = 60;
        Screen.SetResolution(1280, 720, FullScreenMode.FullScreenWindow, 60);
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

        //キャラクター切り替え
        if(inputAction_.Player.CharacterChangeGirl.triggered)
        {
            girlObject.SetActive(true);
            boyObject.SetActive(false);
        }
        if (inputAction_.Player.CharacterChangeBoy.triggered)
        {
            girlObject.SetActive(false);
            boyObject.SetActive(true);
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
