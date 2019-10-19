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

    void Start()
    {

    }

   void Update()
    {
       MovePlayer();
    }

    void MovePlayer()
    {
        if (joystick.Direction != Vector2.zero && !GameManager.instance.GameOver)
        {
           // Debug.Log(joystick.Direction);
            playerDirection = new Vector3(-joystick.Vertical, joystick.Horizontal, 0);
            //  player.RotateAround(Vector3.zero, playerDirection, playerSpeed * Time.deltaTime);

            transform.Rotate(playerDirection * playerSpeed * Time.deltaTime, Space.World);
        }
    }
}
