using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Language : MonoBehaviour
{
    public GameObject[] languages_canvas; // 0 = TR, 1 = ENG
    
    // Start is called before the first frame update
    void Start()
    {
        languages_canvas[1].SetActive(false); // Starts with TR.
        languages_canvas[0].SetActive(true);
    }

    private void Update()
    {
        if (PlayerPrefs.GetInt("dil") == 0)
        {
            languages_canvas[1].SetActive(false);
            languages_canvas[0].SetActive(true);
        }
        if (PlayerPrefs.GetInt("dil") == 1)
        {
            languages_canvas[0].SetActive(false);
            languages_canvas[1].SetActive(true);
        }
    }

    public void langcontrol(string language)
    {
        if (language == "TR")
        {
            languages_canvas[1].SetActive(false);
            languages_canvas[0].SetActive(true);
            PlayerPrefs.SetInt("dil", 0);
        }
        if (language == "ENG")
        {
            languages_canvas[0].SetActive(false);
            languages_canvas[1].SetActive(true);
            PlayerPrefs.SetInt("dil",1);
        }
    }
}
