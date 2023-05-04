using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD

public class EnemyFollowPlayer : MonoBehaviour
{
<<<<<<< HEAD
<<<<<<< HEAD
=======
using static UnityEngine.GraphicsBuffer;

public class EnemyFollowPlayer : MonoBehaviour
{
>>>>>>> parent of 59f0af1 (Script + music)
    private Transform player;

    private Rigidbody2D rb2d;

<<<<<<< HEAD
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
=======
    public float speed;

    private Vector2 move;

    private Vector3 previousPosition;
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(wait());
        rb2d = GetComponent<Rigidbody2D>();
        player = GameObject.Find("player_0").transform;
        previousPosition = player.transform.position;
>>>>>>> parent of 59f0af1 (Script + music)
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> parent of 59f0af1 (Script + music)
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
<<<<<<< HEAD
=======
        
>>>>>>> parent of 866d445 (Cat ennemy)
=======
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed);
>>>>>>> parent of 136f382 (Added details)
=======
>>>>>>> parent of 59f0af1 (Script + music)
    }
}
