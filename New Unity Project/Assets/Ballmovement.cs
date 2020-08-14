using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ballmovement : MonoBehaviour
{
    public float speed = 30f;
    public Text scoreRightText;
    public Text scoreLeftText;
    int scoreRight;
    int scoreLeft;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float hitFactor(Vector2 ballPos , Vector2 racketPos , float racketHeight)
    {
        return (ballPos.y - racketPos.y) / racketHeight; 
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "player2")
        {
            float y = hitFactor(transform.position, col.transform.position, col.collider.bounds.size.y);
            Vector2 direction = new Vector2(1, y);
            GetComponent<Rigidbody2D>().velocity = direction * speed;
        }
        if (col.gameObject.name == "player")
        {
            float y = hitFactor(transform.position, col.transform.position, col.collider.bounds.size.y);
            Vector2 direction = new Vector2(-1, y);
            GetComponent<Rigidbody2D>().velocity = direction * speed;
        }
        if (col.gameObject.name == "wallleft")
        {
            scoreRight++;
            scoreRightText.text = scoreRight.ToString();
        }
        if (col.gameObject.name == "wallright")
        {
            scoreLeft++;
            scoreLeftText.text = scoreRight.ToString();
        }
        if (col.collider.name == ("PACMAN"))
        {
            Destroy(gameObject);
        }
    }
    
}
