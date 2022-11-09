using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public GameObject enemeyObject;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(enemeyObject);
        // Check if hitting enemey and damage the enemey
    }
}
