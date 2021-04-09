﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField]
    private Transform player;
    [SerializeField]
    private Text scoreText;

    private void Update()
    {
        scoreText.text = player.position.z.ToString("0");
    }

}
