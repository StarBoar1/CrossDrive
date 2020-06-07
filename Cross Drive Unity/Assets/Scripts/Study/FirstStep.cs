
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(MoveCar))]
public class FirstStep : MonoBehaviour
{
    public Text study;
    private bool firstStep;
    public GameObject secondCar;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<MoveCar>().speed = 0f;
        Invoke("MoveCar", 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x<-63f && !firstStep)
        {
            firstStep = true;
            GetComponent<MoveCar>().speed = 2f;
            study.text = "Tap the car to accelerate it";
        }
    }
    void MoveCar()
    {
        GetComponent<MoveCar>().speed = 12f;
    }
    void OnMouseDown()
    {
        if (firstStep)
        {
            GetComponent<MoveCar>().speed = 30f;
            study.text = "";

        }
    }
    void OnDisable()
    {
        secondCar.SetActive(true);
    }
}
