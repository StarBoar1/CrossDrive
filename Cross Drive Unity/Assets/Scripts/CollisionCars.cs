
using UnityEngine;
[RequireComponent(typeof(MoveCar))]
public class CollisionCars : MonoBehaviour
{
    public GameObject explode;
    public static bool lose = false;
    private bool oneStop;
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player" && !oneStop)
        {
            lose = true;
            oneStop = true;
            gameObject.GetComponent<MoveCar>().speed = 0f;
            other.gameObject.GetComponent<MoveCar>().speed = 0f;
            gameObject.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * -1000);

            if(gameObject.transform.position.x<other.gameObject.transform.position.x)
            {
                Vector3 pos = Vector3.Lerp(gameObject.transform.position, other.transform.position, 0.5f);
                Instantiate(explode, new Vector3(pos.x, 2.7f, pos.z), Quaternion.identity);
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
