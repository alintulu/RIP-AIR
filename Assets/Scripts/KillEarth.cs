using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillEarth : MonoBehaviour
{
    private int earthState = 0;
    public float buffer = 1f;

    // Background sprite
    private GameObject bkg;

    private float lastClicked;

    public Sprite one;
    public Sprite two;
    public Sprite three;
    public Sprite four;
    public Sprite five;
    public Sprite six;
    public Sprite seven;
    public Sprite eight;
    public Sprite nine;
    public Sprite ten;
    public Sprite eleven;
    public Sprite twelve;
    public Sprite thirteen;
    public Sprite fourteen;
    public Sprite fifteen;
    public Sprite sixteen;
    // List of backgrounds
    private List<Sprite> bkgs = new List<Sprite>();

    // Start is called before the first frame update
    void Start()
    {
        bkgs.Add(one);
        bkgs.Add(two);
        bkgs.Add(three);
        bkgs.Add(four);
        bkgs.Add(five); 
        bkgs.Add(six);
        bkgs.Add(seven);
        bkgs.Add(eight);
        bkgs.Add(nine);
        bkgs.Add(ten);
        bkgs.Add(eleven);
        bkgs.Add(twelve);
        bkgs.Add(fourteen);
        bkgs.Add(fifteen);
        bkgs.Add(sixteen);      
    }

    private void DestroyEarth() {
            this.GetComponent<SpriteRenderer>().sprite = bkgs[earthState];
            earthState++;
            lastClicked = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Time.time - lastClicked > buffer && earthState < 15) {
            DestroyEarth();
        }

        if (earthState >= 15) {
            if (Input.anyKeyDown)
            {
                SceneManager.LoadScene("StartScene", LoadSceneMode.Single);
            }
        }
        
    }
}
