using UnityEngine;

public class DeleteCar : MonoBehaviour
{
    public static int countcars;
    void Start()
    {
        countcars = 0;
    }
   
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (!CollisionCars.lose)
                countcars++;
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + 1);
            Destroy(other.gameObject);
        }
         
       
    }
}
