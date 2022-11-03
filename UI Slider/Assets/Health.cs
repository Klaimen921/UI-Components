using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public Slider slider;
    void Update()
    {
        slider.value = Mathf.MoveTowards(slider.value, 100.0f, 0.15f);
    }
}
