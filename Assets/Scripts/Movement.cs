using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float jumpStrength;
    public Rigidbody2D myRigidBody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true || Input.GetKeyDown(KeyCode.UpArrow) == true)
        {
            myRigidBody.velocity = Vector2.up * jumpStrength;
        }
    }
}
