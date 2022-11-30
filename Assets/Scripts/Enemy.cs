using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public GameObject player;
    public float speed;

    private void FixedUpdate()
    {
        Vector3 EnemyLocation = transform.position;
        Vector3 PlayerLocation = player.transform.position;

        //transform.LookAt(PlayerLocation);   3D

        //Look at player    2D
        Quaternion rotation = Quaternion.LookRotation(
            player.transform.position - transform.position,
            transform.TransformDirection(Vector3.up)
            );
        transform.rotation = new Quaternion(0, 0, rotation.z, rotation.w);

        //Move to player    2D
        transform.position = Vector2.MoveTowards(EnemyLocation, PlayerLocation, speed);

        Debug.Log(distance(EnemyLocation, PlayerLocation));
    }
    private float distance(Vector3 object1, Vector3 object2) //These Vector3s represent coordinates 
    {
        float firstpart = Mathf.Pow(object1.x - object2.x, 2);
        float secondpart = Mathf.Pow(object1.y - object2.y, 2);
        float thirdpart = Mathf.Pow(object1.z - object2.z, 2);

        float Distance = Mathf.Sqrt(firstpart + secondpart + thirdpart); 

        return Distance;
    }
}