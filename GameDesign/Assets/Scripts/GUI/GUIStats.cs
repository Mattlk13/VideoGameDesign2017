﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIStats : MonoBehaviour {

    public Text system, distance, station, hydrogen;
    SceneLoader sceneLoader;
    station stationScript;
    Controller ship;
	// Use this for initialization
	void Start () {
        sceneLoader = GameObject.Find("SceneLoader").GetComponent<SceneLoader>();
        stationScript = GameObject.Find("station(Clone)").GetComponent<station>();
        ship = GameObject.FindGameObjectWithTag("Player").GetComponent<Controller>();

        system = transform.GetChild(0).GetComponent<Text>();
        distance = transform.GetChild(1).GetComponent<Text>();
        station = transform.GetChild(2).GetComponent<Text>();
        hydrogen = transform.GetChild(4).GetComponent<Text>();

        system.text = "System:\nBDMSC - " + sceneLoader.seed;
        distance.text = "Distance from Sol: " + sceneLoader.seed;
        station.text = "Hydrogen of\nStation: "+ stationScript.molH;
        hydrogen.text = "(" + ship.hydrogen + ")";

    }

    private void OnGUI()
    {
        system.text = "System:\nBDMSC - " + sceneLoader.seed;
        distance.text = "Distance from Sol: " + sceneLoader.seed;
        station.text = "Hydrogen of\nStation: " + Mathf.Round((float)stationScript.molH * 10) / 10;
        hydrogen.text = "(" + Mathf.Round((float)ship.hydrogen * 10) / 10 + ")";
    }
}
