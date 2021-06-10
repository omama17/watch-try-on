using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class ColorSelect : MonoBehaviour
{
    public Material band1;
    public Material band2;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void w1ColorSelect()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        if(buttonName == "black Button")
        {
            
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#000000", out myColor);
            band1.color = myColor;
        } 
        else if(buttonName == "blue Button ")
        {
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#103B90", out myColor);
            band1.color = myColor;

        }
    }
    public void w2ColorSelect()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        if (buttonName == "black Button")
        {
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#000000", out myColor);
            band2.color = myColor;

        }
        else if (buttonName == "red Button ")
        {
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#740202", out myColor);
            band2.color = myColor;

        }
    }
}
