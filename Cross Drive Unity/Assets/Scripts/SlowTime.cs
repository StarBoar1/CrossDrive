using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlowTime : MonoBehaviour
{
    public Sprite active, inactive;
    private Text countslow;
    void OnMouseDown()
    {
        if (PlayerPrefs.GetInt("Slow Time") > 0 && Time.timeScale != 0.5f)
        {
            GetComponent<AudioSource>().Play();
            PlayerPrefs.SetInt("Slow Time", PlayerPrefs.GetInt("Slow Time") - 1);
            countslow.text = PlayerPrefs.GetInt("Slow Time").ToString();
            if (PlayerPrefs.GetInt("Slow Time") == 0)
                GetComponent<Image>().sprite = inactive;
            StartCoroutine(slow());
        }

    }
    IEnumerator slow()
    {
        Time.timeScale = 0.5f;
        yield return new WaitForSeconds(3f);
        Time.timeScale = 1f;
    }
    // Start is called before the first frame update
    void Start()
    {
        countslow = gameObject.transform.GetChild(0).transform.GetComponent<Text>();
        if (PlayerPrefs.HasKey("Slow Time"))
        {


            PlayerPrefs.SetInt("Slow Time", 2);
            countslow.text = "2";
        }
        else
        {
            countslow.text = PlayerPrefs.GetInt("Slow Time").ToString();
        }
        if (PlayerPrefs.GetInt("Slow Time") == 0)
            GetComponent<Image>().sprite = inactive;
        else
            GetComponent<Image>().sprite = active;

        void OnDisable()
        {
            Time.timeScale = 1f;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
