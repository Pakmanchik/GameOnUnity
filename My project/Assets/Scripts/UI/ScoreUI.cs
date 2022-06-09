using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
public class ScoreUI : MonoBehaviour
{
    private Text textToEdit;
    [SerializeField] private HeroFighter hv;

    void Start()
    {
        textToEdit = GetComponent<Text>();
        ss();
    }
    public void ss()
    {
        textToEdit.text = hv.ScoreAll.ToString();
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
