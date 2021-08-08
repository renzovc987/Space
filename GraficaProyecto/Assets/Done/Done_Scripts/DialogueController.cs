using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject dialogo;
    public Text texto;
    void Start()
    {
        dialogo.SetActive(true);
    }

    // Update is called once per frame
    void Decir()
    {
        dialogo.SetActive(false);
    }
    void Prueba(Collider other)
    {
        if (other.gameObject.CompareTag("gema"))
        {
            Decir();
        }

    }

}
