using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class s1 : MonoBehaviour
{
    public Text obj;
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == ("Player"))
        {
            obj.text = "5%";
        }
    }
}
