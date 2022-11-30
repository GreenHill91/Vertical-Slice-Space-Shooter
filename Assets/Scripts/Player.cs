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
        //Getting keys, putting them into a Vector2
        keyMovement.x = Input.GetAxisRaw("Horizontal");
        keyMovement.y = Input.GetAxisRaw("Vertical");

        //Debug.Log(keyMovement);

        //Using the Vector2 to translate our transform
        transform.Translate(-keyMovement * speed);

    }
}
