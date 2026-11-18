using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private Rigidbody rigidPlayer;
    [SerializeField] private float forwardForce = 10.0f;
    [SerializeField] private float sidewaysForce = 1.0f;
    //[SerializeField] private float upForce = 10.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidPlayer.AddForce(0.0f, 0.0f, forwardForce);

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidPlayer.AddForce(-sidewaysForce, 0.0f, 0.0f, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidPlayer.AddForce(sidewaysForce, 0.0f, 0.0f, ForceMode.VelocityChange);
        }
        /*
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidPlayer.AddForce(0.0f, upForce, 0.0f);
        }*/
    }
}
