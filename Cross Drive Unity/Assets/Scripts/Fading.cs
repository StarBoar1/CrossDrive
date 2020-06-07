using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fading : MonoBehaviour
{
    public Texture2D loadTexture;
    private float fadeSpeed = 0.9f;
    private int drowDeth = -1000;
    private float alpha = 1;
    private int fadeDir = -1;
    void OnGUI()
    {
        alpha += fadeDir * fadeSpeed * Time.deltaTime;
        alpha = Mathf.Clamp01(alpha);

        GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);
        GUI.depth = drowDeth;
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), loadTexture);
    }
    public float BeginFade(int direction)
    {
        fadeDir = direction;
        return fadeSpeed;
    }
    void OnEnable()
    {
        BeginFade(-1);
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
