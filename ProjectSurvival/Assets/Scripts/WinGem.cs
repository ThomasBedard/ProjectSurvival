using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class WinGem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        EditorApplication.isPlaying = false;
    }

}