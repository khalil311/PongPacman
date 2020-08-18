using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flap : MonoBehaviour
{
    public bool isDead;
    private Rigidbody2D rd2d;
    [SerializeField]
    private float speed = 5f;
    [SerializeField]
    private float flapforce = 20f;
    // Start is called before the first frame update
    void Start()
    {
        rd2d = GetComponent<Rigidbody2D>();
        rd2d.velocity = Vector2.right * speed * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isDead)
        {
            rd2d.velocity = Vector2.right * speed * Time.deltaTime;
            rd2d.AddForce(Vector2.up * flapforce);
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isDead = true;
        rd2d.velocity = Vector2.zero;
    }
}
