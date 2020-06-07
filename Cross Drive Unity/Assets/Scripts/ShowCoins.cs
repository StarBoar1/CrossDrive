
using UnityEngine;
using UnityEngine.UI;
public class ShowCoins : MonoBehaviour
{
    void OnEnable()
    {
        GetComponent<Text>().text = PlayerPrefs.GetInt("Coins").ToString();
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
