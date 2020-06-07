using UnityEngine;
[RequireComponent(typeof (Rigidbody))]
public class MoveCar : MonoBehaviour
{
    public GameObject turnSignal;
    private Rigidbody rb;
    public float speed = 9f; 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.MovePosition(transform.position - transform.forward * speed * Time.fixedDeltaTime);
    }
}
