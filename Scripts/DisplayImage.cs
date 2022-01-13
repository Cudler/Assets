using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayImage : MonoBehaviour
{
    [SerializeField] private Image display;
    [SerializeField] private bool useDef;
    [SerializeField] private Sprite defaultImage;

    private void OnEnable()
    {
       if(defaultImage && useDef)
        {
            SetImage(defaultImage);
        }
    }

    public void SetImage(Sprite sprite)
    {
        display.sprite = sprite;
        display.SetNativeSize();
        display.preserveAspect = true;
        display.rectTransform.sizeDelta = new Vector2(200, 200);

    }
}
