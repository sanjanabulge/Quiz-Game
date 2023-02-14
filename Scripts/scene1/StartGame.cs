using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject BGM;
    public GameObject FrontImage;
    public GameObject FrontText;
    
    void Start()
    {
        
    }

    IEnumerator FrontEnd()
    {
        yield return new WaitForSeconds(4);
        BGM.SetActive(true);
        yield return new WaitForSeconds(1);
        FrontText.SetActive(false);
        FrontImage.SetActive(false);
    }

   
}
