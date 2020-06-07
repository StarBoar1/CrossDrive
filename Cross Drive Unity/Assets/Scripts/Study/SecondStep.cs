using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SecondStep : MonoBehaviour
{
    public Text study;
    // Start is called before the first frame update
    void Start()
    {
        study.text = "Whatch where the car turns";
    }
    void OnDisable()
    {
        SceneManager.LoadScene("game");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
