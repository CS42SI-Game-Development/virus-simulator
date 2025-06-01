using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonMover : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

        Vector3 direction = new(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        direction.Normalize();
        GetComponent<Rigidbody2D>().velocity = 3 * direction;

    }

}
