using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public static gameControl instance;
    public Text scoreText;
    public GameObject gameOvertext;

    private int score = 0;
    public bool gameOver = false;
    public float scrollSpeed = -1.5f;

    void Awake()
    {
        //If we dont currentyly hasave a game control...
        if (instance == null)
            // ... set thsi one to be it
            instance = this;
        // otherwise
        else if (instance != this)
            //Destroy this one because it is a duplicate
            Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //public void BirdDied()

}
