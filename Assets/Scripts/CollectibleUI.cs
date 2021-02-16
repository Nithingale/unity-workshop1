using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectibleUI : MonoBehaviour
{
    public Text text;

    void Update()
    {
        text.text = "Collected: " + GameData.collectedCount.ToString();
    }
}
