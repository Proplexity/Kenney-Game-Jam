using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    Color color;

    public void ColorChange(SpriteRenderer player, string hexColorVal)
    {  
        if (ColorUtility.TryParseHtmlString(hexColorVal, out color))
        {
            player.color = color;
        }
    }




}
