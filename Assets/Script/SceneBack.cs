﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneBack : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Scene scene = SceneManager.GetSceneByName("first");
            //SceneManager.UnloadSceneAsync(scene);
            //SceneManager.LoadScene("first");
            //SceneManager
            Application.Quit();
        }
    }
}