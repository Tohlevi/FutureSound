using UnityEngine;
using System.Collections;


[ExecuteInEditMode]

public class Note_Script : MonoBehaviour {
    private GameObject MainGame;
    public enum Notes { Circle, Cross, Square, Triangle };
    public Notes noteTypes;
    public int Beat = 0;


    public Sprite CircleSprite;
    public Sprite CrossSprite;
    public Sprite SquareSprite;
    public Sprite TriangleSprite;

    private Notes lastSprite;

    public SpriteRenderer NoteSprite;
	// Use this for initialization
	void Start () {
        MainGame = GameObject.Find("MainGame");
        transform.SetParent(MainGame.transform.FindChild("BeatMap"));
        NoteSprite = GetComponent<SpriteRenderer>(); //Set SpriteRenderer
        lastSprite = noteTypes;
        UpdateSprite();
    }
	
	// Update is called once per frame
	void Update () {
        if (noteTypes != lastSprite)
        {
            lastSprite = noteTypes;
            UpdateSprite();
        }
	}

    void UpdateSprite()
    {
        switch (noteTypes)
        {
            case Notes.Circle:
                NoteSprite.sprite = CircleSprite;
                break;

            case Notes.Cross:
                NoteSprite.sprite = CrossSprite;
                break;

            case Notes.Square:
                NoteSprite.sprite = SquareSprite;
                break;

            case Notes.Triangle:
                NoteSprite.sprite = TriangleSprite;
                break;
        }

    }
}
