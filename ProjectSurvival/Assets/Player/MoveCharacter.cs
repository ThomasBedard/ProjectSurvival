using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
//using UnityEngine.Windows;
//using UnityEngine.Windows;

public class MoveCharacter : MonoBehaviour
{
    //link for character -> https://stackoverflow.com/questions/45569580/sprite-sheet-animation-with-arrow-keys
    //link for gem -> https://www.deviantart.com/bigbark24/art/Diamond-sprite-sheet-759155287
    //link for tiles -> https://opengameart.org/content/outdoor-tiles-again
    //link for tree -> https://opengameart.org/content/gnarled-tree
    Animator animator; //to talk to the animator
    public int speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.speed = 1;
        float val_x = Input.GetAxis("Horizontal");
        float val_y = Input.GetAxis("Vertical");

        //if val_x is less than 0, then set direction to 3
        if (val_x < 0)
        {
            animator.SetInteger("direction", (int)MoveDirection.LEFT);
        }
        //if val_x is more than 0, then set direction to 4
        if (val_x > 0)
        {
            animator.SetInteger("direction", (int)MoveDirection.RIGHT);
        }
        //if val_y is less than 0, then set direction to 2
        if (val_y < 0)
        {
            animator.SetInteger("direction", (int)MoveDirection.DOWN);
        }
        //if val_y is more than 0, then set direction to 1
        if (val_y > 0)
        {
            animator.SetInteger("direction", (int)MoveDirection.UP);
        }
        //do for all dorection
        //then move the guy just like you didfor animation 1.

        transform.position += new Vector3(val_x, val_y, 0).normalized *speed * Time.deltaTime;

        //animator.StopPlayback();
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
