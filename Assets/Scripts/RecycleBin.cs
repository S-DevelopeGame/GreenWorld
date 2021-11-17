using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RecycleBin : MonoBehaviour
{
    [Tooltip("open the recyclebin")] [SerializeField] private bool isOpen;
    [Tooltip("number that the recyclebin will be open")] [SerializeField] private int openNumber;


    public void setIsOpen(bool isOpen)
    {
        this.isOpen = isOpen;
    }

    public bool getIsOpen()
    {
        return isOpen;
    }

    public void setOpenNumber(int openNumber)
    {
        this.openNumber = openNumber;
    }

    public int getOpenNumber()
    {
        return this.openNumber;
    }

}
