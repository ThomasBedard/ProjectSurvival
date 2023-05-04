using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class EnemyFollowPlayer : MonoBehaviour
{
    private Transform player;

    private Rigidbody2D rb2d;

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
    }

    // Update is called once per frame
    void Update()
    {
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
    }
}
