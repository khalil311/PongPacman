using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public float speed = 30f;
    public int score;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
        score = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float hitfactor(Vector2 ballposition , Vector2 racketposition , float Racketwidth)
    {
        return (ballposition.x - racketposition.x)/ Racketwidth;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Racket")
        {
            float x = hitfactor(transform.position, collision.transform.position, collision.collider.bounds.size.x);
            Vector2 dir = new Vector2(x, 1).normalized;
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
        if (collision.gameObject.CompareTag("Blocks"))
        {

        }

    }

    public void IncreaseScore(int reward)
    {
        score += reward;
        scoreText.text = score.ToString();
    }

}
