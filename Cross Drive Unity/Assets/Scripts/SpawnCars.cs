using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCars : MonoBehaviour
{
    public GameObject[] cars;
    private float startSpawn = 0.5f, waitSpawn = 3f;
    private int countCars = 0;
    private bool onesStop;
    void Start()
    {
        StartCoroutine(leftCars());
        StartCoroutine(rightCars());
        StartCoroutine(upCars());
        StartCoroutine(downCars());
        CollisionCars.lose = false;
    }

    IEnumerator leftCars()
    {
        yield return new WaitForSeconds(UnityEngine.Random.Range(startSpawn, startSpawn + 4.5f));
        while (true)
        {
            GameObject carInst = Instantiate(cars[Random.Range(0, cars.Length)], new Vector3(-131f, -0.175f, -8.7f), Quaternion.Euler(new Vector3(0, -90f, 0))) as GameObject;
            countCars++;
            int rand = Random.Range(0, 4);
            switch (rand)
            {
                case 1:
                    carInst.AddComponent<LLeft>();
                    break;
                case 2:
                    carInst.AddComponent<LRight>();
                    break;


            }
            yield return new WaitForSeconds(Random.Range(waitSpawn, waitSpawn + 5f));
        }
    }
    IEnumerator rightCars()
    {
        yield return new WaitForSeconds(UnityEngine.Random.Range(startSpawn, startSpawn + 4.5f));
        while (true)
        {
            GameObject carInst = Instantiate(cars[Random.Range(0, cars.Length)], new Vector3(-47.74f, -0.175f, -0.56f), Quaternion.Euler(new Vector3(0, 90f, 0))) as GameObject;
            countCars++;
            int rand = Random.Range(0, 4);
            switch (rand)
            {
                case 1:
                    carInst.AddComponent<RLeft>();
                    break;
                case 2:
                    carInst.AddComponent<RRight>();
                    break;


            }
            yield return new WaitForSeconds(Random.Range(waitSpawn, waitSpawn + 5f));
        }
    }
    IEnumerator upCars()
    {
        yield return new WaitForSeconds(UnityEngine.Random.Range(startSpawn, startSpawn + 4.5f));
        while (true)
        {
            GameObject carInst = Instantiate(cars[Random.Range(0, cars.Length)], new Vector3(-83.3f, -0.175f, 47.6f), Quaternion.Euler(new Vector3(0, 1f, 0))) as GameObject;
            countCars++;
            int rand = Random.Range(0, 4);
            switch (rand)
            {
                case 1:
                    carInst.AddComponent<ULeft>();
                    break;
                case 2:
                    carInst.AddComponent<URight>();
                    break;


            }
            yield return new WaitForSeconds(Random.Range(waitSpawn, waitSpawn + 5f));
        }
    }
    IEnumerator downCars()
    {
        yield return new WaitForSeconds(UnityEngine.Random.Range(startSpawn, startSpawn + 4.5f));
        while (true)
        {
            GameObject carInst = Instantiate(cars[Random.Range(0, cars.Length)], new Vector3(-76.66f, -0.175f, -43.34f), Quaternion.Euler(new Vector3(0, 180f, 0))) as GameObject;
            countCars++;
            int rand = Random.Range(0, 4);
            switch (rand)
            {
                case 1:
                    carInst.AddComponent<DLeft>();
                    break;
                case 2:
                    carInst.AddComponent<DRight>();
                    break;


            }
            yield return new WaitForSeconds(Random.Range(waitSpawn, waitSpawn + 5f));
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (countCars > 60)
            waitSpawn = 1f;
        else if (countCars > 40)
            waitSpawn = 1f;
        else if (countCars > 20)
            waitSpawn = 2f;
        if (CollisionCars.lose && !onesStop)
        {
            StopAllCoroutines();
            onesStop = true;
        }
            
    }
}
