using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Windows;
//using UnityEngine.Windows;

public class MoveCharacter : MonoBehaviour
{
    //link for character -> https://stackoverflow.com/questions/45569580/sprite-sheet-animation-with-arrow-keys
    //link for gem -> https://www.deviantart.com/bigbark24/art/Diamond-sprite-sheet-759155287
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
    //link for level 1 sprite sheet -> https://opengameart.org/content/outdoor-tiles-again
    //link for tree -> https://opengameart.org/content/gnarled-tree
    //link for level 2 sprite sheet -> https://opengameart.org/content/sci-fi-interior-tiles
=======
>>>>>>> parent of 22564a0 (Background + tiles)
=======
    //link for tiles -> https://cpictures.homes/grass-tile-game
>>>>>>> parent of 72a1e76 (Adding a reference link)
=======
    //link for tiles -> https://opengameart.org/content/outdoor-tiles-again
>>>>>>> parent of 30c51ea (Doing the Start menu)
    Animator animator; //to talk to the animator
<<<<<<< HEAD
    public Rigidbody2D rb;
    public float moveSpeed = 7f;
    public Vector2 forceToApply;
    public Vector2 PlayerInput;
    public float forceDamping = 1.2f;
=======
>>>>>>> parent of 88bfa2d (Created player speed public variable)

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.speed = 1;
        //.normalized is to make sure movements in all directions are the same
        PlayerInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;

       
    }

<<<<<<< HEAD
    void FixedUpdate()
    {
        Vector2 moveForce = PlayerInput * moveSpeed;
        moveForce += forceToApply;
        forceToApply /= forceDamping;
        if (Mathf.Abs(forceToApply.x) <= 0.01f && Mathf.Abs(forceToApply.y) <= 0.01f)
        {
            forceToApply = Vector2.zero;  
        }
      
        rb.velocity = moveForce;
=======
        transform.position += new Vector3(val_x, val_y, 0).normalized * Time.deltaTime;

        //animator.StopPlayback();
>>>>>>> parent of 88bfa2d (Created player speed public variable)
    }

    public enum MoveDirection
    {
        NONE = 0,
        UP = 1,
        DOWN = 2,
        LEFT = 3,
        RIGHT = 4
    }
}
