using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Speed = 5f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime, Space.Self);
    }
}
