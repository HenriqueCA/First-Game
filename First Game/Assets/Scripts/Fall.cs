using UnityEngine;
using UnityEngine.UI;

public class Fall : MonoBehaviour
{

    public Rigidbody block;

    public float velocity = 2000;

    void Start()
    {
        velocity += Time.timeSinceLevelLoad * 100;
    }
    void FixedUpdate()
    {

        block.AddForce(0, 0, -1 * velocity * Time.fixedDeltaTime);

    }

}
