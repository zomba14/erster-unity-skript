using UnityEngine;

public class SpielerWerte : MonoBehaviour
{
    float laufGeschwindigkeit = 5.5f;

    int aktuellesLevel = 1;

    void Start()
    {
        Debug.Log("Laufgeschwindigkeit: " + laufGeschwindigkeit);
        Debug.Log("Aktuelles Level: " + aktuellesLevel);
    }
}
