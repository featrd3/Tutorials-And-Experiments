using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTest : MonoBehaviour
{
    public Rigidbody rigidBod;
    public float jumpForceMultiplier;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidBod.AddForce(Vector3.up * jumpForceMultiplier, ForceMode.VelocityChange);
        }
    }
}
