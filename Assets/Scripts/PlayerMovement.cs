using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private Rigidbody body;
    [SerializeField]
    private int addForce = 2000;
    [SerializeField]
    private int sidewayForce=500;

    private void FixedUpdate()
    {
        body.AddForce(0, 0, addForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            body.AddForce(sidewayForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            body.AddForce(-sidewayForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if (body.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
