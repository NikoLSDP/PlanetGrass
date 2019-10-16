using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    [SerializeField]
    private Joystick joystick;

    void Start()
    {
        
    }

    public static float Angle(Vector2 p_vector2)
    {
        if (p_vector2.x < 0)
        {
            return 360 - (Mathf.Atan2(-(p_vector2.x), p_vector2.y) * Mathf.Rad2Deg * -1);
        }
        else
        {
            return Mathf.Atan2(-(p_vector2.x), p_vector2.y) * Mathf.Rad2Deg;
        }
    }

    void Update()
    {
     
        if(joystick.Direction != Vector2.zero)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, Angle(joystick.Direction)));
        }
    }
}
