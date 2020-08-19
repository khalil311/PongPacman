using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Flap : MonoBehaviour
{
    public Text text;
    public float scorenumber;
    public string score;
    public GameObject start;
    
    public bool isDead;
    private Rigidbody2D rd2d;
    [SerializeField]
    private float speed = 5f;
    [SerializeField]
    private float flapforce = 20f;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
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
        GetComponent<Animator>().SetBool("isDead", true);
    }
    public void Replay()
    {
        SceneManager.LoadScene(0);
    }
    public void Unfreeze()
    {
        Time.timeScale = 1;
    }
    public void removebutton()
    {
        start.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "score")
        {
            scorenumber++;
            Debug.Log(scorenumber);
        }
        text.text = scorenumber.ToString();
    }
}
