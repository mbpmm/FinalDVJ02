using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonobehaviourSingleton<GameManager>
{
    public int score;
    public float time;
    public Car car;
    public GameObject carGO;
    // Start is called before the first frame update
    void OnEnable()
    {
        Car.carStarted += SetCar;
        Car.pickUpCollected += AddScore;
    }

    // Update is called once per frame
    void Update()
    {
        if (car.gameStarted)
        {
            time -= Time.deltaTime;
        }
    }

    public void SetCar(Car go)
    {
        car = go;
        carGO = go.gameObject;
    }

    public void AddScore()
    {
        score += 100;
    }
}
