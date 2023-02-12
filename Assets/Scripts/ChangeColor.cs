using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public void ColorBlue() => GetComponent<MeshRenderer>().material.color = Color.blue;
    public void ColorRed() => GetComponent<MeshRenderer>().material.color = Color.red;
    public void Colorgreen() => GetComponent<MeshRenderer>().material.color = Color.green;
}
