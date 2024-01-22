using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Gaze : MonoBehaviour
{
    List<InfoBehavior> infos = new List<InfoBehavior>();
    public GameObject O1, O2, O3, O4, O5, O6, O7, O8;
    private Animation A1, A2, A3, A4, A5, A6, A7, A8;
    void Start()
    {
        infos = FindObjectsOfType<InfoBehavior>().ToList();
        A1 = O1.GetComponent<Animation>();
        A2 = O2.GetComponent<Animation>();
        A3 = O3.GetComponent<Animation>();
        A4 = O4.GetComponent<Animation>();
        A5 = O5.GetComponent<Animation>();
        A6 = O6.GetComponent<Animation>();
        A7 = O7.GetComponent<Animation>();
        A8 = O8.GetComponent<Animation>();
    }
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
        {
            GameObject go = hit.collider.gameObject;
            if (go.CompareTag("O1"))
            {
                OpenInfo(go.GetComponent<InfoBehavior>());
                A1.Play("Airplugh");
            }
            else if (go.CompareTag("O2"))
            {
                OpenInfo(go.GetComponent<InfoBehavior>());
                A2.Play("Sepatu Safety");
            }
            else if (go.CompareTag("O3"))
            {
                OpenInfo(go.GetComponent<InfoBehavior>());
                A3.Play("Face Shield");
            }
            else if (go.CompareTag("O4"))
            {
                OpenInfo(go.GetComponent<InfoBehavior>());
                A4.Play("Rompi");
            }
            else if (go.CompareTag("O5"))
            {
                OpenInfo(go.GetComponent<InfoBehavior>());
                A5.Play("Glove");
            }
            else if (go.CompareTag("O6"))
            {
                OpenInfo(go.GetComponent<InfoBehavior>());
                A6.Play("Kacamata");
            }
            else if (go.CompareTag("O7"))
            {
                OpenInfo(go.GetComponent<InfoBehavior>());
                A7.Play("Helm");
            }
            else if (go.CompareTag("O8"))
            {
                OpenInfo(go.GetComponent<InfoBehavior>());
                A8.Play("Mask");
            }
            else
            {
                OpenInfo(go.GetComponent<InfoBehavior>());
            }
        }
        else
        {
            CloseAll();
            A1.Stop();
            A2.Stop();
            A3.Stop();
            A4.Stop();
            A5.Stop();
            A6.Stop();
            A7.Stop();
            A8.Stop();
        }
    }
    void OpenInfo(InfoBehavior desiredInfo)
    {
        foreach (InfoBehavior info in infos)
        {
            if (info == desiredInfo)
            {
                info.OpenInfo();
            }
            else
            {
                info.CloseInfo();
            }
        }
    }

    void CloseAll()
    {
        foreach (InfoBehavior info in infos)
        {
            info.CloseInfo();
        }
    }
}
