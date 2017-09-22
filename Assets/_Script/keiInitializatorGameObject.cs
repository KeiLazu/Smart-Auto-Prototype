/// <summary>
/// keiInitializatorGameObject V 1.0
/// Kei Lazu
/// 
/// Desc:
/// Automatic Initializator, if you need to call game object just call me
/// 
/// </summary>

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keiInitializatorGameObject : MonoBehaviour
{
    // Start Region: Init -----------------------

    // Region: Pathfinder
    public GameObject keiEnemyPlacement;
    public GameObject keiLogPlayer;

    // Region: Image
    public Image keiEnemyA1, keiEnemyA2, keiEnemyA3,
        keiEnemyB1, keiEnemyB2, keiEnemyB3,
        keiEnemyC1, keiEnemyC2, keiEnemyC3;

    // Region: Text for Enemy Type
    public Text keiEnemyCountA1, keiEnemyCountA2, keiEnemyCountA3,
        keiEnemyCountB1, keiEnemyCountB2, keiEnemyCountB3,
        keiEnemyCountC1, keiEnemyCountC2, keiEnemyCountC3;

    // Region: Text for Player Log
    public Text keiLogAttacking, keiLogSlot, keiLogElement, keiLogWave, keiLogState;

    private void Awake()
    {
        // Region: Init Gameobject
        keiEnemyPlacement = GameObject.FindGameObjectWithTag("keiEnemyPlacement");
        keiLogPlayer = GameObject.FindGameObjectWithTag("keiPlayerLog");

        // Region: Init Image
        keiEnemyA1 = keiEnemyPlacement.transform.Find("keiEnemyA1").GetComponent<Image>();
        keiEnemyA2 = keiEnemyPlacement.transform.Find("keiEnemyA2").GetComponent<Image>();
        keiEnemyA3 = keiEnemyPlacement.transform.Find("keiEnemyA3").GetComponent<Image>();

        keiEnemyB1 = keiEnemyPlacement.transform.Find("keiEnemyB1").GetComponent<Image>();
        keiEnemyB2 = keiEnemyPlacement.transform.Find("keiEnemyB2").GetComponent<Image>();
        keiEnemyB3 = keiEnemyPlacement.transform.Find("keiEnemyB3").GetComponent<Image>();

        keiEnemyC1 = keiEnemyPlacement.transform.Find("keiEnemyC1").GetComponent<Image>();
        keiEnemyC2 = keiEnemyPlacement.transform.Find("keiEnemyC2").GetComponent<Image>();
        keiEnemyC3 = keiEnemyPlacement.transform.Find("keiEnemyC3").GetComponent<Image>();

        // Region: Init Text
        keiEnemyCountA1 = keiEnemyA1.transform.GetChild(0).GetComponent<Text>(); 
        keiEnemyCountA2 = keiEnemyA2.transform.GetChild(0).GetComponent<Text>();
        keiEnemyCountA3 = keiEnemyA3.transform.GetChild(0).GetComponent<Text>();

        keiEnemyCountB1 = keiEnemyB1.transform.GetChild(0).GetComponent<Text>();
        keiEnemyCountB2 = keiEnemyB2.transform.GetChild(0).GetComponent<Text>();
        keiEnemyCountB3 = keiEnemyB3.transform.GetChild(0).GetComponent<Text>();

        keiEnemyCountC1 = keiEnemyC1.transform.GetChild(0).GetComponent<Text>();
        keiEnemyCountC2 = keiEnemyC2.transform.GetChild(0).GetComponent<Text>();
        keiEnemyCountC3 = keiEnemyC3.transform.GetChild(0).GetComponent<Text>();

    }

    // End Region: Init -------------------------
}