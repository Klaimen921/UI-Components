using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BombRed : MonoBehaviour
{
    public void TurnRed()
    {
        GetComponent<Image>().color = Color.red;
    }
}