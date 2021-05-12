using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Header("Configuracion")]
    public float moveSpeed = 10f;
    public bool isGameOver;
    public bool win;
    [HideInInspector] public bool XRayActive = false;
    private Vector3 move;

    [Header("Referencias")]
    public BoxCollider xRayColliderOn;
    public BoxCollider xRatColliderOff;
    public GameObject puzzleOn;
    private Rigidbody rbg;
    PlayerInput controls;

    private void Awake()
    {
        isGameOver = false;
        win = false;
        rbg = GetComponent<Rigidbody>();

        controls = new PlayerInput();

        controls.Gameplay.Fire.performed += ctx => Fire();

        controls.Gameplay.Move.performed += ctx => move = ctx.ReadValue<Vector3>();
        controls.Gameplay.Move.canceled += ctx => move = Vector3.zero;
    }

    private void Fire()
    {
        if(XRayActive == false)
        {
            XRayActive = true;
            xRatColliderOff.enabled = false;
            xRayColliderOn.enabled = true;
        }
        else if(XRayActive == false)
        {
            XRayActive = false;
            xRatColliderOff.enabled = true;
            xRayColliderOn.enabled = false;
        }
    }

    public void Update()
    {
        if(isGameOver == false && win == false)
        {
            if(xRayColliderOn.enabled == false)
            {
                if (puzzleOn.activeInHierarchy == false)
                {
                    float h = Input.GetAxis("Horizontal");
                    float v = Input.GetAxis("Vertical");

                    Vector3 m = new Vector3(move.x, 0f, move.y) * Time.deltaTime;
                    Vector3 movement = new Vector3(h, 0f, v) * Time.deltaTime;
                    rbg.velocity = m * moveSpeed; 
                    rbg.velocity = movement * moveSpeed;

                    if (h < 0f)
                    {
                        transform.rotation = Quaternion.Euler(0f, -90f, 0f);
                    }

                    if (h > 0f)
                    {
                        transform.rotation = Quaternion.Euler(0f, 90f, 0f);
                    }

                    if (v < 0f)
                    {
                        transform.rotation = Quaternion.Euler(0f, 180, 0f);
                    }

                    if (v > 0f)
                    {
                        transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                    }
                }
                else
                {
                    rbg.Sleep();
                }
            }
            else
            {
                rbg.Sleep();
            }
        }
        else
        {
            rbg.Sleep();
        }

        if(isGameOver == false && win == false)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                XRayActive = true;
                xRatColliderOff.enabled = false;
                xRayColliderOn.enabled = true;
            }
            else if (Input.GetButtonUp("Fire1"))
            {
                XRayActive = false;
                xRatColliderOff.enabled = true;
                xRayColliderOn.enabled = false;
            }
        }
        else
        {
            XRayActive = false;
            xRatColliderOff.enabled = true;
            xRayColliderOn.enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy" || other.tag == "Camera" || other.tag == "Laser")
        {
            isGameOver = true;
        }
        else if(other.tag == "Door")
        {
            win = true;
        }
    }
}
