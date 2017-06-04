﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
namespace MDUI
{
    public class MDText : MonoBehaviour
    {
        // fields visible in Unity3d inspector


        // Use this for initialization
        void Start()
        {
            apply(this.GetComponentInChildren<RectTransform>());
            apply(this.GetComponentInChildren<Text>());
        }

        // Update is called once per frame
        void Update()
        {

        }

        // Use this for editor reset component button
        void Reset()
        {
            apply(this.GetComponentInChildren<RectTransform>());
            apply(this.GetComponentInChildren<Text>());
        }

        public static void apply(RectTransform comp)
        {
            SetSize(comp, new Vector2(260, 100));
        }

        [System.Obsolete]
        public static void SetSize(RectTransform trans, Vector2 size)
        {
            Vector2 currSize = trans.rect.size;
            Vector2 sizeDiff = size - currSize;
            trans.offsetMin = trans.offsetMin -
            new Vector2(sizeDiff.x * trans.pivot.x,
                sizeDiff.y * trans.pivot.y);
            trans.offsetMax = trans.offsetMax +
            new Vector2(sizeDiff.x * (1.0f - trans.pivot.x),
                sizeDiff.y * (1.0f - trans.pivot.y));
        }
        public static void apply(Text txt)
        {
            if (txt != null)
            {
                txt.font = MDTheme.get().font;
                txt.fontSize = MDTheme.get().fontSize;
                txt.color = MDTheme.get().color;
                txt.fontStyle = MDTheme.get().fontStyle;
                // SCALE
                txt.resizeTextForBestFit = true;
                txt.resizeTextMinSize = 12;
                txt.resizeTextMaxSize = 40;

            }
        }
    }
}
