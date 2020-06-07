using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Buttons : MonoBehaviour
{
    public Sprite button, pressed;
    public bool music;
    private Image img;

    // Start is called before the first frame update
    void Start()
    {
        img = GetComponent<Image>();
    }
    void OnMouseDown()
    {
        img.sprite = pressed;
    }
    void OnMouseUp()
    {
        img.sprite = button;
    }
    void OnMouseUpAsButton()
    {
        GetComponent<AudioSource>().Play();
        switch (gameObject.name)
        {
            case "Replay":
                StartCoroutine(loadScene("game"));
                break;
            case "Play":
                StartCoroutine(loadScene("game"));
                break;
            case "Home":
                StartCoroutine(loadScene("Main"));
                break;
            case "Shop":
                StartCoroutine(loadScene("Shop"));
                break;
            case "How":
                StartCoroutine(loadScene("Study"));
                break;



        }




    }
    IEnumerator loadScene(string scene)
    {
        float fadeTime = Camera.main.GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(fadeTime);
        SceneManager.LoadScene(scene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
