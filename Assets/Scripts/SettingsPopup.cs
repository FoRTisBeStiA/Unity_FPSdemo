using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsPopup : MonoBehaviour {

    [SerializeField] private Slider speedSlider;
    
    public void Open() {
        gameObject.SetActive(true);
    }

    public void Close() {
        gameObject.SetActive(false);
    }

    public void OnSubmitName(string name) {
        Debug.Log(name);
    }

    //public void OnSpeedValue(float speed) {
       
    //}

    public void OnSpeedValue(float value) {
        Messenger<float>.Broadcast(GameEvent.SPEED_CHANGED, speed);
        Debug.Log("Speed: " + speed);
    }
	// Use this for initialization
	void Start () {
        speedSlider.value = PlayerPrefs.GetFloat("speed", 1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
