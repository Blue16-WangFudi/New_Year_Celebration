using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFade : MonoBehaviour {
    private Outline outline;
    public float duration = 5f;
    private float time;
    private Color targetColor;
    private Color curColor;
    private void Awake() {
        outline = this.GetComponent<Outline>();
    }
    void Start(){
        outline.effectColor = Color.white;
        curColor = Color.white;
        targetColor = new Color(212 / 255f, 98 / 255f, 1, 1);
        time = 0;
    }
    // Update is called once per frame
    void Update() {
        time += Time.deltaTime;
        if (time<duration) {
            Color result = Color.Lerp(curColor,targetColor,time/duration);
            outline.effectColor = result;
        } else {
            time = 0;
            Color tmp = curColor;
            curColor = targetColor;
            targetColor = tmp;
        }
        Debug.Log(time/duration+":"+outline.effectColor);
    }
}
