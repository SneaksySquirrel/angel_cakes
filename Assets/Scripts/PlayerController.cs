using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CircleCollider2D))]
public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;

    private new Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var x = transform.position.x + Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        var y = transform.position.y + Input.GetAxis("Vertical") * Time.deltaTime * speed;

        //Set the position of our character throught the RigidBody2D component (since we are using physics)
        rigidbody.MovePosition(new Vector2(x, y));

    }
}
