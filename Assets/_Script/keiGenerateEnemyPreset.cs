/// <summary>
/// keiGenerateEnemyPreset V 1.0
/// Kei Lazu
/// 
/// Desc:
/// Generate Position for enemy in packs....in case i'm too lazy to
/// code another one which is fully automatic, scripted, algorithmic, something else and
/// another cool words to make me super intelligent but actually just an "ordinary genuis"
/// 
/// -- look, i can't even spell "genius" properly lol
/// 
/// </summary>

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class keiGenerateEnemyPreset : MonoBehaviour {

    // Start Region: Init ---------------------------

    // Region: Int
    int keiEnemyPlaced = 0;

    // Region: Pathfinder
    keiInitializatorGameObject keiInitializator;

    // Region: Random
    Random keiRandomize = new Random();

    private void Awake()
    {
        keiInitializator = GameObject.Find("keiInitializatorScript").GetComponent<keiInitializatorGameObject>();
        
    }

    // End Region: Init -----------------------------

    // testing position
    private void Start()
    {
        keiGeneratePreset();

    }

    // Generating Enemy By Preset
    public void keiGeneratePreset()
    {
        if (keiEnemyPlaced < 1)
        {
            keiCoordsEnemyPreset(keiRandomize.Next(0, 3), keiRandomize.Next(0, 3));

        }
        else
        {
            CancelInvoke("keiGeneratePreset");
            return;

        }
        

    }

    public void keiCoordsEnemyPreset(int kei_EnemyCol, int kei_EnemyRow)
    {
        //Debug.Log("Col: " + kei_EnemyCol + " || Row: " + kei_EnemyRow); // Confirmation for enemy position

        switch (kei_EnemyCol)
        {
            case 0:
                switch (kei_EnemyRow)
                {
                    case 0:
                        keiInitializator.keiEnemyA1.GetComponent<keiEnemyStatusController>().keiIsTurnedOn();
                        keiEnemyPlaced++;
                        break;

                    case 1:
                        keiInitializator.keiEnemyB1.GetComponent<keiEnemyStatusController>().keiIsTurnedOn();
                        keiEnemyPlaced++;
                        break;

                    case 2:
                        keiInitializator.keiEnemyC1.GetComponent<keiEnemyStatusController>().keiIsTurnedOn();
                        keiEnemyPlaced++;
                        break;

                    default:
                        Debug.Log("Nope in First Col");
                        break;
                }

                break;

            case 1:
                switch (kei_EnemyRow)
                {
                    case 0:
                        keiInitializator.keiEnemyA2.GetComponent<keiEnemyStatusController>().keiIsTurnedOn();
                        keiEnemyPlaced++;
                        break;

                    case 1:
                        keiInitializator.keiEnemyB2.GetComponent<keiEnemyStatusController>().keiIsTurnedOn();
                        keiEnemyPlaced++;
                        break;

                    case 2:
                        keiInitializator.keiEnemyC2.GetComponent<keiEnemyStatusController>().keiIsTurnedOn();
                        keiEnemyPlaced++;
                        break;

                    default:
                        Debug.Log("Nope in Second Col");
                        break;

                }

                break;

            case 2:
                switch (kei_EnemyRow)
                {
                    case 0:
                        keiInitializator.keiEnemyA3.GetComponent<keiEnemyStatusController>().keiIsTurnedOn();
                        keiEnemyPlaced++;
                        break;

                    case 1:
                        keiInitializator.keiEnemyB3.GetComponent<keiEnemyStatusController>().keiIsTurnedOn();
                        keiEnemyPlaced++;
                        break;

                    case 2:
                        keiInitializator.keiEnemyC3.GetComponent<keiEnemyStatusController>().keiIsTurnedOn();
                        keiEnemyPlaced++;
                        break;

                    default:
                        Debug.Log("Nope in Third Col");
                        break;

                }

                break;

            default:
                Debug.Log("Nope in long gone");
                break;

        } // end Switch kei_EnemyCol

    }

}
