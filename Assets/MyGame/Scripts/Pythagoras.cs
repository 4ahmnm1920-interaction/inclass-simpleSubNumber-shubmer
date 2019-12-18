using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pythagoras : MonoBehaviour
{
    public int value;
    public float a;
    public float b;
    // Start is called before the first frame update
    void Start()
    {
        //int result = Calculate(4) + Calculate(4);
        //Debug.Log("result Addition: " + result);
        //Calculate(value);
        //Calculate(value * value);
        Method1(a, b);
        float result = Method1(a, b)+ Method1(a, b);
        Debug.Log("result" + result);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int Calculate(int a)
    {
        Debug.Log("result Calculate" + a* a);
        return (a * a); 

    }
    /*private void OnValidate()
    {
        Calculate(value);
    }*/

    float Method1(float a, float b)
    {
        float cSquare;
        cSquare = (a * a) + (b * b);
        float c = Mathf.Sqrt(cSquare);
        Debug.Log("cSquare: " + cSquare);
        Debug.Log("c: " + c);
        return c;

    }
}
