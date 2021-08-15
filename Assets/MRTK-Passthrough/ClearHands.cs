using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearHands : MonoBehaviour
{
    public GameObject parent;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitAndClear());
    }

    IEnumerator WaitAndClear(){
        yield return new WaitForSeconds(1);
        ClearAllHands();
    }

    public void ClearAllHands(){
        foreach(Transform tr in parent.transform){
            if(tr.name.Contains("RiggedHand")){
                Destroy(tr.gameObject);
            }
        }
    }


}
