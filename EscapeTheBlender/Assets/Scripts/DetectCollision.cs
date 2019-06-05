using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacle"  || collision.gameObject.tag == "Floor") {
            FindObjectOfType<GameManager>().gameOver();
        }
    }

}
