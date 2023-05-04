using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowPlayer : MonoBehaviour
{
<<<<<<< HEAD
<<<<<<< HEAD
    private Transform player;

    private Rigidbody2D rb2d;

=======
    public Transform player;
>>>>>>> parent of 136f382 (Added details)
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player_0").transform;
<<<<<<< HEAD
        previousPosition = player.transform.position;
=======
    // Start is called before the first frame update
    void Start()
    {
        
>>>>>>> parent of 866d445 (Cat ennemy)
=======
>>>>>>> parent of 136f382 (Added details)
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
<<<<<<< HEAD
        if (player.position != previousPosition)
        {
            if (player)
            {
                Vector3 direction = (player.position - transform.position).normalized;
                move = direction;
            }
        }

        
    }

    private void FixedUpdate()
    {
        if (player)
        {
            rb2d.velocity = new Vector2(move.x, move.y) * speed;
        }
    }

    IEnumerator wait()
    {
        yield return new WaitForSecondsRealtime(3);
=======
        
>>>>>>> parent of 866d445 (Cat ennemy)
=======
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed);
>>>>>>> parent of 136f382 (Added details)
    }
}
