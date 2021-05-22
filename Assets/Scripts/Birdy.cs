using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Birdy : MonoBehaviour
{
    public bool isDead;
    public float velocity = 1f ;
    public Rigidbody2D rb2D;

    public GameManager managergame;
    public GameObject DeathScreen;
    public AudioSource Napim;
    public AudioSource Zýa;


    void Start()
    {
        Time.timeScale = 1; 
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb2D.velocity = Vector2.up * velocity;

        }
    }
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "ScoreArea")
        {
            managergame.UpdateScore();
            Napim.Play();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeathArea")
        {
            isDead = true;
            Zýa.Play();
            Time.timeScale = 0;
            DeathScreen.SetActive(true);
               
            
        }
    }
}
