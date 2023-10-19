using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script is applied to the Bullet prefab.
// collision.gameObject is the object that the bullet is colliding with.
// gameObject is the Bullet.
public class Collision : MonoBehaviour
{
    // Task 3: Destroy bullets when they collide with all game objects except the player
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.name == "Bullet(Clone)" && collision.gameObject.name == "Bottom" || collision.gameObject.name == "Top" || collision.gameObject.name == "Left" || collision.gameObject.name == "Right" || collision.gameObject.name == "Obstacle1" || collision.gameObject.name == "Obstacle2")
        {
            Destroy(gameObject);
        }
    }
}
