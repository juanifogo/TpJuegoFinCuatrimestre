using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MovePlayer : MonoBehaviour
{
    public float moveSpeed, jumpForce;
    public int maxJumps;
    int hasJump;
    Rigidbody rb;
    public float Gravity;
    AudioSource audioPlayer;
    public AudioClip Salto, Correr;   
    void Start()
    {
        Physics.gravity = new Vector3(0, Gravity, 0);
        hasJump = maxJumps;
        rb = GetComponent<Rigidbody>();
        audioPlayer = GetComponent<AudioSource>();
        audioPlayer.loop = true;
        audioPlayer.clip = Correr;
        audioPlayer.Play();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Translate(-moveSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Translate(moveSpeed, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space) && hasJump>0)
        {
            rb.velocity = Vector3.up * jumpForce;
            hasJump--;
            audioPlayer.loop = false;
            audioPlayer.clip = Salto;
            audioPlayer.Play();
        }

    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ground")
        {
            hasJump = maxJumps;
            audioPlayer.loop = true;
            audioPlayer.clip = Correr;
            audioPlayer.Play();
        }

    }
}