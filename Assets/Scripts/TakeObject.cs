using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TakeObject : MonoBehaviour
{
    // Start is called before the first frame update

    //private Green[] green;
    [Tooltip("RecycleBin Objects")] [SerializeField] private RecycleBin[] recycleBin;
    [SerializeField] private TextMeshProUGUI textPoints;
    private const int GREEN = 0, ORANGE = 1, BLUE = 2;
    private const int ONE = 1;
    private int score = 0; // score of the player
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Green" && Input.GetKeyDown(KeyCode.Z))
        {
            recycleBin[GREEN].setOpenNumber(recycleBin[GREEN].getOpenNumber() + 1);
            // RecycleBinGreenOpen
            recycleBin[GREEN].setIsOpen(true);
            Destroy(collision.gameObject);
            TimedSpawnerRandom.numberOfRespawn--;
        }

        else if (collision.gameObject.tag == "Orange" && Input.GetKeyDown(KeyCode.Z))
        {
            recycleBin[ORANGE].setOpenNumber(recycleBin[ORANGE].getOpenNumber() + 1);
            // RecycleBinOrangeOpen
            recycleBin[ORANGE].setIsOpen(true);
            Destroy(collision.gameObject);
            TimedSpawnerRandom.numberOfRespawn--;
        }

        else if (collision.gameObject.tag == "Blue" && Input.GetKeyDown(KeyCode.Z))
        {
            recycleBin[BLUE].setOpenNumber(recycleBin[BLUE].getOpenNumber() + 1);
            // RecycleBinBlueOpen
            recycleBin[BLUE].setIsOpen(true);
            Destroy(collision.gameObject);
            TimedSpawnerRandom.numberOfRespawn--;
        }

        else if (collision.gameObject.tag == "RecycleBinBlue" && Input.GetKeyDown(KeyCode.Z) && recycleBin[BLUE].getIsOpen())
        {
            closeBin(BLUE);
            addPoint();

        }

        else if (collision.gameObject.tag == "RecycleBinGreen" && Input.GetKeyDown(KeyCode.Z) && recycleBin[GREEN].getIsOpen())
        {
            closeBin(GREEN);
            addPoint();

        }

        else if (collision.gameObject.tag == "RecycleBinOrange" && Input.GetKeyDown(KeyCode.Z) && recycleBin[ORANGE].getIsOpen())
        {
            closeBin(ORANGE);
            addPoint();
        }
        

        
    }

    private void closeBin(int color) // Close recyclebin
    {
        // RecycleBinColorClose
        if (recycleBin[color].getOpenNumber() == 1)
        {
            recycleBin[color].setOpenNumber(recycleBin[color].getOpenNumber() - 1);
            recycleBin[color].setIsOpen(false);
        }
       
        else
            recycleBin[color].setOpenNumber(recycleBin[color].getOpenNumber() - 1);
    }

    private void addPoint()
    {
        //AddPoint
        textPoints.text = "Score: " + (++score); // add point to the GUI
    }
  
    public int getScore()
    {
        return score;
    }


}
