using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public void openUrl()
    {
        Application.OpenURL("https://vk.com/increatives");
    }

    float timer;

    public GameObject btnLoad;

    float aColor;

    float aCurrentColor;
    
    bool giveAColor;

    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 37)
        {
            if(!giveAColor)
            {
                aCurrentColor = btnLoad.GetComponent<Image>().color.a;
                giveAColor = true;
            }
            if(aCurrentColor >= 0.99f)
            {
                aColor += (Time.deltaTime * 0.5f);
                btnLoad.SetActive(true);
                btnLoad.GetComponent<Image>().color = new Color(1,1,1,aColor);
            }
        }
    }
}
