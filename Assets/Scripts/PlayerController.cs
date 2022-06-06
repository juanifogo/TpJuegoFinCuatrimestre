using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerController : MonoBehaviour
{
    public float moveSpeed, jumpForce;
    public int maxJumps;
    public static string state;
    int hasJump;
    Rigidbody rb;
    public float Gravity;
    AudioSource audioPlayer;
    public AudioClip Salto, Correr;
    float tiempo;   
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
        tiempo = Time.timeSinceLevelLoad;
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
        if(Mathf.FloorToInt(tiempo) >= 10)
        {
            state = "won";
            SceneManager.LoadScene("Menu");
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
        
        if(col.gameObject.tag == "obstacle")
        {
            state = "lost";
            SceneManager.LoadScene("Menu");
        }
    }
}