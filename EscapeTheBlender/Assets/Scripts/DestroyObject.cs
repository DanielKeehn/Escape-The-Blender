using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour {

    private void Update()
    {
        if (transform.position.y <= -17) 
        {
            Destroy(this.gameObject);
        }
    }
}
