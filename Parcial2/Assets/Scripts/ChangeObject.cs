using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeObject : MonoBehaviour
{

    private IChangeObject Ico;

    private void Start()
    { //Referencias a componentes
        Ico = gameObject.GetComponent<IChangeObject>();
        Ico.MO = gameObject.GetComponent<ManageObjects>();
    }
     
    public void ChangeObjectBehaviour()
    {
        Ico.HandleObject();
    }
   
}


