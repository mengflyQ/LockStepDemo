﻿using System.Collections.Generic;
using fogs.proto.msg;

public class TurnManager : Singleton<TurnManager>
{
    public uint CurTurnID { get; private set; }
    public uint ServerTurnID;
    public int PendingTurnNum { get { return turnQ.Count; } }

    public System.Action<FrameInfo> onNewTurn;

    Queue<FrameInfo> turnQ = new Queue<FrameInfo>();

    public void NewTurn(FrameInfo info)
    {
        //Logger.Log("Receive new turn: " + info.frameNum + " " + info.time);
        //foreach (ClientInput input in info.info)
        //{
        //    if (input.dir != 0)
        //        Logger.Log("Input: " + input.acc_id + " " + input.dir + " " + input.cmd);
        //}
        if (info.frameNum != ServerTurnID + 1)
            Logger.LogError("Discontinuous turn ID. " + ServerTurnID + " " + info.frameNum);
        ServerTurnID = info.frameNum;
        turnQ.Enqueue(info);
        if (onNewTurn != null)
            onNewTurn(info);
    }

    public FrameInfo NextTurn()
    {
        if (turnQ.Count > 0)
        {
            FrameInfo turn = turnQ.Dequeue();
            CurTurnID = turn.frameNum;
            return turn;
        }
        return null;
    }
}
