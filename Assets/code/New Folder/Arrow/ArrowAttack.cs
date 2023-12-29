using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowAttack : MonoBehaviour
{
    public float ArrowSpeed;
    public float destroyTime;
    public GameObject arrow;
    Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }
    void Start()
    {
        rb.velocity = new Vector2(ArrowSpeed * transform.parent.localScale.x, 0);
    }
    private void Update()
    {
        Destroy(arrow, destroyTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Stone")
            Destroy(arrow);
        else if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<hareket>().Healthchange(-10);
        }

    }

}
