using UnityEngine;
using System.Collections;

public class Items : MonoBehaviour {

    private int id;
    private Rigidbody2D rb;
    private Vector2 splosion = new Vector2(Random.Range(-1f, 1f), Random.Range(0f, 3f));
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = splosion;
    }
}
