using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeManager : MonoBehaviour
{
    [SerializeField] SpriteRenderer player;
    [SerializeField] Colors colors;
    [SerializeField] ChangeColor changeColor;
    [SerializeField] CheckColor checkColor;

    bool colorStateGreen = false;
    bool colorStatePurple = false;
    bool colorStateOrange = false;
    bool colorStateBlue = false;
    bool colorStateRed = false;
    bool colorStateYellow = false;


    public string blendColor;

    private void Awake()
    {
        player = GetComponent<SpriteRenderer>();
        colors = GetComponent<Colors>();
        changeColor = GetComponent<ChangeColor>();
        checkColor = GetComponent<CheckColor>();
    }



    void Update()
     {
        if (checkColor.touchingColor == true && checkColor.index == 0)
        {
            if (checkColor.objectColor[0] == "Yellow")
            {
                changeColor.ColorChange(player, colors.YellowHexVal);
                colorStateYellow = true;

            }
            else if (checkColor.objectColor[0] == "Blue")
            {
                changeColor.ColorChange(player, colors.blueHexVal);
                colorStateBlue = true;

            }
            else if (checkColor.objectColor[0] == "Red")
            { 
               changeColor.ColorChange(player, colors.RedHexVal);
               colorStateRed = true;

            }

        }
        else if (checkColor.touchingColor == true && checkColor.index > 0)
        {
            blendColor = checkColor.objectColor[0] + checkColor.objectColor[1];
            if (blendColor == "YellowBlue" || blendColor == "BlueYellow")
            {
                changeColor.ColorChange(player, colors.greenHexVal);
                colorStateGreen = true;
            }
            if (blendColor == "RedBlue" || blendColor == "BlueRed")
            {
                changeColor.ColorChange(player, colors.purpleHexVal);
                colorStatePurple = true;
            }
            if (blendColor == "RedYellow" || blendColor == "YellowRed")
            {
                changeColor.ColorChange(player, colors.orangeHexVal);
                colorStateOrange = true;
            }
        }
     }

}
