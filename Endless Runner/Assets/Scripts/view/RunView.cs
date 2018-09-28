using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class RunView : MonoBehaviour
{
    private PlayerView player;
    private WaveView wave;
    private ScreenView screen;
    void Awake()
    {
        screen = ((GameObject)Instantiate(Resources.Load("Prefab/ScreenView"), transform)).gameObject.AddComponent<ScreenView>();
        player = ((GameObject)Instantiate(Resources.Load("Prefab/PlayerView"), transform)).gameObject.AddComponent<PlayerView>();
        wave = ((GameObject)Instantiate(Resources.Load("Prefab/WaveView"), transform)).gameObject.AddComponent<WaveView>();
    }


    public void StartSession()
    {
        RunController.ME.StartSession();
        wave.CreateWave(RunController.ME.session.wave.creatures);
    }



}
