using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float jumpStrength;
    public Rigidbody2D myRigidBody;
    public float inputBuffer;
    public float scoreBuffer;
    public ScoreLogic logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreLogic>();
    }

    // Update is called once per frame
    void Update()
    {
        if (inputBuffer == 0)
            inputBuffer = Time.time;
        if (scoreBuffer == 0)
            scoreBuffer = Time.time;
        if(Time.time - inputBuffer > 0.8f && (Input.GetKeyDown(KeyCode.Space) == true || Input.GetKeyDown(KeyCode.UpArrow) == true))
        {
            myRigidBody.velocity = Vector2.up * jumpStrength;
            inputBuffer = 0.0f;
        }
        if(Time.time -scoreBuffer > 0.02f)
        {
            logic.addScore();
            scoreBuffer = 0.0f;
        }

    }
}
