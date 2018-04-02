using UnityEngine;
using System.Collections;

public class CollisionPlayer : MonoBehaviour
{
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Obstacle"){

            FindObjectOfType<GameManager>().EndGame();

        }
    }
}
