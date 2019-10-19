using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class Player : MonoBehaviour
{
    [SerializeField]
    AudioClip sfxCrush;
    [SerializeField]
    AudioClip mowingLawn;

    private Animator anim;
    private Rigidbody playerRb;
    private AudioSource audioSrc;

    void Start()
    {
        anim = GetComponent<Animator>();
        playerRb = GetComponent<Rigidbody>();
        audioSrc = GetComponent<AudioSource>();
    }
    void Awake()
    {
        Assert.IsNotNull(sfxCrush);
        Assert.IsNotNull(mowingLawn);
    }
    void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collision");
        if (other.transform.GetChild(1).tag == "obstacle")
        {
            Debug.Log("Collision Obstacle");
            GameManager.instance.PlayerCollided();
        }
    }
}
