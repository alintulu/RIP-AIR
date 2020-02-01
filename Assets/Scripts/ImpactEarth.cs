using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ImpactEarth : MonoBehaviour
{

    // Healthy earth has value -1, dead earth has value 4
    private int earthState = 0;
    // State at which Earth dies
    private int doomState = 4;
    public float healingTime = 5f;

    private float lastClicked;
    // Background sprite
    private GameObject bkg;

    public Sprite healthy;
    public Sprite pollutionOne;
    public Sprite pollutionTwo;
    public Sprite pollutionThree;
    public Sprite pollutionFour;
    // List of backgrounds
    private List<Sprite> bkgs = new List<Sprite>();

    // Start is called before the first frame update
    void Start()
    {
        bkgs.Add(healthy);
        bkgs.Add(pollutionOne);
        bkgs.Add(pollutionTwo);
        bkgs.Add(pollutionThree);
        bkgs.Add(pollutionFour);      
    }

    private void DestroyEarth() {
        	earthState++;
            this.GetComponent<SpriteRenderer>().sprite = bkgs[earthState];
            lastClicked = Time.time;
    }

    private void HealEarth() {
			earthState--;
            this.GetComponent<SpriteRenderer>().sprite = bkgs[earthState];
            lastClicked = Time.time;
    }

    private void KillEarth() {
        SceneManager.LoadScene("EndScene", LoadSceneMode.Single);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            if (earthState == doomState) {
                KillEarth();
            } else {
                DestroyEarth();
            }
        }

        if (Time.time - lastClicked > healingTime && earthState > 0) {
            Debug.Log(Time.time - lastClicked);
            HealEarth();
        }
        
    }
}
