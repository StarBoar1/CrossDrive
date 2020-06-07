using System.Collections;
using UnityEngine;

public class CarLights : MonoBehaviour
{
    public int showObject;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(light());
        StartCoroutine(sound());
        
    }
    IEnumerator light()
    {
        yield return new WaitForSeconds(0.2f);
        GameObject light = gameObject.transform.GetChild(showObject).gameObject;
        while (true)
        {
            light.SetActive(!light.activeSelf);
            yield return new WaitForSeconds(0.5f);
        }


    }
    IEnumerator sound()
    {

        GameObject s = Instantiate(GetComponent<MoveCar>().turnSignal, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        yield return new WaitForSeconds(2f);
        Destroy(s.gameObject);


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
