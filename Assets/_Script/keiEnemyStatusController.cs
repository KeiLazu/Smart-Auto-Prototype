/// <summary>
/// keiEnemyStatusController V 1.0
/// Kei Lazu
/// 
/// Desc:
/// Controlling the status for enemy based on random pick for element and type
/// 
/// </summary>

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

public class keiEnemyStatusController : MonoBehaviour {

    // Region: Int
    int keiEnemyStatusElement; // Configuration for Element Type for Enemy
    int keiEnemyStatusType; // Configuration for Type For Enemy (Atk Speed: {Light: 3, Normal: 4, Heavy: 5})
    int keiEnemyStatusSpeed; // Configuration from Type for Speed attack, if speed attack is 0 then game over for player

    // Region: Boolean
    // Parameter to tell that this object is by default not on
    //bool keiAmIOn = false;

    // Region: Random
    Random keiRandomize = new Random();

    public void keiIsTurnedOn()
    {
        //gameObject.GetComponent<Image>().color = Color.cyan; // Confirming that this object is selected
        //Debug.Log(this.gameObject.name + " has been selected to attack player"); // Confirming that this object is selected

        keiEnemyStatusElement = keiRandomize.Next(0, 5);
        keiEnemyStatusType = keiRandomize.Next(0, 3);

        switch (keiEnemyStatusElement)
        {
            case 0: // fire
                gameObject.GetComponent<Image>().color = Color.red;
                break;

            case 1: // water
                gameObject.GetComponent<Image>().color = Color.cyan;
                break;

            case 2: // earth
                gameObject.GetComponent<Image>().color = Color.green;
                break;

            case 3: // light
                gameObject.GetComponent<Image>().color = Color.yellow;
                break;

            case 4: // dark
                gameObject.GetComponent<Image>().color = Color.magenta;
                break;

            default: // neutral (in case there's extra element, but let's hope this doesn't happen)
                gameObject.GetComponent<Image>().color = Color.gray;
                break;

        }

        switch (keiEnemyStatusType)
        {
            case 0: // Light
                keiEnemyStatusSpeed = 3;

                break;

            case 1: // Normal
                keiEnemyStatusSpeed = 4;

                break;

            case 2: // Heavy
                keiEnemyStatusSpeed = 5;

                break;

            default: // Super Heavy (in case there's an extra type, but let's hope this doesn't happen again)
                break;

        }

        gameObject.transform.GetChild(0).GetComponent<Text>().text = keiEnemyStatusSpeed.ToString();

        //keiAmIOn = true;

    }

}
