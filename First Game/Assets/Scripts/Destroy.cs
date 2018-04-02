using UnityEngine;

public class Destroy : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < 4f)
        {
            Destroy(gameObject);
        }
    }
}
