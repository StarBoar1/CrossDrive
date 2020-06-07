
using UnityEngine;

public class ShowLosePanel : MonoBehaviour
{
    [SerializeField]
    private GameObject losePanel,slowTime;
    private bool addOnce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(CollisionCars.lose && !addOnce)
        {
            addOnce = true;
            slowTime.SetActive(false);
            losePanel.SetActive(true);
        }
    }
}
