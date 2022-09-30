using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TicTacToe : MonoBehaviour
{
    public Transform buttonHolder;
    public Sprite X;
    public Sprite O;
    public Sprite normal;
    public int turn = 0; //x is 0, O is 1

    public void ButtonClick() 
    {
        string ClickedButtonName = EventSystem.current.currentSelectedGameObject.name;
        GameObject button = GameObject.Find(ClickedButtonName);
        if (turn == 0)
        {
            button.GetComponent<Image>().sprite = X;
            button.GetComponent<Button>().interactable = false;
            turn = 1;
        }
        else {
            button.GetComponent<Image>().sprite = O;
            button.GetComponent<Button>().interactable = false;
            turn = 0;
        }
    }


    public void Reset()
    {
        for (int i = 0; i < 9; i++)
        {
            buttonHolder.GetChild(i).gameObject.GetComponent<Button>().interactable = true;
            buttonHolder.GetChild(i).gameObject.GetComponent<Image>().sprite = normal;

        }
    }

}
