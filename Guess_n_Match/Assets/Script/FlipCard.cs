using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipCard : MonoBehaviour
{
    // Start is called before the first frame update
    public float x, y, z;

    public GameObject cardFront;
    public GameObject cardBack;

    public bool cardFrontIsActive;
    public bool cardBackIsActive;

    public int timer;

    void Start()
    {
        cardFrontIsActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartFlip();
        }
    }

    public void StartFlip()
    {
        StartCoroutine(CalculateFlip());
    }

    public void Flip()
    {
        if(cardFrontIsActive == true)
        {
            cardFront.SetActive(false);
            cardFrontIsActive = false;
            cardBack.SetActive(true);
            cardBackIsActive = true;
        }
        else
        {
            cardFront.SetActive(true);
            cardFrontIsActive = true;
            cardBack.SetActive(false);
            cardBackIsActive = false;
        }
    }

    IEnumerator CalculateFlip()
    {
        for(int i=0 ; i<180; i++)
        {
            yield return new WaitForSeconds(0.001f);
            transform.Rotate(new Vector3(x, y, z));
            timer++;
            
            if(timer == 90 || timer == -90)
            {
                Flip();
            }
        }

        timer = 0;
    }




}
