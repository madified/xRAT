﻿using ProtoBuf;

namespace xServer.Core.Packets.ServerPackets
{
    [ProtoContract]
    public class Reconnect : IPacket
    {
        public Reconnect()
        {
        }

        public void Execute(Client client)
        {
            client.Send(this);
        }
    }
}