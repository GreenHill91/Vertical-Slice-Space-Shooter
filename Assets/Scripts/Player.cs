using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;

    private Vector2 keyMovement;

    void FixedUpdate()
    {
        keyMovement.x = Input.GetAxisRaw("Horizontal");
        keyMovement.y = Input.GetAxisRaw("Vertical");

        Debug.Log(keyMovement);

        transform.Translate(-keyMovement * speed);

    }
}
