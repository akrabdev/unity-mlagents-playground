using System.Collections;
using System.Collections.Generic;
using Unity.MLAgents;
using UnityEngine;


/// <summary>
/// Npc follow player machine learning agent
/// </summary>
public class NPCAGENT : Agent
{


    // overwrite some functionalities in Agent

    //variables
    [Tooltip("Force to apply when moving")]
    public float moveForce = 2f;


    [Tooltip("Speed to rotate around Y axis")]
    public float yawSpeed = 100f;


    [Tooltip("Transform at the tip of the moster")]
    public Transform monsterFront;


    [Tooltip("The agent's camera")]
    public Camera agentCamera;

    [Tooltip("training mode?")]

    public bool trainingMode;





    // rigidbody of the agent
    new private Rigidbody rigidbody;
    // nearest player
    private GameObject nearestPlayer;
    // Maximum distance from monster front to accept collision mabye used to activate ability? 
    private const float monstFrontRadius = 0.008f;

    //Whether the aent is frozen (intentioanlly not flying)
    private bool frozen = false;



    /// Initialize the agent
    public override void Initialize()
    {
        rigidbody = GetComponent<Rigidbody>();


        // If not training mode, no max step , play forever
        if (!trainingMode)
        {
            MaxStep = 0;
        }

    }

    /// Reset the agent when an eposide beigns

    public override void OnEpisodeBegin()
    {
        if (trainingMode)
        {
            /*
            //  transform player location randomly
            // ex: Player.transformFunc .. see flowerarea.cs
             */
        }

        // reset velocity ,angular velocity , hp? before new episode begins
        rigidbody.velocity = Vector3.zero;
        rigidbody.angularVelocity = Vector3.zero;

        // Random Spawn location of monster:



        // #TODO
        // MovetoSafeRandomPosition();

        // #TODO
        // Recalculate the location of the player
        // UpdatePlayerLocation() 



    }


}
