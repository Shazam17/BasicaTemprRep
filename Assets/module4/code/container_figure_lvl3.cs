﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class container_figure_lvl3 : MonoBehaviour
{
    public string type;

    public AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        dragFigure fig = other.GetComponent<dragFigure>();
        fig.outSide = false;
        if (type == fig.type)
        {
            fig.OffDrag(GetComponent<RectTransform>().localPosition);
        }
       
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        dragFigure fig = other.GetComponent<dragFigure>();
        fig.outSide = true;
    }
}
