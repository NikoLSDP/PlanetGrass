using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public Joystick joystick;

    [SerializeField]
    private float playerSpeed;
    [SerializeField]
    private Vector3 playerPos;

    private Vector3 playerDirection;
    //private int directionCode = 0;


    //Transform player;

    void Start()
    {
       // player = GetComponent<Transform>();
       // player.TransformDirection(playerDirection);
    }

   void Update()
    {
       MovePlayer();
      // SwitchRotation();
    }

    void MovePlayer()
    {
        if(joystick.Direction != Vector2.zero)
        {
            Debug.Log(joystick.Direction);
            playerDirection = new Vector3(-joystick.Vertical, joystick.Horizontal, 0);
            //  player.RotateAround(Vector3.zero, playerDirection, playerSpeed * Time.deltaTime);

            transform.Rotate(playerDirection * playerSpeed * Time.deltaTime, Space.World);
        }
    }
    //void SwitchRotation()
    //{
    //    if (joystick.Direction.y >= 0.0f && (joystick.Direction.x < 0.2f && joystick.Direction.x >= -0.2f))
    //        directionCode = 0;
    //    if (joystick.Direction.y >= 0.3f && (joystick.Direction.x > 0.2f))
    //        directionCode = 1;
    //}
}
