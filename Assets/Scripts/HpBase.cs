using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class HpBase : MonoBehaviour
{
    public int HP = 100;

    public Text HPtext;
    
    void Update()
    {
        HPtext.text = HP.ToString();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("enemy"))
        {
            HP -= 10;
            Destroy(other.gameObject);
            Destroy(other.GetComponent<MoveToWayPoints>().hp);
        }
    }
}