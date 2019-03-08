using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{

    public Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerTransform.position.y < 7)
        {
            death();
        }
    }

    void death()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

    








}
