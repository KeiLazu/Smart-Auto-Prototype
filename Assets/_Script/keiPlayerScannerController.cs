/// <summary>
/// keiPlayerScannerController V 1.1
/// Kei Lazu
/// 
/// Desc:
/// Player as A.I. need to scan the enemy and attack by itself based on rules i provide
/// 
/// Rules:
/// - The lower the turn, the more it will be priority
/// - Attacking enemy needs "priority element", min attacking with same element, fighting with weaker element if there's no other option
/// - if A.I. getting hit, game over, start wave from 1, increase the death counter
/// - Flow of A.I.: Scan, Understand, Prioritizing, Attack, Repeat
/// 
/// Changelog:
/// 1.1: Type of Enemy now can be scanned
/// 
/// </summary>

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class keiPlayerScannerController : MonoBehaviour {

    // TODO: Scan enemies' Type without looking to "keiAmIOn" Parameter from keiEnemyStatusController

    // Start Region: Init -------------------------------

    // Region: Listing with array
    int[] keiEnemyElement = new int[9];
    int[] keiEnemyType = new int[9];

    // Region: Intel
    keiInitializatorGameObject keiEnemyPosition;

    // Region: Image for scanning the enemy
    Image[] keiEnemyPositionIntel = new Image[9];

    // Region: Text for scanning enemy's type
    Text[] keiEnemyTypeIntel = new Text[9];

    private void Awake()
    {
        keiEnemyPosition = GameObject.Find("keiInitializatorScript").GetComponent<keiInitializatorGameObject>();

        // Region: Populating Array (Image) for scanning enemy element state
        //keiPopulatingPosIntel(keiEnemyPosition);

        // Region: Populating Array (Text) for scanning enemy type state
        //keiPopulatingTypeIntel(keiEnemyPosition);
        
    }

    public void keiPopulatingPosIntel(keiInitializatorGameObject kei_EnemyPosition)
    {        
        keiEnemyPositionIntel[0] = kei_EnemyPosition.keiEnemyA1;
        keiEnemyPositionIntel[1] = kei_EnemyPosition.keiEnemyA2;
        keiEnemyPositionIntel[2] = kei_EnemyPosition.keiEnemyA3;

        keiEnemyPositionIntel[3] = kei_EnemyPosition.keiEnemyB1;
        keiEnemyPositionIntel[4] = kei_EnemyPosition.keiEnemyB2;
        keiEnemyPositionIntel[5] = kei_EnemyPosition.keiEnemyB3;

        keiEnemyPositionIntel[6] = kei_EnemyPosition.keiEnemyC1;
        keiEnemyPositionIntel[7] = kei_EnemyPosition.keiEnemyC2;
        keiEnemyPositionIntel[8] = kei_EnemyPosition.keiEnemyC3;

    }

    public void keiPopulatingTypeIntel(keiInitializatorGameObject kei_EnemyPosition)
    {
        keiEnemyTypeIntel[0] = kei_EnemyPosition.keiEnemyCountA1;
        keiEnemyTypeIntel[1] = kei_EnemyPosition.keiEnemyCountA2;
        keiEnemyTypeIntel[2] = kei_EnemyPosition.keiEnemyCountA3;

        keiEnemyTypeIntel[3] = kei_EnemyPosition.keiEnemyCountB1;
        keiEnemyTypeIntel[4] = kei_EnemyPosition.keiEnemyCountB2;
        keiEnemyTypeIntel[5] = kei_EnemyPosition.keiEnemyCountB3;

        keiEnemyTypeIntel[6] = kei_EnemyPosition.keiEnemyCountC1;
        keiEnemyTypeIntel[7] = kei_EnemyPosition.keiEnemyCountC2;
        keiEnemyTypeIntel[8] = kei_EnemyPosition.keiEnemyCountC3;

    }

    private void Start()
    {
        Invoke("keiStateScanningEnemy", 1f);

    }

    // End Region: Init ---------------------------------

    public void keiStateScanningEnemy()
    {
        keiEnemyPosition.keiLogPlayer.transform.Find("keiLogState").GetComponent<Text>().text = "State: Scanning";

        // Scan enemy based on Position
        keiStateScanningEnemyPosition();

        // Scan type of the enemy
        keiStateScanningEnemyType();

    }

    public void keiStateScanningEnemyPosition()
    {
        keiPopulatingPosIntel(keiEnemyPosition);

        for (int i = 0; i < keiEnemyPositionIntel.Length; i++)
        {
            //Debug.Log(keiEnemyPositionIntel[i]);
            if (keiEnemyPositionIntel[i].color != Color.white)
            {
                Color keiCheckEnemyElement = keiEnemyPositionIntel[i].color;

                if (keiCheckEnemyElement == Color.red)
                {
                    keiEnemyElement[i] = 1;
                    //Debug.Log("Detected: Pos " + i + " with color: Red");
                    continue;

                }
                else if (keiCheckEnemyElement == Color.cyan)
                {
                    keiEnemyElement[i] = 2;
                    //Debug.Log("Detected: Pos " + i + " with color: Cyan");
                    continue;

                }
                else if (keiCheckEnemyElement == Color.green)
                {
                    keiEnemyElement[i] = 3;
                    //Debug.Log("Detected: Pos " + i + " with color: Green");
                    continue;

                }
                else if (keiCheckEnemyElement == Color.yellow)
                {
                    keiEnemyElement[i] = 4;
                    //Debug.Log("Detected: Pos " + i + " with color: Yellow");
                    continue;

                }
                else if (keiCheckEnemyElement == Color.magenta)
                {
                    keiEnemyElement[i] = 5;
                    //Debug.Log("Detected: Pos " + i + " with color: Magenta");
                    continue;

                }
                else if (keiCheckEnemyElement == Color.gray)
                {
                    keiEnemyElement[i] = 6;
                    //Debug.Log("Detected: Pos " + i + " with color: Gray");
                    continue;

                } // end if not white color

            }
            else
            {
                keiEnemyElement[i] = 0;
                //Debug.Log("Detected: Pos " + i + " with color: White");
                continue;

            } // end if color white or not

        } // end for scanning enemy

    }

    public void keiStateScanningEnemyType()
    {
        keiPopulatingTypeIntel(keiEnemyPosition);

        for (int i = 0; i < keiEnemyTypeIntel.Length; i++)
        {
            if (keiEnemyElement[i] != 0)
            {
                keiEnemyType[i] = keiStateConvertingDataEnemyType(i);

            }
            else
            {
                keiEnemyType[i] = 0;

            }

            Debug.Log("Pos: " + i + " || Color: " + keiEnemyElement[i] + " || Type: " + keiEnemyType[i]);

        }

    }

    public int keiStateConvertingDataEnemyType(int cursor)
    {
        return int.Parse(keiEnemyPosition.keiEnemyPlacement.transform.GetChild(cursor).GetChild(0).GetComponent<Text>().text);

    }

}
