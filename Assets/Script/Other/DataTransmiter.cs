using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataTransmiter : MonoBehaviour
{
    public static DataTransmiter Instance;

    [SerializeField] private BallInputControl ballInputControl;
    [SerializeField] private ScoreControl ScoreControl;
    [SerializeField] private FailPanelControl FailPanelControl;

    public ScoreControl GetScoreControl() => ScoreControl;
    public FailPanelControl GetFailPanelControl() => FailPanelControl;
    public Vector3 GetBallDirection() => ballInputControl.ballDirection;

    private void Awake()
    {
        Instance = this;
    }
}
