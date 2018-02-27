using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rbPlayer;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;


    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            rbPlayer.AddForce(0, 0, forwardForce * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            rbPlayer.AddForce(0, 0, -forwardForce * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            rbPlayer.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            rbPlayer.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}
