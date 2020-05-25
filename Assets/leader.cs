using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leader : MonoBehaviour
{

    public Sprite maleLead;

    // Start is called before the first frame update
    void Start()
    {
        var v = Hooks.GetVoicePath();
        if (v.Equals("мужской/"))
        {
            GetComponent<SpriteRenderer>().sprite = maleLead;
        }
        StartCoroutine(disaper());
    }


    public IEnumerator disaper()
    {
        yield return new WaitForSeconds(4.0f);

        while(transform.position.x < 14)
        {
            transform.position += new Vector3(0.05f, 0, 0);
            yield return new WaitForSeconds(0.01f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
