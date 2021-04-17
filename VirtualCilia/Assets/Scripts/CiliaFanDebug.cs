using System.Collections;
using UnityEngine;

public class CiliaFanDebug : MonoBehaviour
{
    [SerializeField] private byte FanSpeed = 255;
    [SerializeField] private SurroundPosition CiliaGroup = (SurroundPosition)0;
    [SerializeField] private SmellList Scent;
    [SerializeField] private byte red = 255;
    [SerializeField] private byte green = 255;
    [SerializeField] private byte blue = 255;


    void Start()
    {
        StartCoroutine(SetFan());
    }

    private IEnumerator SetFan()
    {
        //Debug.Log(CiliaModified.Instance.IsConnected);
        yield return new WaitUntil(() => CiliaModified.Instance.IsConnected);
        //Debug.Log(CiliaModified.Instance.IsConnected);
        CiliaModified.setFan(CiliaGroup, Scent, FanSpeed);
        CiliaModified.setLight(CiliaGroup, (uint)Scent + 1, red, green, blue);
    }

    private void FixedUpdate()
    {
        //Cilia.setFan(CiliaGroup, Scent, FanSpeed);
    }
}
