using AAEmu.Commons.Network;
using AAEmu.Game.Core.Network.Game;
using AAEmu.Game.Models.Game;

namespace AAEmu.Game.Core.Packets.G2C
{
    public class SCFamilyCreatedPacket : GamePacket
    {
        private readonly Family _family;
        
        public SCFamilyCreatedPacket(Family family) : base(0x02d, 1) // TODO 1.0 opcode: 0x029
        {
            _family = family;
        }

        public override PacketStream Write(PacketStream stream)
        {
            stream.Write(_family);
            return stream;
        }
    }
}