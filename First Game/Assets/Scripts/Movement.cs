using UnityEngine;

public class Movement : MonoBehaviour
{

    public Rigidbody player;

    public float speed = 100f;


    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            player.AddForce(speed * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            player.AddForce(-speed * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (player.position.y < -2f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
