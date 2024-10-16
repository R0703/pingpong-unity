using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb2d;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Invoke("GoBall", 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GoBall()
    {
        rb2d.AddForce(new Vector2(-20, -1), ForceMode2D.Impulse);
    }

    void ResetBall()
    {
        rb2d.velocity = Vector2.zero;
        transform.position = Vector2.zero;
    }

    void RestartGame()
    {
        Debug.Log("Restarting game..");
        ResetBall();
        Invoke("GoBall",  1);
    }

    //=====script untuk movment jika mantul (klo di project ini uda pake bounce jd gaperlu=====
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Player"))
    //    {
    //        //rb2d.AddForce(new Vector2(20, 2));
    //        Vector2 normal = collision.contacts[0].normal;
    //        rb2d.AddForce(normal, ForceMode2D.Impulse);
    //    }
    //}
}
