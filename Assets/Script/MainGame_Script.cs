using UnityEngine;
using System.Collections;
[ExecuteInEditMode]

public class MainGame_Script : MonoBehaviour {
    public int beatNumber = 0;
    public int beatDelay = 3;
    public int BPM = 100;
    public float timeToUpdateBeat;
    public float approachRate = 5;

    public float beatTimer = 0;
	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
	    if(Application.isPlaying == true)
        {
            timeToUpdateBeat = (60 / (float)BPM);
            UpdateBeat();
        }
	}
    
    void UpdateBeat()
    {
        beatTimer += Time.deltaTime;
        if (beatTimer >= timeToUpdateBeat)
        {
            beatNumber++;
            beatTimer -= timeToUpdateBeat;
        }
    }
}
