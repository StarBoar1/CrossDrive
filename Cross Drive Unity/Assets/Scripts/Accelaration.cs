
using UnityEngine;
[RequireComponent(typeof(MoveCar))]
public class Accelaration : MonoBehaviour
{
    public GameObject exhaust;
    private bool accelarate;
    void OnMouseDown()
    {
        if(!accelarate)
        {
            GetComponent<MoveCar>().speed *= 2f;
            accelarate = true;
            GameObject ex = Instantiate(exhaust, new Vector3(gameObject.transform.position.x, 0.2f, gameObject.transform.position.z),
                Quaternion.Euler(new Vector3(90, 0, 0))) as GameObject;
            Destroy(ex, 0.5f);

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
