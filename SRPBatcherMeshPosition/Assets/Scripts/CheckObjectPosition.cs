using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckObjectPosition : MonoBehaviour
{
    [SerializeField]
    float printTime = 1f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PrintPosition(printTime));
       
    }

    IEnumerator PrintPosition(float time)
    {
        yield return new WaitForSeconds(time);
        Debug.Log("GameObject " + gameObject.name.ToString() + " position: " + gameObject.GetComponent<MeshRenderer>().transform.position);
    }
}
