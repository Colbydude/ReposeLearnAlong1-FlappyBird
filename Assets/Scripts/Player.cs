using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D rigidBody;
    public int yVelocity = 5;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")) {
            animator.Play("Flap");
            rigidBody.velocity = new Vector2(0, yVelocity);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        // ContactPoint2D contactPoint = other.GetContact(0);
        animator.Play("Hurt");
        SceneManager.LoadScene("GameOver");
    }
}
