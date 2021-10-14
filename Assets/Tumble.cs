using UnityEngine;

public class Tumble : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    public float initialSpeed = 15f;
    public float torqueSpeed = 20f;
    public float bounceAmount = 5f;
    
    void Start()
    {
        rb.AddForce(transform.forward * initialSpeed, ForceMode.Impulse);
    }

    void Update()
    {
        rb.AddTorque(transform.right * torqueSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision other)
    {
        Bounce(other);
    }

    private void Bounce(Collision other)
    {
        Debug.Log("Bounce");
        var dir = (other.GetContact(0).normal + transform.forward).normalized * bounceAmount;
        rb.AddForce(other.GetContact(0).normal, ForceMode.Impulse);
    }
}
