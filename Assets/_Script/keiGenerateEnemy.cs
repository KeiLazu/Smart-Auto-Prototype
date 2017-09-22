using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class keiGenerateEnemy : MonoBehaviour {

    int keiNumberToBoolConverter;

    bool[] keiColoumnEnemy = new bool[3];
    bool[] keiRowEnemy = new bool[3];

    Random randomize = new Random();

    public void keiGenerateEnemyPosition()
    {
        for (int keiCol = 0; keiCol < keiColoumnEnemy.Length; keiCol++)
        {
            for (int keiRow = 0; keiRow < keiRowEnemy.Length; keiRow++)
            {
                keiNumberToBoolConverter = randomize.Next(0, 1);

                if (keiNumberToBoolConverter == 1)
                {
                    // check wave

                }

            }

        }

    }

}
