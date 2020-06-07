
using UnityEngine;
using UnityEngine.UI;
public class ScoreShow : MonoBehaviour
{
    [SerializeField]
    private Text topRecord;
   void OnEnable()
    {
        GetComponent<Text>().text = "Score:" + DeleteCar.countcars.ToString();
        if (PlayerPrefs.GetInt ("Score") < DeleteCar.countcars)
        {
            PlayerPrefs.GetInt ("Score", DeleteCar.countcars);
            topRecord.text = "TOP:" + DeleteCar.countcars.ToString();
        }
        else
        topRecord.text = "TOP:" + PlayerPrefs.GetInt ("Score").ToString();
          
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
