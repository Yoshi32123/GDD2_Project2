﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BrightnessFunctonality : MonoBehaviour
{
    //render is used to change shader value for all objects using it
    float brightness = 0;
    public Renderer rend;

    //sets slider to shader's value
    void Start()
    {
        float startValue = (rend.sharedMaterial.GetFloat("_Brightness") + 0.5f)/1.2f;
        Slider slider = gameObject.GetComponent<Slider>();
        slider.normalizedValue = startValue;
        brightness = startValue;
    }

    //when slider is moved, send new value to shader
    public void OnValueChanged(float newValue)
    {
        //range of -0.5f to 0.7f
        brightness = (newValue*1.2f)-0.5f;
        rend.sharedMaterial.SetFloat("_Brightness", brightness);
    }
}