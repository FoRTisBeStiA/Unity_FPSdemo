using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {
    [SerializeField] private Text scorelabel;
    [SerializeField] private SettingsPopup settingsPopup; 

	// Use this for initialization
	
    private int _score;
    
    void Awake() {
        Messenger.AddListener(GameEvent.ENEMY_HIT, OnEnemyHit);
    }

    void OnDestroy() {
        Messenger.RemoveListener(GameEvent.ENEMY_HIT, OnEnemyHit);
    }

    void Start() {
        _score += 0;
        scorelabel.text = _score.ToString();

        settingsPopup.Close();
    }

    private void OnEnemyHit() {
        _score += 1;
        scorelabel.text = _score.ToString();
    }

    public void OnOpenSettings() {
        settingsPopup.Open();
    }
}
