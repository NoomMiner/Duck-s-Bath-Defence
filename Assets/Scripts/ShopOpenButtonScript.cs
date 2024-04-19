using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Color = UnityEngine.Color;
using Image = UnityEngine.UI.Image;

public class ShopOpenButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Image>().color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClick()
    {
        if (this.GetComponent<Image>().color == Color.green)
        {

            this.GetComponent<Image>().color = Color.red;
        }
        else
        {
            this.GetComponent<Image>().color = Color.green;
        }


    }
}
