using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    Rigidbody ab;
    Vector3 move;
    void Start()
    {
        ab = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        ab.AddForce(move);
    }
}
