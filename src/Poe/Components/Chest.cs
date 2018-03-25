namespace PoeHUD.Poe.Components
{
    public class Chest : Component
    {
        public bool IsOpened => Address != 0 && M.ReadByte(Address + 0x40) == 1;
        public bool IsLocked => Address != 0 && M.ReadByte(Address + 0x41) > 1;
        public bool IsStrongbox => Address != 0 && M.ReadInt(Address + 0x83) > 0;

        private long StrongboxData => M.ReadLong(Address + 0x20);

        public bool DestroyingAfterOpen => Address != 0 && M.ReadByte(StrongboxData + 0x20) == 1;
        public bool IsLarge => Address != 0 && M.ReadByte(StrongboxData + 0x21) == 1;
        public bool Stompable => Address != 0 && M.ReadByte(StrongboxData + 0x22) == 1;
        public bool OpenOnDamage => Address != 0 && M.ReadByte(StrongboxData + 0x25) == 1;
    }
}