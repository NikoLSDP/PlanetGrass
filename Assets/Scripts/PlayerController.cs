using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Joystick joystick;

    [SerializeField]
    private float playerSpeed;

    private Vector3 playerDirection;

    Transform planet;

    void Start()
    {
        planet = GetComponent<Transform>();
    }

   void Update()
    {
        playerDirection = new Vector3(-joystick.Vertical, joystick.Horizontal, 0) * Time.deltaTime;

        planet.Rotate(playerDirection * playerSpeed);
        //if (joystick.Direction != Vector2.zero)
        //    Debug.Log(joystick.Direction);
        //if (joystick.Direction.x > 0)
        //    planet.Rotate(Vector3.left, playerSpeed * Time.deltaTime);
        //if (joystick.Direction.x < 0)
        //    planet.Rotate(Vector3.right, playerSpeed * Time.deltaTime);
        //if (joystick.Direction.y > 0)
        //    planet.Rotate(Vector3.back, playerSpeed * Time.deltaTime);
        //if (joystick.Direction.y < 0)
        //    planet.Rotate(Vector3.forward, playerSpeed * Time.deltaTime);
    }

    void RotateWorld()
    {
        if(joystick.Direction != Vector2.zero)
        {
            
        }
    }
}
