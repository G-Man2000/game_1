using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{   
    private Rigidbody2D rb;
    public float speed;
    public Animation anim;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        rb.transform.Translate(1*(speed/100), 0, 0);
    }

    public void Jump()
    {

    }
}
