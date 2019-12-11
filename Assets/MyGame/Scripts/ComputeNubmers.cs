using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComputeNubmers : MonoBehaviour
{
    public Text result;
    public InputField ipfVarA;
    public InputField ipfVarB;
    public Button btnSubNumbers;
    public Button btnReset;
    int index = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SubNumbersOnClick()
    {
        /*index++;
        Debug.Log("onClick" + index);
        Debug.Log("input Field A text is " + ipfVarA.text);
        Debug.Log("input Field B text is " + ipfVarB.text);*/
        int variableA = int.Parse(ipfVarA.text);
        int variableB = int.Parse(ipfVarB.text);
        int Subresult = variableA - variableB;
        //Debug.Log("result " + (variableA - variableB));
        result.text = Subresult.ToString();
        ipfVarA.interactable = false;
        ipfVarB.interactable = false;
        btnSubNumbers.interactable = false;
        btnReset.interactable = true;

    }

    public void ResetOnClick()
    {
        ipfVarA.interactable = true;
        ipfVarB.interactable = true;
        btnSubNumbers.interactable = true;
        btnReset.interactable = false;

        result.text = "Result";
        ipfVarA.text = " ";
        ipfVarB.text = " ";
    }

}
