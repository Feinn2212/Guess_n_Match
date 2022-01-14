using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public Sprite[] cardFaces;
    public Sprite cardBack;
    public GameObject[] cards;
    public Text matchText;
    private bool _init = false;
    private int _matches = 10;
    
    void Update()
    {
        if (!_init)
        {
            initializeCards();
        }
        if (Input.GetMouseButtonUp(0))
        {
            checkCards();
        }
    }

    void initializeCards()
    {
        //2 kali, soalnya setiap kartu punya pasangan
        for (int id = 0; id < 2; id++)
        {
            //10 pasangan kartu
            for (int i = 1; i < 11; i++)
            {
                bool test = false;
                int choice = 0;
                while (!test)
                {
                    choice = Random.Range (0, cards.Length);
                    //ngecek kartu yang blom dispawn
                    test = !(cards[choice].GetComponent<Card>().initialized);
                }
                cards[choice].GetComponent<Card>().cardValue = i;
                cards[choice].GetComponent<Card>().initialized = true;
            }
        }
        foreach (GameObject c in cards)
        {
            c.GetComponent<Card>().setupGraphics();
        }
        if (!_init)
        {
            _init = true;
        }
    }

    public Sprite getCardBack()
    {
        return cardBack;
    }
    public Sprite getCardFace(int i)
    {
        return cardFaces[i-1];
    }
    void checkCards()
    {
        List<int> c = new List<int> ();
        for (int i = 0; i < cards.Length; i++)
        {
            //Kartu face-up -> tambahin ke list
            if (cards[i].GetComponent<Card>().state == 1)
            {
                c.Add(i);
            }
        }
        if (c.Count == 2)
        {
            cardComparison(c);
        }
    }

    void cardComparison(List<int> c)
    {
        Card.DO_NOT = true;
        int x = 0;
        if(cards[c[0]].GetComponent<Card>().cardValue == cards[c[1]].GetComponent<Card>().cardValue)
        {
            x = 2;
            AudioManager.instance.Play("match");
            _matches--;
            matchText.text = "Number of Matches: " + _matches;
            if (_matches == 0)
            {
                //SceneManager.LoadScene
            }
        }
        for (int i = 0; i < c.Count; i++)
        {
            cards [c[i]].GetComponent<Card>().state = x;
            cards [c[i]].GetComponent<Card>().falseCheck();
        }
    }
}
