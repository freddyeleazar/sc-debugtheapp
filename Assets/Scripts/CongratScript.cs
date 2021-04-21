﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CongratScript : MonoBehaviour
{
    public TextMesh text;
    public ParticleSystem sparksParticles;
    
    private List<string> textToDisplay = new List<string>();
    
    private float rotatingSpeed;
    private float timeToNextText;

    private int currentText;
    
    // Start is called before the first frame update
    void Start()
    {
        timeToNextText = 0.0f;
        currentText = 0;
        
        rotatingSpeed = 2.0f;

        textToDisplay.Add("Congratulation");
        textToDisplay.Add("All Errors Fixed");

        text.text = textToDisplay[0];
        
        sparksParticles.Play();
    }

    // Update is called once per frame
    void Update()
    {
        timeToNextText += Time.deltaTime;
        if (timeToNextText > rotatingSpeed)
        {
            currentText++;
            if (currentText < textToDisplay.Count)
            {
                text.text = textToDisplay[currentText];
                timeToNextText = 0.0f;
            }
        }
    }
}